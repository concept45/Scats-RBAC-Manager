using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RBACManager
{
	public struct SecurityLevel
	{
		public SecurityLevel(int id, int roleID, string roleName)
		{
			this.id = id;
			this.role.id = roleID;
			this.role.name = roleName;
		}

		public int id;
		public IDAndName role;
	}

	public class SecurityLevelDBFunctions
	{
		Mysql connection;
		public SecurityLevelDBFunctions(Mysql mysqlConnection)
		{
			this.connection = mysqlConnection;
			mysqlConnection.OpenConnection();
		}

		public bool SecurityLevelExists(int id)
		{
			return connection.ExecuteIntResult("SELECT COUNT(secId) FROM rbac_default_permissions WHERE secID = ?;", id) > 0;
		}

		public List<SecurityLevel> GetSecurityLevelList()
		{
			return connection.GetListOfSecurityLevel("SELECT dp.secId, dp.permissionId, p.name FROM rbac_default_permissions dp, rbac_permissions p WHERE dp.permissionId = p.id;");
		}

		public int DetermineNewSecurityLevelID()
		{
			int id = 0;
			id = connection.ExecuteIntResult("SELECT MAX(secId) FROM rbac_default_permissions;");
			return (id + 1);
		}

		public bool CreateSecurityLevel(int id, int roleId)
		{
			return connection.ExecuteQuery("INSERT INTO rbac_default_permissions(secId, permissionId) VALUES(?, ?);", id, roleId);
		}

		public bool DeleteSecurityLevel(int id)
		{
			return connection.ExecuteQuery("DELETE FROM rbac_default_permission WHERE secId = ?; DELETE FROM account_access WHERE ", id);
		}
	}
}
