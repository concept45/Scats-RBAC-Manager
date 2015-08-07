using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RBACManager
{
    class SecurityLevelModel
    {
        SecurityLevelDBFunctions securityLevelFunctions;
        List<SecurityLevel> securityLevels;

        public SecurityLevelModel(Mysql mysqlConnection)
        {
            securityLevelFunctions = new SecurityLevelDBFunctions(mysqlConnection);
            securityLevels = securityLevelFunctions.GetSecurityLevelList();
        }

        public void RefreshSecurityLevelList()
        {
            securityLevels = securityLevelFunctions.GetSecurityLevelList();
        }
        
        public List<SecurityLevel> GetSecurityLevels()
        {
            return securityLevels;
        }

        public void CreateSecurityLevel(int id, int roleId)
        {
            securityLevelFunctions.CreateSecurityLevel(id, roleId);
        }

        public void DeleteSecurityLevel(int id)
        {
            securityLevelFunctions.DeleteSecurityLevel(id);
        }
    }
}
