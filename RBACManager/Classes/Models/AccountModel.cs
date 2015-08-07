using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RBACManager
{
    class AccountModel
    {
        public AccountDBFunctions accountFunctions;
        private List<IDAndName> accountList;
        private Account currentAccount;

        public AccountModel(Mysql mysqlConnection)
        {
            this.accountFunctions = new AccountDBFunctions(mysqlConnection);
            LoadAccountList();
        }

        public List<IDAndName> GetAccountList(bool reloadFromDB = false)
        {
            if (reloadFromDB)
                LoadAccountList();

            return accountList;
        }

        private void LoadAccountList()
        {
            accountList = new List<IDAndName>();
            accountList = accountFunctions.GetAccountList();
        }

        public List<IDAndName> GetAccountList(string name)
        {
            List<IDAndName> accs = new List<IDAndName>();

            foreach (IDAndName acc in accountList)
            {
                if (acc.name.ToLower().Contains(name.ToLower()))
                {
                    accs.Add(acc);
                }
            }
            return accs;
        }

        public void LoadAccount(int accountID, string accountName)
        {
            currentAccount = null;
            currentAccount = new Account();
            currentAccount.Id = accountID;
            currentAccount.Name = accountName;
            currentAccount.Expansion = Convert.ToByte(accountFunctions.GetExpansion(accountID));
            currentAccount.JoinDate = accountFunctions.GetJoinDate(accountID);
            currentAccount.LastIP = accountFunctions.GetLastIP(accountID);
            currentAccount.LastLogin = accountFunctions.GetLastLogin(accountID);
            currentAccount.Email = accountFunctions.GetEmail(accountID);
            LoadPermissionsOfAccount();
            LoadRolesOfAccount();
        }

        private void LoadPermissionsOfAccount()
        {
            List<IDAndName> perm1 = accountFunctions.GetGivenPermissionsOfAccount(currentAccount.Id);
            foreach (IDAndName perm in perm1)
            {
                Permission p = new Permission(perm.id, perm.name, true);
                currentAccount.AddPermissionToAccount(p);
            }

            List<IDAndName> perm2 = accountFunctions.GetNotGivenPermissionsOfAccount(currentAccount.Id);
            foreach (IDAndName perm in perm2)
            {
                Permission p = new Permission(perm.id, perm.name, false);
                currentAccount.AddPermissionToAccount(p);
            }
        }

        private void LoadRolesOfAccount()
        {
            List<IDAndName> roles1 = accountFunctions.GetRolesAccountHas(currentAccount.Id);
            foreach (IDAndName role in roles1)
            {
                Permission p = new Permission(role.id, role.name, true);
                currentAccount.AddRoleToAccount(p);
            }

            List<IDAndName> roles2 = accountFunctions.GetRolesAccountHasNot(currentAccount.Id);
            foreach (IDAndName role in roles2)
            {
                Permission p = new Permission(role.id, role.name, false);
                currentAccount.AddRoleToAccount(p);
            }
        }

        public List<IDAndName> GetPermissionsAccountHas()
        {
            return currentAccount.GetPermissionsAccountHas();
        }

        public List<IDAndName> GetPermissionsAccountHasNot()
        {
            return currentAccount.GetPermissionsAccountHasNot();
        }

        public List<IDAndName> GetRolesAccountHas()
        {
            return currentAccount.GetRolesAccountHas();
        }

        public List<IDAndName> GetRolesAccountHasNot()
        {
            return currentAccount.GetRolesAccountHasNot();
        }

        public void AddPermissionToAccount(int permissionID)
        {
            if (currentAccount.SetPermissionGrantedState(permissionID, true))
                accountFunctions.AddPermissionToAccount(permissionID, currentAccount.Id);
        }

        public void RemovePermissionFromAccount(int permissionID)
        {
            if(currentAccount.SetPermissionGrantedState(permissionID, false))
                accountFunctions.RemovePermissionFromAccount(permissionID, currentAccount.Id);
        }

        public void AddRoleToAccount(int roleID)
        {
            if (currentAccount.SetRoleGrantedState(roleID, true))
                accountFunctions.AddPermissionToAccount(roleID, currentAccount.Id);
        }

        public void RemoveRoleFromAccount(int roleID)
        {
            if (currentAccount.SetRoleGrantedState(roleID, false))
                accountFunctions.RemovePermissionFromAccount(roleID, currentAccount.Id);
        }

        public string GetAccountEmail()
        {
            return currentAccount.Email;
        }

        public string GetAccountIP()
        {
            return currentAccount.LastIP;
        }

        public string GetAccountLastLogin()
        {
            return currentAccount.LastLogin;
        }

        public byte GetAccountExpansion()
        {
            return currentAccount.Expansion;
        }

        public string GetAccountJoinDate()
        {
            return currentAccount.JoinDate;
        }

        public bool SetAccountPassword(string password)
        {
            return accountFunctions.SetNewPassword(currentAccount.Id, currentAccount.Name, password);
        }

        public bool SetAccountEmail(string email)
        {
            if (accountFunctions.SetEmail(currentAccount.Id, email))
            {
                currentAccount.Email = email;
                return true;
            }
            
            return false;
        }

        public bool SetAccountExpansion(byte expansion)
        {
            if (accountFunctions.SetExpansion(currentAccount.Id, expansion))
            {
                 currentAccount.Expansion = expansion;
                 return true;
            }
           
            return false;
        }

        public bool AccountIsSet()
        {
            if (currentAccount != null)
                return true;

            return false;
        }

        public void UnsetAccount()
        {
            currentAccount = null;
        }
    }
}
