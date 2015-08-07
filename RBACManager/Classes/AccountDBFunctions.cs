using System.Collections.Generic;

namespace RBACManager
{
    public class AccountDBFunctions
    {
        private Mysql connection;

        public AccountDBFunctions(Mysql mysqlConnection) 
        {
            this.connection = mysqlConnection;
            connection.OpenConnection();
        }

        public bool UsernameExists(string username)
        {
            return connection.ExecuteIntResult("SELECT COUNT(id) FROM account WHERE username = ?;", username) > 0;
        }

        public bool CreateAccount(string username, string password, int expansion)
        {
            return connection.ExecuteQuery("INSERT INTO account(username, sha_pass_hash, expansion) VALUES(?, SHA1(CONCAT(UPPER(?), ':', UPPER(?))), ?);",  username, username, password, expansion);
        }

        public List<IDAndName> GetAccountList()
        {
            return connection.GetListOfIDAndName("SELECT `id`, `username` AS name FROM `account` ORDER BY username ASC;");
        }

        public List<IDAndName> GetGivenPermissionsOfAccount(int accountID)
        {
            return connection.GetListOfIDAndName("SELECT * FROM `rbac_permissions` WHERE id IN(SELECT permissionId FROM rbac_account_permissions WHERE accountId = ?) AND id NOT IN(Select id FROM rbac_linked_permissions GROUP BY id) ORDER BY id ASC;", accountID);
        }

        public List<IDAndName> GetNotGivenPermissionsOfAccount(int accountID)
        {
            return connection.GetListOfIDAndName("SELECT * FROM `rbac_permissions` WHERE id NOT IN(SELECT permissionId FROM rbac_account_permissions WHERE accountId = ?) AND id NOT IN(Select id FROM rbac_linked_permissions GROUP BY id) ORDER BY id ASC;", accountID);
        }

        public List<IDAndName> GetRolesAccountHas(int accountID)
        {
            return connection.GetListOfIDAndName("SELECT * FROM `rbac_permissions` WHERE id IN(Select id FROM rbac_linked_permissions GROUP BY id) AND id IN(SELECT permissionId FROM rbac_account_permissions WHERE accountId = ?) ORDER BY id ASC;", accountID);
        }

        public List<IDAndName> GetRolesAccountHasNot(int accountID)
        {
            return connection.GetListOfIDAndName("SELECT * FROM `rbac_permissions` WHERE id IN(Select id FROM rbac_linked_permissions GROUP BY id) AND id NOT IN(SELECT permissionId FROM rbac_account_permissions WHERE accountId = ?) ORDER BY id ASC;", accountID);
        }

        public bool AddPermissionToAccount(int permissionID, int accountID)
        {
            return connection.ExecuteQuery("INSERT INTO rbac_account_permissions(accountId, permissionId) VALUES (?, ?);", accountID, permissionID);
        }

        public bool RemovePermissionFromAccount(int permissionID, int accountID)
        {
            return connection.ExecuteQuery("DELETE FROM rbac_account_permissions WHERE accountId = ? AND permissionId = ?;", accountID, permissionID);
        }

        public string GetEmail(int accountID)
        {
            return connection.ExecuteStringResult("SELECT email FROM account WHERE id = ?;", accountID);
        }

        public bool SetEmail(int accountID, string email)
        {
            return connection.ExecuteQuery("UPDATE account SET email = ? WHERE id = ?;", email, accountID);
        }

        public int GetExpansion(int accountID)
        {
            return connection.ExecuteIntResult("SELECT expansion FROM account WHERE id = ?;", accountID);
        }

        public bool SetExpansion(int accountID, byte expansion)
        {
            return connection.ExecuteQuery("UPDATE account SET expansion = ? WHERE id = ?;", expansion, accountID);
        }

        public string GetLastIP(int accountID)
        {
            return connection.ExecuteStringResult("SELECT last_ip FROM account WHERE id = ?;", accountID);
        }

        public string GetJoinDate(int accountID)
        {
            return connection.ExecuteStringResult("SELECT DATE_FORMAT(joindate, GET_FORMAT(DATETIME,'ISO')) FROM account WHERE id = ?;", accountID);
        }

        public string GetLastLogin(int accountID)
        {
            return connection.ExecuteStringResult("SELECT DATE_FORMAT(last_login, GET_FORMAT(DATETIME,'ISO')) FROM account WHERE id = ?;", accountID);
        }

        public bool SetNewPassword(int accountID, string username, string password)
        {
            return connection.ExecuteQuery("UPDATE account SET sha_pass_hash = SHA1(CONCAT(UPPER(?), ':', UPPER(?))) WHERE id = ?;", username, password, accountID);
        }
    }
}
