namespace RBACManager
{
    partial class SecurityLevelsView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_AddSecurityLevel = new System.Windows.Forms.Button();
            this.button_RemoveSecurityLevel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGrid_SecurityLevels = new System.Windows.Forms.DataGridView();
            this.Column_Securitylevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Role = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_SecurityLevels)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddSecurityLevel
            // 
            this.button_AddSecurityLevel.Image = global::RBACManager.Properties.Resources.add_;
            this.button_AddSecurityLevel.Location = new System.Drawing.Point(13, 208);
            this.button_AddSecurityLevel.Name = "button_AddSecurityLevel";
            this.button_AddSecurityLevel.Size = new System.Drawing.Size(42, 42);
            this.button_AddSecurityLevel.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button_AddSecurityLevel, "Add Security Level");
            this.button_AddSecurityLevel.UseVisualStyleBackColor = true;
            this.button_AddSecurityLevel.Click += new System.EventHandler(this.button_AddSecurityLevel_Click);
            // 
            // button_RemoveSecurityLevel
            // 
            this.button_RemoveSecurityLevel.Image = global::RBACManager.Properties.Resources.remove;
            this.button_RemoveSecurityLevel.Location = new System.Drawing.Point(61, 208);
            this.button_RemoveSecurityLevel.Name = "button_RemoveSecurityLevel";
            this.button_RemoveSecurityLevel.Size = new System.Drawing.Size(42, 42);
            this.button_RemoveSecurityLevel.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button_RemoveSecurityLevel, "Remove Security level");
            this.button_RemoveSecurityLevel.UseVisualStyleBackColor = true;
            this.button_RemoveSecurityLevel.Click += new System.EventHandler(this.button_RemoveSecurityLevel_Click);
            // 
            // dataGrid_SecurityLevels
            // 
            this.dataGrid_SecurityLevels.AllowUserToAddRows = false;
            this.dataGrid_SecurityLevels.AllowUserToDeleteRows = false;
            this.dataGrid_SecurityLevels.AllowUserToResizeColumns = false;
            this.dataGrid_SecurityLevels.AllowUserToResizeRows = false;
            this.dataGrid_SecurityLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_SecurityLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Securitylevel,
            this.Column_Role});
            this.dataGrid_SecurityLevels.Location = new System.Drawing.Point(13, 13);
            this.dataGrid_SecurityLevels.MultiSelect = false;
            this.dataGrid_SecurityLevels.Name = "dataGrid_SecurityLevels";
            this.dataGrid_SecurityLevels.RowHeadersVisible = false;
            this.dataGrid_SecurityLevels.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid_SecurityLevels.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_SecurityLevels.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_SecurityLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_SecurityLevels.ShowCellErrors = false;
            this.dataGrid_SecurityLevels.ShowCellToolTips = false;
            this.dataGrid_SecurityLevels.ShowEditingIcon = false;
            this.dataGrid_SecurityLevels.ShowRowErrors = false;
            this.dataGrid_SecurityLevels.Size = new System.Drawing.Size(327, 189);
            this.dataGrid_SecurityLevels.TabIndex = 3;
            // 
            // Column_Securitylevel
            // 
            this.Column_Securitylevel.HeaderText = "Security level";
            this.Column_Securitylevel.Name = "Column_Securitylevel";
            this.Column_Securitylevel.ReadOnly = true;
            // 
            // Column_Role
            // 
            this.Column_Role.HeaderText = "Role";
            this.Column_Role.Name = "Column_Role";
            this.Column_Role.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column_Role.Width = 200;
            // 
            // SecurityLevelsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.dataGrid_SecurityLevels);
            this.Controls.Add(this.button_RemoveSecurityLevel);
            this.Controls.Add(this.button_AddSecurityLevel);
            this.Name = "SecurityLevelsView";
            this.Text = "Security Level";
            this.Load += new System.EventHandler(this.SecurityLevelsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_SecurityLevels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AddSecurityLevel;
        private System.Windows.Forms.Button button_RemoveSecurityLevel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGrid_SecurityLevels;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Securitylevel;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column_Role;
    }
}