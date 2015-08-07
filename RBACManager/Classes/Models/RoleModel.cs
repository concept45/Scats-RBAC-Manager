using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RBACManager
{
    class RoleModel
    {
        public RoleDBFunctions roleFunctions;
        private List<IDAndName> roleList;
        private Role currentRole;

        public RoleModel(Mysql mysqlConnection)
        {
            roleFunctions = new RoleDBFunctions(mysqlConnection);
				currentRole = null;
            LoadRoleList();
        }

        public List<IDAndName> GetRoleList(bool reloadFromDB = false)
        {
            if (reloadFromDB)
                LoadRoleList();

            return roleList;
        }

        private void LoadRoleList()
        {
            roleList = new List<IDAndName>();
            roleList = roleFunctions.GetRoleList();
        }

        public List<IDAndName> GetRoleList(string name)
        {
            List<IDAndName> roles = new List<IDAndName>();

            foreach (IDAndName r in roleList)
            {
                if (r.name.ToLower().Contains(name.ToLower()))
                {
                    roles.Add(r);
                }
            }
            return roles;
        }

        public void LoadRole(int roleID, string roleName)
        {
            currentRole = new Role();
            currentRole.id = roleID;
            currentRole.name = roleName;
            LoadPermissionsOfRole();
        }

        private void LoadPermissionsOfRole()
        {
            List<IDAndName> perm1 = roleFunctions.GetGivenPermissionsOfRole(currentRole.id);
            foreach (IDAndName perm in perm1)
            {
                Permission p = new Permission(perm.id, perm.name, true);
                currentRole.AddPermissionToRole(p);
            }

            List<IDAndName> perm2 = roleFunctions.GetNotGivenPermissionsOfRole(currentRole.id);
            foreach (IDAndName perm in perm2)
            {
                Permission p = new Permission(perm.id, perm.name, false);
                currentRole.AddPermissionToRole(p);
            }
        }

        public List<IDAndName> GetPermissionsRoleHas()
        {
            return currentRole.GetPermissionsRoleHas();
        }

        public List<IDAndName> GetPermissionsRoleHasNot()
        {
            return currentRole.GetPermissionsRoleHasNot();
        }

        public void AddPermissionToRole(int permissionID)
        {
            if (currentRole.SetPermissionGrantedState(permissionID, true))
                roleFunctions.AddPermissionToRole(permissionID, currentRole.id);
        }

        public void RemovePermissionFromRole(int permissionID)
        {
            if (currentRole.SetPermissionGrantedState(permissionID, false))
                roleFunctions.RemovePermissionFromRole(permissionID, currentRole.id);
        }

        public bool SetRoleName(string newName)
        {
            if (roleFunctions.UpdateRoleName(currentRole.id, newName))
            {
                currentRole.name = newName;
                return true;
            }
            
            return false;
        }

        public bool RoleIsSet()
        {
            if (currentRole != null)
                return true;

            return false;
        }

        public void UnsetRole()
        {
            currentRole = null;
        }

        public bool DeleteRole(int roleID)
        {
            if (roleFunctions.DeleteRole(roleID))
            {
                for (int i = 0; i < roleList.Count; i++)
                {
                    if (roleList[i].id == roleID)
                        roleList.RemoveAt(i);
                }

                return true;
            }
            
            return false;
        }

        public int GetCurrentRoleID()
        {
            return (currentRole != null ? currentRole.id : -1);
        }
        
    }
}
