using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RBACManager
{
    public class RoleDBFunctions
    {
        Mysql connection;
        public RoleDBFunctions(Mysql mysqlConnection)
        {
            connection = mysqlConnection;
            connection.OpenConnection();
        }

        public bool RoleExists(string roleName)
        {
            return connection.ExecuteIntResult("SELECT COUNT(id) FROM rbac_permissions WHERE name = ?;", roleName) > 0;
        }

        private int DetermineNewRoleID()
        {
            int id = 0;
            id = connection.ExecuteIntResult("SELECT MAX(id) FROM rbac_permissions;");
				if (id < 1000)
				{
					return 1000;
				}
            return (id + 1);
        }

        public bool CreateRole(string roleName)
        {
            int newId = DetermineNewRoleID();
            return connection.ExecuteQuery("INSERT INTO rbac_permissions(id, name) VALUES(?, ?); INSERT INTO rbac_linked_permissions(id, linkedId) VALUES(?, 507);", newId, roleName, newId);
        }

        public bool DeleteRole(int roleID)
        {
            return connection.ExecuteQuery("DELETE FROM rbac_permissions  WHERE id = ?; DELETE FROM rbac_linked_permissions WHERE id = ? OR linkedId = ?; DELETE FROM rbac_account_permissions WHERE permissionId = ?;",  roleID, roleID, roleID, roleID);
        }

        public List<IDAndName> GetRoleList()
        {
            return connection.GetListOfIDAndName("SELECT * FROM `rbac_permissions` AS p WHERE p.id IN(SELECT id FROM `rbac_linked_permissions` GROUP BY id) ORDER BY p.id ASC;");
        }
        
        public List<IDAndName> GetGivenPermissionsOfRole(int roleID)
        {
            return connection.GetListOfIDAndName("SELECT * FROM `rbac_permissions` WHERE id IN(SELECT linkedId FROM `rbac_linked_permissions` WHERE id = ?) ORDER BY id ASC;", roleID);
        }

        public List<IDAndName> GetNotGivenPermissionsOfRole(int roleID)
        {
            return connection.GetListOfIDAndName("SELECT * FROM `rbac_permissions` AS p WHERE p.id NOT IN(SELECT linkedId FROM `rbac_linked_permissions` WHERE id = ?) AND p.id NOT IN(SELECT id FROM `rbac_linked_permissions` GROUP BY id) ORDER BY p.id ASC;", roleID);
        }

        public bool AddPermissionToRole(int permissionID, int roleID)
        {
            return connection.ExecuteQuery("INSERT INTO rbac_linked_permissions(id, linkedId) VALUES(?, ?);", roleID, permissionID);
        }

        public bool RemovePermissionFromRole(int permissionID, int roleID)
        {
            return connection.ExecuteQuery("DELETE FROM rbac_linked_permissions WHERE id = ? AND linkedId = ?;", roleID, permissionID);
        }

        public bool UpdateRoleName(int roleID, string newName)
        {
            return connection.ExecuteQuery("UPDATE rbac_permissions SET name = ? WHERE id = ?", newName, roleID);
        }

    }
}