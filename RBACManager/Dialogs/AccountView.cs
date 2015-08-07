using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RBACManager
{
    public partial class AccountView : Form
    {
        AccountModel accountModel;
        private string searchPlaceholder = "Search for account";
        
        protected override void WndProc(ref Message message)
        {
            const int WM_NCHITTEST = 0x0084;
            switch (message.Msg)
            {
                case WM_NCHITTEST:
                    return;
            }
            base.WndProc(ref message);
        }

        RBACManagerModel model;

        public AccountView(RBACManagerModel model)
        {
            this.model = model;
            InitializeComponent();
        }
        
        private void accounts_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
            label_AccountName.Text = "";
            InitToolTips();

            accountModel = new AccountModel(model.GetMysqlConnection());
            LoadAccounts();
            Init_drpdwn_Expansion();
        }

        private void InitToolTips()
        {
            toolTip1.SetToolTip(btn_PermissionsAdd, "Add permission to account");
            toolTip1.SetToolTip(btn_PermissionsRemove, "Remove permission from account");
            toolTip1.SetToolTip(btn_RoleAdd, "Add role to account");
            toolTip1.SetToolTip(btn_RoleRemove, "Remove role from account");
            toolTip1.SetToolTip(btn_SearchAccount, "Search for account");
            toolTip1.SetToolTip(btn_SearchCancel, "Cancel search");
            toolTip1.SetToolTip(btn_CreateAccount, "Create account");
            toolTip1.SetToolTip(btn_EditAccount, "Edit account");
        }
        
        private void LoadAccounts(bool reloadFromDB = false)
        {
            tv_Accounts.Nodes.Clear();
            InitTreeViewWithList(tv_Accounts, accountModel.GetAccountList(reloadFromDB));
        }
        
        private void LoadAccountGivenPermissions()
        {
            tv_AccountGivenPermissions.Nodes.Clear();
            InitTreeViewWithList(tv_AccountGivenPermissions, accountModel.GetPermissionsAccountHas());
        }

        private void InitTreeViewWithList(TreeView tv, List<IDAndName> list)
        {
            foreach (IDAndName entry in list)
            {
                TreeNode tn = new TreeNode();
                tn.Text = entry.name;
                tn.Name = entry.id.ToString();
                tv.Nodes.Add(tn);
            }
        }

        private void LoadAccountNotGivenPermissions()
        {
            tv_AccountNotGivenPermissions.Nodes.Clear();
            InitTreeViewWithList(tv_AccountNotGivenPermissions, accountModel.GetPermissionsAccountHasNot());
        }

        private void LoadRolesAccountHas()
        {
            tv_RolesAccountHas.Nodes.Clear();
            InitTreeViewWithList(tv_RolesAccountHas, accountModel.GetRolesAccountHas());
        }

        private void LoadRolesAccountHasNot()
        {
            tv_RolesAccountHasNot.Nodes.Clear();
            InitTreeViewWithList(tv_RolesAccountHasNot, accountModel.GetRolesAccountHasNot());
        }

        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            EditAccount();
        }

        private void EditAccount()
        {
            if (tv_Accounts.Nodes.Count >= 1)
            {
                accountModel.LoadAccount(Convert.ToInt32(tv_Accounts.SelectedNode.Name), tv_Accounts.SelectedNode.Text);
                LoadAccountGivenPermissions();
                LoadAccountNotGivenPermissions();
                LoadRolesAccountHas();
                LoadRolesAccountHasNot();
                LoadAccountDetails();
                label_AccountName.Text = tv_Accounts.SelectedNode.Text;
            }
        }

        private void btn_PermissionsAdd_Click(object sender, EventArgs e)
        {
            if (accountModel.AccountIsSet() && tv_AccountNotGivenPermissions.Nodes.Count >= 1)
            {
                foreach (TreeNode node in tv_AccountNotGivenPermissions.Nodes)
                {
                    if (node.Checked == true)
                        accountModel.AddPermissionToAccount(Convert.ToInt32(node.Name));
                }

                LoadAccountGivenPermissions();
                LoadAccountNotGivenPermissions();
            }
        }

        private void btn_PermissionsRemove_Click(object sender, EventArgs e)
        {
            if (accountModel.AccountIsSet() && tv_AccountGivenPermissions.Nodes.Count >= 1)
            {
                foreach (TreeNode node in tv_AccountGivenPermissions.Nodes)
                {
                    if (node.Checked == true)
                        accountModel.RemovePermissionFromAccount(Convert.ToInt32(node.Name));
                }

                LoadAccountGivenPermissions();
                LoadAccountNotGivenPermissions();
            }
        }

        private void btn_RoleAdd_Click(object sender, EventArgs e)
        {
            if (accountModel.AccountIsSet() && tv_RolesAccountHasNot.Nodes.Count >= 1)
            {
                foreach (TreeNode node in tv_RolesAccountHasNot.Nodes)
                {
                    if (node.Checked == true)
                        accountModel.AddRoleToAccount(Convert.ToInt32(node.Name));
                }

                LoadRolesAccountHas();
                LoadRolesAccountHasNot();
            }
        }

        private void btn_RoleRemove_Click(object sender, EventArgs e)
        {
            if (accountModel.AccountIsSet() && tv_RolesAccountHas.Nodes.Count >= 1)
            {
                foreach (TreeNode node in tv_RolesAccountHas.Nodes)
                {
                    if (node.Checked == true)
                        accountModel.RemoveRoleFromAccount(Convert.ToInt32(node.Name));
                }

                LoadRolesAccountHas();
                LoadRolesAccountHasNot();
            }
        }

        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            Form f_create_acc = new CreateAccountDialog(accountModel.accountFunctions);
            if (f_create_acc.ShowDialog() == DialogResult.OK)
            {
                LoadAccounts(true);
            }
        }

        private void tv_Accounts_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            EditAccount();
        }

        private void SelectDoubleClickedNode(TreeView tv)
        {
            if (tv.Nodes.Count >= 1)
                tv.SelectedNode.Checked = !tv.SelectedNode.Checked;
        }

        private void tv_RolesAccountHas_DoubleClick(object sender, EventArgs e)
        {
            SelectDoubleClickedNode(tv_RolesAccountHas);
        }

        private void tv_RolesAccountHasNot_DoubleClick(object sender, EventArgs e)
        {
            SelectDoubleClickedNode(tv_RolesAccountHasNot);
        }

        private void tv_AccountGivenPermissions_DoubleClick(object sender, EventArgs e)
        {
            SelectDoubleClickedNode(tv_AccountGivenPermissions);
        }

        private void tv_AccountNotGivenPermissions_DoubleClick(object sender, EventArgs e)
        {
            SelectDoubleClickedNode(tv_AccountNotGivenPermissions);
        }

        private void LoadAccountDetails()
        {
            txt_Email.Text = accountModel.GetAccountEmail();
            txt_Joined.Text = accountModel.GetAccountJoinDate();
            txt_LastIP.Text = accountModel.GetAccountIP();
            txt_LastLogin.Text = accountModel.GetAccountLastLogin();
            drpdwn_Expansion.SelectedIndex = Convert.ToInt32(accountModel.GetAccountExpansion());
        }

        private void Init_drpdwn_Expansion()
        {
            drpdwn_Expansion.Items.Add("Classic");
            drpdwn_Expansion.Items.Add("The Burning Crusade");
            drpdwn_Expansion.Items.Add("Wrath of the Lich King");
            drpdwn_Expansion.Items.Add("Cataclysm");
            drpdwn_Expansion.Items.Add("Mists of Pandaria");
        }

        private void btn_SaveEmail_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text != "" && accountModel.AccountIsSet())
                accountModel.SetAccountEmail(txt_Email.Text);
        }

        private void btn_SaveExpansion_Click(object sender, EventArgs e)
        {
            if (accountModel.AccountIsSet())
                accountModel.SetAccountExpansion(Convert.ToByte(drpdwn_Expansion.SelectedIndex));
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            if (txt_Password.Text.Length > 0 && accountModel.AccountIsSet())
            {
                if (MessageBox.Show("Are you sure you want to change the password?", RBACManagerModel.GetApplicationTitle(), MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    accountModel.SetAccountPassword(txt_Password.Text);
                    txt_Password.Text = "";
                }
            }
        }

        private void btn_SearchAccount_Click(object sender, EventArgs e)
        {
            SearchAccount();
        }

        private void SearchAccount()
        {
            if (txt_SearchAccount.Text != searchPlaceholder && txt_SearchAccount.Text != "")
            {
                List<IDAndName> accs = accountModel.GetAccountList(txt_SearchAccount.Text);
                tv_Accounts.Nodes.Clear();
                InitTreeViewWithList(tv_Accounts, accs);
            }
        }

        private void btn_SearchCancel_Click(object sender, EventArgs e)
        {
            txt_SearchAccount.Text = searchPlaceholder;
            txt_SearchAccount.Update();
            LoadAccounts();
        }

        private void txt_SearchAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchAccount();
        }

        private void lbl_SelectGivenPermissionsAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_AccountGivenPermissions.Nodes)
            {
                tn.Checked = true;
            }
        }

        private void lbl_SelectGivenPermissionsNone_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_AccountGivenPermissions.Nodes)
            {
                tn.Checked = false;
            }
        }

        private void lbl_SelectGivenPermissionsInvert_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_AccountGivenPermissions.Nodes)
            {
                tn.Checked = !tn.Checked;
            }
        }

        private void lbl_SelectNotGivenPermissionsAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_AccountNotGivenPermissions.Nodes)
            {
                tn.Checked = true;
            }
        }

        private void lbl_SelectNotGivenPermissionsNone_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_AccountNotGivenPermissions.Nodes)
            {
                tn.Checked = false;
            }
        }

        private void lbl_SelectNotGivenPermissionsInvert_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_AccountNotGivenPermissions.Nodes)
            {
                tn.Checked = !tn.Checked;
            }
        }

        private void lbl_SelectRolesHasAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RolesAccountHas.Nodes)
            {
                tn.Checked = true;
            }
        }

        private void lbl_SelectRolesHasNone_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RolesAccountHas.Nodes)
            {
                tn.Checked = false;
            }
        }

        private void lbl_SelectRolesHasInvert_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RolesAccountHas.Nodes)
            {
                tn.Checked = !tn.Checked;
            }
        }

        private void lbl_SelectRolesHasNotAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RolesAccountHasNot.Nodes)
            {
                tn.Checked = true;
            }
        }

        private void lbl_SelectRolesHasNotNone_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RolesAccountHasNot.Nodes)
            {
                tn.Checked = false;
            }
        }

        private void lbl_SelectRolesHasNotInvert_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RolesAccountHasNot.Nodes)
            {
                tn.Checked = !tn.Checked;
            }
        }

        private void txt_SearchAccount_Enter(object sender, EventArgs e)
        {
            if (txt_SearchAccount.Text == searchPlaceholder)
            {
                txt_SearchAccount.Text = "";
            }
        }

        private void txt_SearchAccount_Leave(object sender, EventArgs e)
        {
            if (txt_SearchAccount.Text == "")
            {
                txt_SearchAccount.Text = searchPlaceholder;
            }
        }
    }
}
