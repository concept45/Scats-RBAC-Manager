using System;
using System.Collections.Generic;
using System.Text;

namespace RBACManager
{
    class Role
    {
        public Role()
        {
            permissions = new List<Permission>();
        }

        public int id;
        public string name;

        List<Permission> permissions;

        public List<IDAndName> GetPermissionsRoleHas()
        {
            List<IDAndName> perm = new List<IDAndName>();

            foreach (Permission item in permissions)
            {
                if (item.Granted == true)
                {
                    perm.Add(new IDAndName(item.Name, item.Id));
                }
            }

            return perm;
        }

        public List<IDAndName> GetPermissionsRoleHasNot()
        {
            List<IDAndName> perm = new List<IDAndName>();

            foreach (Permission item in permissions)
            {
                if (item.Granted == false)
                {
                    perm.Add(new IDAndName(item.Name, item.Id));
                }
            }

            return perm;
        }

        public void AddPermissionToRole(Permission perm)
        {
            permissions.Add(perm);
        }

        public bool SetPermissionGrantedState(int permissionID, bool granted)
        {
            int i = 0;
            while (i < permissions.Count)
            {
                if (permissions[i].Id == permissionID)
                {
                    this.permissions[i].Granted = granted;
                    return true;
                }

                i++;
            }

            return false;
        }
    }
}
