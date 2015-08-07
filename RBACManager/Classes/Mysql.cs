using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace RBACManager
{
    public struct IDAndName
    {
        public IDAndName(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public string name;
        public int id;
    }

    public struct IDAndID
    {
        public IDAndID(int id1, int id2)
        {
            this.id1 = id1;
            this.id2 = id2;
        }

        public int id1;
        public int id2;
    }

    public class Mysql : IDisposable
    {
        MySqlConnection connection;
        string connectionString;
        public string stdError = "A MySQL error occured.";
        bool isOpen;
        
        
        public Mysql(MysqlModel databaseSettings)
        {
            SetConnectionString(databaseSettings.Host, databaseSettings.Port, databaseSettings.User, databaseSettings.Password, databaseSettings.Database);
            connection = new MySqlConnection(connectionString);
            isOpen = false;
        }

        private void SetConnectionString(string host, ushort port, string user, string password, string database)
        {
            connectionString = string.Format("Server={0};Uid={1};Pwd={2};Database={3};Port={4};", host, user, password, database, Convert.ToString(port));
        }

        public void UpdateConnection(MysqlModel databaseSettings)
        {
            bool opened = isOpen;
            CloseConnection();
            SetConnectionString(databaseSettings.Host, databaseSettings.Port, databaseSettings.User, databaseSettings.Password, databaseSettings.Database);
            connection.ConnectionString = connectionString;
            if (opened)
            {
                OpenConnection();
            }
        }

        public bool OpenConnection()
        {
            try
            {
                if (!isOpen)
                {
                    connection.Open();
                    isOpen = true;
                    return true;
                }

            }
            catch
            {}
            return false;
        }

        public void CloseConnection()
        {
            connection.Close();
            isOpen = false;
        }

        public bool IsValidDatabase()
        {
            return DatabaseContainsNeededTables()
                && AccountTableHasNeededColumns()
                //&& AccountAccessTableHasNeededColumns()
                && RBACAccountPermissionsTableHasNeededColumns()
                //&& RBACDefaultPermissionsTableHasNeededColumns()
                && RBACLinkedPermissionsTableHasNeededColumns()
                && RBACPermissionsTableHasNeededColumns();
        }

        private bool DatabaseContainsNeededTables()
        {
            MySqlCommand command = new MySqlCommand("SHOW TABLES;", connection);

            try
            {
                MySqlDataReader Reader = command.ExecuteReader();

                List<string> tables = new List<string>();

                while (Reader.Read())
                {
                    tables.Add(Reader.GetString(0));
                }
                Reader.Close();
                return ListContainsNeededTables(tables);
            }
            catch (MySqlException mex)
            {
                throw mex;
            }
        }

        private bool ListContainsNeededTables(List<string> list)
        {
            if ( list.Contains("account") 
              //&& list.Contains("account_access") 
              && list.Contains("rbac_account_permissions") 
              //&& list.Contains("rbac_default_permissions") 
              && list.Contains("rbac_linked_permissions") 
              && list.Contains("rbac_permissions")
               )
                return true;

            return false;
        }

        private bool AccountTableHasNeededColumns()
        {
            List<string> columns = new List<string>(new string[] { "id", "username", "sha_pass_hash", "email", "joindate", "last_ip", "expansion" });
            return TableContainsNeededColumns("account", columns);
        }

        private bool AccountAccessTableHasNeededColumns()
        {
            List<string> columns = new List<string>(new string[] { "id", "gmlevel", "RealmID" });
            return TableContainsNeededColumns("account_access", columns);
        }

        private bool RBACAccountPermissionsTableHasNeededColumns()
        {
            List<string> columns = new List<string>(new string[] { "accountId", "permissionId", "granted", "realmId" });
            return TableContainsNeededColumns("rbac_account_permissions", columns);
        }

        private bool RBACDefaultPermissionsTableHasNeededColumns()
        {
            List<string> columns = new List<string>(new string[] { "secId", "permissionId" });
            return TableContainsNeededColumns("rbac_default_permissions", columns);
        }

        private bool RBACLinkedPermissionsTableHasNeededColumns()
        {
            List<string> columns = new List<string>(new string[] { "id", "linkedId" });
            return TableContainsNeededColumns("rbac_linked_permissions", columns);
        }

        private bool RBACPermissionsTableHasNeededColumns()
        {
            List<string> columns = new List<string>(new string[] { "id", "name" });
            return TableContainsNeededColumns("rbac_permissions", columns);
        }

        private bool TableContainsNeededColumns(string tableName, List<string> neededColumns)
        {
            List<string> tableColumns = GetColumnsFromTable(tableName);
            foreach (string column in neededColumns)
            {
                if (!tableColumns.Contains(column))
                {
                    return false;
                }
            }
            return true;
        }

        private List<string> GetColumnsFromTable(string tableName)
        {
            string sqlQuery = "DESCRIBE " + tableName + ";";
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            MySqlDataReader Reader;
            List<string> columns = new List<string>();
            try
            {
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    columns.Add(Reader.GetString("Field"));
                }
                Reader.Close();

            }
            catch (MySqlException)
            { }

            return columns;
        }

        public List<IDAndName> GetListOfIDAndName(string sqlQuery, params object[] args)
        {

            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            foreach (var para in args)
                command.Parameters.Add(new MySqlParameter("", para));

            MySqlDataReader Reader;
            List<IDAndName> entryList = new List<IDAndName>();
            try
            {
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    IDAndName entry = new IDAndName(Reader.GetString("name"), Reader.GetInt32("id"));
                    entryList.Add(entry);
                }
                Reader.Close();

            }
            catch (MySqlException)
            {}

            return entryList;
            
        }

        public List<SecurityLevel> GetListOfSecurityLevel(string sqlQuery, params object[] args)
        {

            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            foreach (var para in args)
                command.Parameters.Add(new MySqlParameter("", para));

            MySqlDataReader Reader;
            List<SecurityLevel> entryList = new List<SecurityLevel>();
            try
            {
                Reader = command.ExecuteReader();

                while (Reader.Read())
                {
                    SecurityLevel entry = new SecurityLevel(Reader.GetInt32("secId"), Reader.GetInt32("permissionId"), Reader.GetString("name"));
                    entryList.Add(entry);
                }
                Reader.Close();

            }
            catch (MySqlException)
            { }

            return entryList;

        }

        public bool ExecuteQuery(string sqlQuery, params object[] args)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);
            
            foreach (var para in args)
                command.Parameters.Add(new MySqlParameter("", para));

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException)
            {}

            return false;
        }

        public int ExecuteIntResult(string sqlQuery, params object[] args)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            foreach (var para in args)
                command.Parameters.Add(new MySqlParameter("", para));

            int result = 0;

            try
            {
                result = Convert.ToInt32(command.ExecuteScalar());
                return result;
            }
            catch (MySqlException)
            {}

            return result;
        }

        public string ExecuteStringResult(string sqlQuery, params object[] args)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, connection);

            foreach (var para in args)
                command.Parameters.Add(new MySqlParameter("", para));

            string result = "";

            try
            {
                result = Convert.ToString(command.ExecuteScalar());
                return result;
            }
            catch (MySqlException)
            {}

            return result;
        }

        public void Dispose()
        {
            connection.Close();
            connectionString = null;
        }
    }
}
