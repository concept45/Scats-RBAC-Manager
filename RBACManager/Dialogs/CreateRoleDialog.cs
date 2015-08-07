using System;
using System.Windows.Forms;

namespace RBACManager
{
    public partial class CreateRoleDialog : Form
    {
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

        RoleDBFunctions roleFunctions;

        public CreateRoleDialog(RoleDBFunctions roleDBFunctions)
        {
            roleFunctions = roleDBFunctions;
            InitializeComponent();
            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_CreateRole.DialogResult = DialogResult.OK;
        }


        private void btn_CreateRole_Click(object sender, EventArgs e)
        {
            CreateRole();
        }

        private void CreateRole()
        {
            if (Validate_txt_Rolename())
            {
                if (roleFunctions.CreateRole(txt_Rolename.Text.Trim()))
                {
                    MessageBox.Show("Role created.", RBACManagerModel.GetApplicationTitle());
                    Close();
                }
                else
                {
                    MessageBox.Show("Can not create role.", RBACManagerModel.GetApplicationTitle());
                }
            }
        }


        private bool Validate_txt_Rolename()
        {
            if (txt_Rolename.Text.Trim() == "")
            {
                MessageBox.Show("Name must not be empty!", RBACManagerModel.GetApplicationTitle());
                return false;
            }

            if (roleFunctions.RoleExists(txt_Rolename.Text.Trim()))
            {
                MessageBox.Show("A role with this name already exists!", RBACManagerModel.GetApplicationTitle());
                return false;
            }

            return true;
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }       
    }
}
