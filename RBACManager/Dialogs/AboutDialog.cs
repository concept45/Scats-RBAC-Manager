using System;
using System.Windows.Forms;

namespace RBACManager
{
    public partial class AboutDialog : Form
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


        public AboutDialog()
        {
            InitializeComponent();
        }


        private void btn_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void link_Facebook_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/scat25");
        }

        private void f_About_Load(object sender, EventArgs e)
        {
            Label version = new Label();
            version.AutoSize = true;
            version.Location = new System.Drawing.Point((int)(this.Width / 2 - version.Width / 2), 52);
            System.Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
				bool rc = false;
				var attributes = System.Reflection.Assembly.GetEntryAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyTitleAttribute), false);
				if (attributes.Length > 0)
				{
					var titleAttribute = (System.Reflection.AssemblyTitleAttribute)attributes[0];
					if (titleAttribute.Title.Length > 0)
						rc = titleAttribute.Title.EndsWith("RC");
						
				}
            version.Text = string.Format("Version {0}.{1}.{2}{3}", v.Major, v.Minor, v.Build, (rc ? " RC" : ""));
            this.Controls.Add(version);
        }
    }
}
