namespace RBACManager
{
    partial class MainView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.btn_AccountPermissions = new System.Windows.Forms.Button();
			this.btn_RolePermissions = new System.Windows.Forms.Button();
			this.lbl_ConInfo = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_Settings = new System.Windows.Forms.ToolStripButton();
			this.btn_Terms = new System.Windows.Forms.ToolStripButton();
			this.btn_About = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_AccountPermissions
			// 
			this.btn_AccountPermissions.Location = new System.Drawing.Point(27, 32);
			this.btn_AccountPermissions.Name = "btn_AccountPermissions";
			this.btn_AccountPermissions.Size = new System.Drawing.Size(191, 25);
			this.btn_AccountPermissions.TabIndex = 1;
			this.btn_AccountPermissions.Text = "Manage account permissions";
			this.btn_AccountPermissions.UseVisualStyleBackColor = true;
			this.btn_AccountPermissions.Click += new System.EventHandler(this.btn_AccountPermissions_Click);
			// 
			// btn_RolePermissions
			// 
			this.btn_RolePermissions.Location = new System.Drawing.Point(27, 66);
			this.btn_RolePermissions.Name = "btn_RolePermissions";
			this.btn_RolePermissions.Size = new System.Drawing.Size(191, 24);
			this.btn_RolePermissions.TabIndex = 2;
			this.btn_RolePermissions.Text = "Manage roles";
			this.btn_RolePermissions.UseVisualStyleBackColor = true;
			this.btn_RolePermissions.Click += new System.EventHandler(this.btn_RolePermissions_Click);
			// 
			// lbl_ConInfo
			// 
			this.lbl_ConInfo.AutoSize = true;
			this.lbl_ConInfo.Location = new System.Drawing.Point(6, 106);
			this.lbl_ConInfo.Name = "lbl_ConInfo";
			this.lbl_ConInfo.Size = new System.Drawing.Size(12, 13);
			this.lbl_ConInfo.TabIndex = 3;
			this.lbl_ConInfo.Text = "x";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Settings,
            this.btn_Terms,
            this.btn_About,
            this.toolStripSeparator1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(244, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_Settings
			// 
			this.btn_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btn_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Settings.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.btn_Settings.Name = "btn_Settings";
			this.btn_Settings.Size = new System.Drawing.Size(53, 22);
			this.btn_Settings.Text = "Settings";
			this.btn_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
			// 
			// btn_Terms
			// 
			this.btn_Terms.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_Terms.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_Terms.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.btn_Terms.Name = "btn_Terms";
			this.btn_Terms.Size = new System.Drawing.Size(79, 22);
			this.btn_Terms.Text = "Terms of use";
			this.btn_Terms.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_Terms.Click += new System.EventHandler(this.btn_Terms_Click);
			// 
			// btn_About
			// 
			this.btn_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btn_About.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btn_About.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_About.Margin = new System.Windows.Forms.Padding(1, 1, 0, 2);
			this.btn_About.Name = "btn_About";
			this.btn_About.Size = new System.Drawing.Size(44, 22);
			this.btn_About.Text = "About";
			this.btn_About.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.AutoSize = false;
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(0, 25);
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 127);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lbl_ConInfo);
			this.Controls.Add(this.btn_RolePermissions);
			this.Controls.Add(this.btn_AccountPermissions);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(260, 155);
			this.Name = "MainView";
			this.Text = "Scat\'s RBAC Manager";
			this.Load += new System.EventHandler(this.main_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AccountPermissions;
        private System.Windows.Forms.Button btn_RolePermissions;
        private System.Windows.Forms.Label lbl_ConInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Settings;
        private System.Windows.Forms.ToolStripButton btn_Terms;
        private System.Windows.Forms.ToolStripButton btn_About;
		  private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;


    }
}

