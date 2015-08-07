using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBACManager
{
    public partial class SecurityLevelsView : Form
    {
        RBACManagerModel model;

        public SecurityLevelsView(RBACManagerModel model)
        {
            this.model = model;
            InitializeComponent();
        }

        private void SecurityLevelsView_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.icon;
        }

        private void InitilizeDataGrid()
        {

        }

        private void ShowSecurityLevels()
        {

        }

        private void button_RemoveSecurityLevel_Click(object sender, EventArgs e)
        {

        }

        private void button_AddSecurityLevel_Click(object sender, EventArgs e)
        {

        }
    }
}
