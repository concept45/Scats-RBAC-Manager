using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBACManager
{
    public class RBACManagerModel
    {

#region Public
        public RBACManagerModel(string settingsPath)
        {
            this.settingsPath = settingsPath;
            databaseSettings = new MysqlModel();
            ini = new IniFile();
            LoadSettings();
            mysqlConnection = new Mysql(databaseSettings);
        }

        public Mysql GetMysqlConnection()
        {
            return mysqlConnection;
        }

        public static string GetApplicationTitle()
        {
            return "Scat\'s RBAC Manager";
        }

        public string GetSettingsPath()
        {
            return settingsPath;
        }

        public MysqlModel GetDatabaseSettings()
        {
            return databaseSettings;
        }

        public IniFile GetIniFile()
        {
            return ini;
        }
#endregion

#region Private

        private void LoadSettings()
        {
            ini.Load(settingsPath);
            databaseSettings.Host = ini.GetKeyValue("mysql", "ip");
            databaseSettings.Port = Convert.ToUInt16(ini.GetKeyValue("mysql", "port"));
            databaseSettings.User = ini.GetKeyValue("mysql", "user");
            databaseSettings.Password = ini.GetKeyValue("mysql", "pass");
            databaseSettings.Database = ini.GetKeyValue("mysql", "authdb");
        }

        private MysqlModel databaseSettings;
        private Mysql mysqlConnection;
        private string settingsPath;
        private IniFile ini;

#endregion
    }
}
