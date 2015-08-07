using System;
using System.Windows.Forms;

namespace RBACManager
{
    public partial class CreateAccountDialog : Form
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

        AccountDBFunctions accountFunctions;

        public CreateAccountDialog(AccountDBFunctions accountDBFunctions)
        {
            accountFunctions = accountDBFunctions;
            InitializeComponent();
        }


        private void create_acc_Load(object sender, EventArgs e)
        {
            Init_drpdwn_Expansion();
            btn_CreateAccount.DialogResult = DialogResult.OK;
        }


        private void Init_drpdwn_Expansion()
        {
            drpdwn_Expansion.Items.Add("Classic");
            drpdwn_Expansion.Items.Add("The Burning Crusade");
            drpdwn_Expansion.Items.Add("Wrath of the Lich King");
            drpdwn_Expansion.Items.Add("Cataclysm");
            drpdwn_Expansion.SelectedIndex = 2;
        }


        private int GetExpansionIDForSelection()
        {
            return drpdwn_Expansion.SelectedIndex;
        }


        private bool Validate_txt_Username(AccountDBFunctions con)
        {
            if (txt_Username.Text.Trim() == "")
            {
                MessageBox.Show("Username must not be empty!", RBACManagerModel.GetApplicationTitle());
                return false;
            }

            if (con.UsernameExists(txt_Username.Text.Trim()))
            {
                MessageBox.Show("A user with the name already exists!", RBACManagerModel.GetApplicationTitle());
                return false;
            }

            return true;
        }


        private bool Validate_txt_Password()
        {
            if (txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("Password must not be empty!", RBACManagerModel.GetApplicationTitle());
                return false;
            }

            return true;
        }


        private void btn_CreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount();
        }

        private void CreateAccount()
        {

            if (Validate_txt_Username(accountFunctions) && Validate_txt_Password())
            {
                if (accountFunctions.CreateAccount(txt_Username.Text.Trim(), txt_Password.Text.Trim(), GetExpansionIDForSelection()))
                {
                    MessageBox.Show("Account created.", RBACManagerModel.GetApplicationTitle());
                    Close();
                }
                else
                {
                    MessageBox.Show("Account creation failed.", RBACManagerModel.GetApplicationTitle());
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txt_Password.Focus();
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                drpdwn_Expansion.Focus();
        }

        private void drpdwn_Expansion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CreateAccount();
        }

    }
}
