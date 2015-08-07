using System;
using System.Windows.Forms;


namespace RBACManager
{
    public partial class MainView : Form
    {
        private RBACManagerModel model;

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

        public MainView()
        {
            model = new RBACManagerModel(Application.StartupPath + @"\settings.ini");
            InitializeComponent();
            this.Text = RBACManagerModel.GetApplicationTitle();
        }
        
        private void CheckForSettingsFile()
        {
            if (!System.IO.File.Exists(model.GetSettingsPath()) || new System.IO.FileInfo(model.GetSettingsPath()).Length == 0)
            {
                System.IO.File.WriteAllText(model.GetSettingsPath(), "[mysql]\r\nport=3306\r\nip=localhost\r\nuser=root\r\npass=root\r\nauthdb=auth");
            }
        }
        
        private void main_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
            CheckForSettingsFile();
            UpdateConnectionInfoLabel();
            UpdateConnectionState();
        }
        
        public void UpdateConnectionInfoLabel()
        {
            if (model.GetDatabaseSettings().Host.Trim() == "")
                lbl_ConInfo.Text = "No connection data available.";
            else
                lbl_ConInfo.Text = model.GetDatabaseSettings().User + "@" + model.GetDatabaseSettings().Host + ":" + model.GetDatabaseSettings().Port;
        }
        
        private void btn_AccountPermissions_Click(object sender, EventArgs e)
        {
            Form account = new AccountView(model);
            account.ShowDialog();
        }
        
        private void btn_RolePermissions_Click(object sender, EventArgs e)
        {
            Form linkedPermissions = new RoleView(model);
            linkedPermissions.ShowDialog();
        }

        private void UpdateConnectionState()
        {
            model.GetMysqlConnection().UpdateConnection(model.GetDatabaseSettings());
            bool con = model.GetMysqlConnection().OpenConnection();
            bool valid = false;
            if (con)
                valid = model.GetMysqlConnection().IsValidDatabase();
            model.GetMysqlConnection().CloseConnection();
            btn_AccountPermissions.Enabled = con && valid;
            btn_RolePermissions.Enabled = con && valid;

            if (!con)
            {
                MessageBox.Show("Change the settings to connect to a database.", RBACManagerModel.GetApplicationTitle());
            }
            else 
            {
                if (!valid)
                {
                    MessageBox.Show("The selected database does not contain alle needed tables with the needed columns. \n\nUpdate the database or change the settings to connect to a valid database.", RBACManagerModel.GetApplicationTitle());
                }
            }
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsView(model);
            if (settings.ShowDialog() == DialogResult.OK)
            {
                UpdateConnectionInfoLabel();
                UpdateConnectionState();
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            Form about = new AboutDialog();
            about.ShowDialog();
        }

        private void btn_Terms_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use at your own risk!", RBACManagerModel.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_ManageSecurityLevels_Click(object sender, EventArgs e)
        {
            Form securityLevels = new SecurityLevelsView(model);
            securityLevels.ShowDialog();
        }
    }
}
