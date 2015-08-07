using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace RBACManager
{
    public partial class SettingsView : Form
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

        RBACManagerModel model;
        
        public SettingsView(RBACManagerModel model)
        {
            this.model = model;
            InitializeComponent();
        }
        
        private void settings_Load(object sender, EventArgs e)
        {
            txt_ip.Text = model.GetDatabaseSettings().Host;
            txt_port.Text = model.GetDatabaseSettings().Port.ToString();
            txt_user.Text = model.GetDatabaseSettings().User;
            txt_pass.Text = model.GetDatabaseSettings().Password;
            txt_authdb.Text = model.GetDatabaseSettings().Database;

            btn_Close.DialogResult = DialogResult.OK;
            btn_Save.DialogResult = DialogResult.OK;
        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            model.GetIniFile().SetKeyValue("mysql", "ip", txt_ip.Text);
            model.GetDatabaseSettings().Host = txt_ip.Text;
            model.GetIniFile().SetKeyValue("mysql", "port", txt_port.Text);
            model.GetDatabaseSettings().Port = Convert.ToUInt16(txt_port.Text);
            model.GetIniFile().SetKeyValue("mysql", "user", txt_user.Text);
            model.GetDatabaseSettings().User = txt_user.Text;
            model.GetIniFile().SetKeyValue("mysql", "pass", txt_pass.Text);
            model.GetDatabaseSettings().Password = txt_pass.Text;
            model.GetIniFile().SetKeyValue("mysql", "authdb", txt_authdb.Text);
            model.GetDatabaseSettings().Database = txt_authdb.Text;

            try
            {
                model.GetIniFile().Save(model.GetSettingsPath());
                MessageBox.Show("Settings saved successfully", RBACManagerModel.GetApplicationTitle());
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save settings on filesystem.", RBACManagerModel.GetApplicationTitle());
            }
        }
        
        private void btn_CheckConnection_Click(object sender, EventArgs e)
        {
            try
            {
                MysqlModel dbSettings = new MysqlModel();
                dbSettings.Host = txt_ip.Text;
                dbSettings.Port = Convert.ToUInt16(txt_port.Text);
                dbSettings.User = txt_user.Text;
                dbSettings.Password = txt_pass.Text;
                dbSettings.Database = txt_authdb.Text;
                
                using (Mysql databaseConnection = new Mysql(dbSettings))
                {
                    if (databaseConnection.OpenConnection())
                    {
                        if (databaseConnection.IsValidDatabase())
                            MessageBox.Show("Database connection successful.", RBACManagerModel.GetApplicationTitle());
                        else
                            MessageBox.Show("Database connection successful but the selected database does not contain alle needed tables with the needed columns. \n\nUpdate the database or change the settings to connect to a valid database.", RBACManagerModel.GetApplicationTitle());

                        databaseConnection.CloseConnection();
                    }
                    else
                        MessageBox.Show("Can not connect to database.", RBACManagerModel.GetApplicationTitle());
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured. Check your settings.", RBACManagerModel.GetApplicationTitle());
            }
    
        }

        
        private void txt_port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
