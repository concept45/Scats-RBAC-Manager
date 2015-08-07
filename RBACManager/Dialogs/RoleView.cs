using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace RBACManager
{
    public partial class RoleView : Form
    {
        RoleModel roleModel;
        private string searchPlaceholder = "Search for role";

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


        public RoleView(RBACManagerModel model)
        {
            roleModel = new RoleModel(model.GetMysqlConnection());
            InitializeComponent();
        }

        private void Roles_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
            lbl_Role.Text = "";
            txt_RoleName.Hide();
            btn_SaveNewRoleName.Hide();
            button_CancelChangeName.Hide();
            InitTooltip();
            LoadRoles();
        }

        private void InitTooltip()
        {
            toolTip1.SetToolTip(btn_RoleAddPermissions, "Add permission to role");
            toolTip1.SetToolTip(btn_RoleRemovePermission, "Remove permission from role");
            toolTip1.SetToolTip(btn_SearchRole, "Search for role");
            toolTip1.SetToolTip(btn_SearchCancel, "Cancel search");
            toolTip1.SetToolTip(btn_CreateRole, "Create role");
            toolTip1.SetToolTip(btn_EditRole, "Edit role");
            toolTip1.SetToolTip(btn_DeleteRole, "Delete role");
            toolTip1.SetToolTip(button_ChangeName, "Edit role name");
            toolTip1.SetToolTip(button_CancelChangeName, "Cancel");
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

        private void LoadRoles(bool reloadFromDB = false)
        {
            tv_Roles.Nodes.Clear();
            List<IDAndName> roleList = new List<IDAndName>();
            roleList = roleModel.GetRoleList(reloadFromDB);

            InitTreeViewWithList(tv_Roles, roleList);
        }

        private void LoadRoleGivenPermissions()
        {
            tv_RoleGivenPermissions.Nodes.Clear();
            InitTreeViewWithList(tv_RoleGivenPermissions, roleModel.GetPermissionsRoleHas());
        }

        private void LoadRoleNotGivenPermissions()
        {
            tv_RoleNotGivenPermissions.Nodes.Clear();
            InitTreeViewWithList(tv_RoleNotGivenPermissions, roleModel.GetPermissionsRoleHasNot());
        }

        private void btn_CreateRole_Click(object sender, EventArgs e)
        {
            Form createLinkedPermission = new CreateRoleDialog(roleModel.roleFunctions);
            if (createLinkedPermission.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadRoles(true);
            }
        }

        private void btn_EditRole_Click(object sender, EventArgs e)
        {
            EditRole();
        }

        private void EditRole()
        {
            if (tv_Roles.Nodes.Count >= 1)
            {
                roleModel.LoadRole(Convert.ToInt32(tv_Roles.SelectedNode.Name), tv_Roles.SelectedNode.Text);
                lbl_Role.Text = tv_Roles.SelectedNode.Text;
                LoadRoleGivenPermissions();
                LoadRoleNotGivenPermissions();
            }
        }

        private void btn_DeleteRole_Click(object sender, EventArgs e)
        {
            if (tv_Roles.Nodes.Count >= 1)
            {
                if (MessageBox.Show("Are you sure you want to delete the role \"" + tv_Roles.SelectedNode.Text + "\"?", RBACManagerModel.GetApplicationTitle(), MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DeleteRole();
                }
            }
        }

        private void DeleteRole()
        {
            if (Convert.ToInt32(tv_Roles.SelectedNode.Name) == roleModel.GetCurrentRoleID())
            {
                tv_RoleGivenPermissions.Nodes.Clear();
                tv_RoleNotGivenPermissions.Nodes.Clear();
                roleModel.UnsetRole();
                lbl_Role.Text = "";
            }

            if (roleModel.DeleteRole(Convert.ToInt32(tv_Roles.SelectedNode.Name)))
            {
                MessageBox.Show("Role deleted.", RBACManagerModel.GetApplicationTitle());
                LoadRoles();
            }
        }

        private void btn_RoleAddPermissions_Click(object sender, EventArgs e)
        {
            if (roleModel.RoleIsSet() && tv_RoleNotGivenPermissions.Nodes.Count >= 1)
            {
                foreach (TreeNode node in tv_RoleNotGivenPermissions.Nodes)
                {
                    if (node.Checked == true)
                        roleModel.AddPermissionToRole(Convert.ToInt32(node.Name));
                }

                LoadRoleGivenPermissions();
                LoadRoleNotGivenPermissions();
            }
        }

        private void btn_RoleRemovePermission_Click(object sender, EventArgs e)
        {
            if (roleModel.RoleIsSet() && tv_RoleGivenPermissions.Nodes.Count >= 2)
            {
                foreach (TreeNode node in tv_RoleGivenPermissions.Nodes)
                {
                    if(node.Checked == true)
                        roleModel.RemovePermissionFromRole(Convert.ToInt32(node.Name));
                }

                LoadRoleGivenPermissions();
                LoadRoleNotGivenPermissions();
            }
            else if (roleModel.RoleIsSet() && tv_RoleGivenPermissions.Nodes.Count == 1)
            {
                if (MessageBox.Show("By removing this permission you will delete the role.\r\n\r\n Are you sure you want to delete the role?", RBACManagerModel.GetApplicationTitle(), MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    DeleteRole();
            }
        }

        private void tv_Roles_NodeMouseDoubleClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            EditRole();
        }

        private void tv_RoleGivenPermissions_DoubleClick(object sender, EventArgs e)
        {
            SelectDoubleClickedNode(tv_RoleGivenPermissions);
        }

        private void tv_RoleNotGivenPermissions_DoubleClick(object sender, EventArgs e)
        {
            SelectDoubleClickedNode(tv_RoleNotGivenPermissions);
        }

        private void SelectDoubleClickedNode(TreeView tv)
        {
            if (tv.Nodes.Count >= 1)
                tv.SelectedNode.Checked = !tv.SelectedNode.Checked;
        }

        private void btn_SearchRole_Click(object sender, EventArgs e)
        {
            SearchRole();
        }

        private void SearchRole()
        {
            if (txt_SearchRole.Text != searchPlaceholder || txt_SearchRole.Text != "")
            {
                List<IDAndName> accs = roleModel.GetRoleList(txt_SearchRole.Text);
                tv_Roles.Nodes.Clear();
                InitTreeViewWithList(tv_Roles, accs);
            }
        }

        private void btn_SearchCancel_Click(object sender, EventArgs e)
        {
            txt_SearchRole.Text = searchPlaceholder;
            txt_SearchRole.Update();
            LoadRoles();
        }

        private void lbl_Role_DoubleClick(object sender, EventArgs e)
        {
            StartChangeRolename();
        }

        private void btn_SaveRoleName_Click(object sender, EventArgs e)
        {
            if (txt_RoleName.Text != lbl_Role.Text)
            {
                lbl_Role.Text = txt_RoleName.Text;
                roleModel.SetRoleName(txt_RoleName.Text);
                lbl_Role.Show();
                txt_RoleName.Hide();
                btn_SaveNewRoleName.Hide();
                button_CancelChangeName.Hide();
                button_ChangeName.Show();
                txt_RoleName.Clear();
                LoadRoles(true);
            }
            else 
            {
                CancelChangeRoleName();
            }
        }

        private void txt_SearchRole_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchRole();
        }

        private void lbl_SelectGivenPermissionsAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RoleGivenPermissions.Nodes)
            {
                tn.Checked = true;
            }
        }

        private void lbl_SelectGivenPermissionsNone_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RoleGivenPermissions.Nodes)
            {
                tn.Checked = false;
            }
        }

        private void lbl_SelectGivenPermissionsInvert_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RoleGivenPermissions.Nodes)
            {
                tn.Checked = !tn.Checked;
            }
        }

        private void lbl_SelectNotGivenPermissionsAll_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RoleNotGivenPermissions.Nodes)
            {
                tn.Checked = true;
            }
        }

        private void lbl_SelectNotGivenPermissionsNone_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RoleNotGivenPermissions.Nodes)
            {
                tn.Checked = false;
            }
        }

        private void lbl_SelectNotGivenPermissionsInvert_Click(object sender, EventArgs e)
        {
            foreach (TreeNode tn in tv_RoleNotGivenPermissions.Nodes)
            {
                tn.Checked = !tn.Checked;
            }
        }

        private void StartChangeRolename()
        {
            if (lbl_Role.Text != "")
            {
                lbl_Role.Hide();
                button_ChangeName.Hide();
                txt_RoleName.Show();
                btn_SaveNewRoleName.Show();
                button_CancelChangeName.Show();
                txt_RoleName.Text = lbl_Role.Text;
            }
        }

        private void CancelChangeRoleName()
        {
            lbl_Role.Show();
            txt_RoleName.Hide();
            btn_SaveNewRoleName.Hide();
            button_CancelChangeName.Hide();
            txt_RoleName.Clear();
        }

        private void button_CancelChangeName_Click(object sender, EventArgs e)
        {
            CancelChangeRoleName();
        }

        private void button_EditName_Click(object sender, EventArgs e)
        {
            StartChangeRolename();
        }

        private void txt_SearchRole_Leave(object sender, EventArgs e)
        {
            if (txt_SearchRole.Text == "")
            {
                txt_SearchRole.Text = searchPlaceholder;
            }
        }

        private void txt_SearchRole_Enter(object sender, EventArgs e)
        {
            if (txt_SearchRole.Text == searchPlaceholder)
            {
                txt_SearchRole.Text = "";
            }
        }
    }
}
