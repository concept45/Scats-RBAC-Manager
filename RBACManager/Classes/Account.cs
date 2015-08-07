///--------------------------------------------------------------------
///--------------- Copyright © 2013-2014 by Daniel Otto ---------------
///--------------------------------------------------------------------


using System.Collections.Generic;

namespace RBACManager
{
	class Account
	{
		public Account()
		{
			permissions = new List<Permission>();
			roles = new List<Permission>();
		}

		public int Id;
		public string Name;
		public byte Expansion;
		public string Email;
		public string LastIP;
		public string JoinDate;
		public string LastLogin;

		private List<Permission> permissions;
		private List<Permission> roles;

		public List<IDAndName> GetPermissionsAccountHas()
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

		public List<IDAndName> GetPermissionsAccountHasNot()
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

		public void AddPermissionToAccount(Permission perm)
		{
			permissions.Add(perm);
		}

		public List<IDAndName> GetRolesAccountHas()
		{
			List<IDAndName> r = new List<IDAndName>();

			foreach (Permission item in roles)
			{
				if (item.Granted == true)
				{
					r.Add(new IDAndName(item.Name, item.Id));
				}
			}

			return r;
		}
		public List<IDAndName> GetRolesAccountHasNot()
		{
			List<IDAndName> r = new List<IDAndName>();

			foreach (Permission item in roles)
			{
				if (item.Granted == false)
				{
					r.Add(new IDAndName(item.Name, item.Id));
				}
			}

			return r;
		}
		public void AddRoleToAccount(Permission role)
		{
			roles.Add(role);
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
		public bool SetRoleGrantedState(int roleID, bool granted)
		{
			int i = 0;
			while (i < roles.Count)
			{
				if (roles[i].Id == roleID)
				{
					this.roles[i].Granted = granted;
					return true;
				}

				i++;
			}

			return false;
		}
	}
}
