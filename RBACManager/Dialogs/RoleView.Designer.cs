namespace RBACManager
{
    partial class RoleView
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
			this.tv_Roles = new System.Windows.Forms.TreeView();
			this.tv_RoleGivenPermissions = new System.Windows.Forms.TreeView();
			this.tv_RoleNotGivenPermissions = new System.Windows.Forms.TreeView();
			this.btn_DeleteRole = new System.Windows.Forms.Button();
			this.btn_CreateRole = new System.Windows.Forms.Button();
			this.btn_EditRole = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_RoleAddPermissions = new System.Windows.Forms.Button();
			this.btn_RoleRemovePermission = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lbl_Role = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_RoleName = new System.Windows.Forms.TextBox();
			this.btn_SaveNewRoleName = new System.Windows.Forms.Button();
			this.btn_SearchCancel = new System.Windows.Forms.Button();
			this.btn_SearchRole = new System.Windows.Forms.Button();
			this.txt_SearchRole = new System.Windows.Forms.TextBox();
			this.lbl_SelectGivenPermissionsInvert = new System.Windows.Forms.Label();
			this.lbl_SelectGivenPermissionsNone = new System.Windows.Forms.Label();
			this.lbl_SelectGivenPermissionsAll = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lbl_SelectNotGivenPermissionsInvert = new System.Windows.Forms.Label();
			this.lbl_SelectNotGivenPermissionsNone = new System.Windows.Forms.Label();
			this.lbl_SelectNotGivenPermissionsAll = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button_CancelChangeName = new System.Windows.Forms.Button();
			this.button_ChangeName = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tv_Roles
			// 
			this.tv_Roles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tv_Roles.FullRowSelect = true;
			this.tv_Roles.HideSelection = false;
			this.tv_Roles.Location = new System.Drawing.Point(12, 39);
			this.tv_Roles.Name = "tv_Roles";
			this.tv_Roles.ShowLines = false;
			this.tv_Roles.ShowPlusMinus = false;
			this.tv_Roles.ShowRootLines = false;
			this.tv_Roles.Size = new System.Drawing.Size(207, 458);
			this.tv_Roles.TabIndex = 1;
			this.tv_Roles.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Roles_NodeMouseDoubleClick);
			// 
			// tv_RoleGivenPermissions
			// 
			this.tv_RoleGivenPermissions.CheckBoxes = true;
			this.tv_RoleGivenPermissions.HideSelection = false;
			this.tv_RoleGivenPermissions.ItemHeight = 18;
			this.tv_RoleGivenPermissions.Location = new System.Drawing.Point(228, 54);
			this.tv_RoleGivenPermissions.Name = "tv_RoleGivenPermissions";
			this.tv_RoleGivenPermissions.ShowLines = false;
			this.tv_RoleGivenPermissions.ShowPlusMinus = false;
			this.tv_RoleGivenPermissions.ShowRootLines = false;
			this.tv_RoleGivenPermissions.Size = new System.Drawing.Size(544, 218);
			this.tv_RoleGivenPermissions.TabIndex = 5;
			this.tv_RoleGivenPermissions.DoubleClick += new System.EventHandler(this.tv_RoleGivenPermissions_DoubleClick);
			// 
			// tv_RoleNotGivenPermissions
			// 
			this.tv_RoleNotGivenPermissions.CheckBoxes = true;
			this.tv_RoleNotGivenPermissions.HideSelection = false;
			this.tv_RoleNotGivenPermissions.ItemHeight = 18;
			this.tv_RoleNotGivenPermissions.Location = new System.Drawing.Point(228, 336);
			this.tv_RoleNotGivenPermissions.Name = "tv_RoleNotGivenPermissions";
			this.tv_RoleNotGivenPermissions.ShowLines = false;
			this.tv_RoleNotGivenPermissions.ShowPlusMinus = false;
			this.tv_RoleNotGivenPermissions.ShowRootLines = false;
			this.tv_RoleNotGivenPermissions.Size = new System.Drawing.Size(544, 218);
			this.tv_RoleNotGivenPermissions.TabIndex = 8;
			this.tv_RoleNotGivenPermissions.DoubleClick += new System.EventHandler(this.tv_RoleNotGivenPermissions_DoubleClick);
			// 
			// btn_DeleteRole
			// 
			this.btn_DeleteRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_DeleteRole.Image = global::RBACManager.Properties.Resources.remove;
			this.btn_DeleteRole.Location = new System.Drawing.Point(88, 508);
			this.btn_DeleteRole.Margin = new System.Windows.Forms.Padding(28, 3, 28, 3);
			this.btn_DeleteRole.Name = "btn_DeleteRole";
			this.btn_DeleteRole.Size = new System.Drawing.Size(42, 42);
			this.btn_DeleteRole.TabIndex = 3;
			this.btn_DeleteRole.UseVisualStyleBackColor = true;
			this.btn_DeleteRole.Click += new System.EventHandler(this.btn_DeleteRole_Click);
			// 
			// btn_CreateRole
			// 
			this.btn_CreateRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_CreateRole.Image = global::RBACManager.Properties.Resources.add_;
			this.btn_CreateRole.Location = new System.Drawing.Point(140, 508);
			this.btn_CreateRole.Margin = new System.Windows.Forms.Padding(28, 3, 28, 3);
			this.btn_CreateRole.Name = "btn_CreateRole";
			this.btn_CreateRole.Size = new System.Drawing.Size(42, 42);
			this.btn_CreateRole.TabIndex = 4;
			this.btn_CreateRole.UseVisualStyleBackColor = true;
			this.btn_CreateRole.Click += new System.EventHandler(this.btn_CreateRole_Click);
			// 
			// btn_EditRole
			// 
			this.btn_EditRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_EditRole.Image = global::RBACManager.Properties.Resources.edit;
			this.btn_EditRole.Location = new System.Drawing.Point(37, 508);
			this.btn_EditRole.Margin = new System.Windows.Forms.Padding(28, 3, 28, 3);
			this.btn_EditRole.Name = "btn_EditRole";
			this.btn_EditRole.Size = new System.Drawing.Size(42, 42);
			this.btn_EditRole.TabIndex = 2;
			this.btn_EditRole.UseVisualStyleBackColor = true;
			this.btn_EditRole.Click += new System.EventHandler(this.btn_EditRole_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(225, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Granted Permissions";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(225, 319);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Permissions";
			// 
			// btn_RoleAddPermissions
			// 
			this.btn_RoleAddPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RoleAddPermissions.Location = new System.Drawing.Point(228, 7);
			this.btn_RoleAddPermissions.Name = "btn_RoleAddPermissions";
			this.btn_RoleAddPermissions.Size = new System.Drawing.Size(41, 31);
			this.btn_RoleAddPermissions.TabIndex = 6;
			this.btn_RoleAddPermissions.Text = "∧";
			this.btn_RoleAddPermissions.UseVisualStyleBackColor = true;
			this.btn_RoleAddPermissions.Click += new System.EventHandler(this.btn_RoleAddPermissions_Click);
			// 
			// btn_RoleRemovePermission
			// 
			this.btn_RoleRemovePermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RoleRemovePermission.Location = new System.Drawing.Point(275, 7);
			this.btn_RoleRemovePermission.Name = "btn_RoleRemovePermission";
			this.btn_RoleRemovePermission.Size = new System.Drawing.Size(41, 31);
			this.btn_RoleRemovePermission.TabIndex = 7;
			this.btn_RoleRemovePermission.Text = "∨";
			this.btn_RoleRemovePermission.UseVisualStyleBackColor = true;
			this.btn_RoleRemovePermission.Click += new System.EventHandler(this.btn_RoleRemovePermission_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(225, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Role:";
			// 
			// lbl_Role
			// 
			this.lbl_Role.AutoSize = true;
			this.lbl_Role.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_Role.Location = new System.Drawing.Point(264, 13);
			this.lbl_Role.Name = "lbl_Role";
			this.lbl_Role.Size = new System.Drawing.Size(45, 13);
			this.lbl_Role.TabIndex = 12;
			this.lbl_Role.Text = "lbl_Role";
			this.toolTip1.SetToolTip(this.lbl_Role, "Double lcick to change role name");
			this.lbl_Role.DoubleClick += new System.EventHandler(this.lbl_Role_DoubleClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.btn_RoleAddPermissions);
			this.panel1.Controls.Add(this.btn_RoleRemovePermission);
			this.panel1.Location = new System.Drawing.Point(228, 272);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 44);
			this.panel1.TabIndex = 13;
			// 
			// txt_RoleName
			// 
			this.txt_RoleName.Location = new System.Drawing.Point(263, 9);
			this.txt_RoleName.Name = "txt_RoleName";
			this.txt_RoleName.Size = new System.Drawing.Size(412, 20);
			this.txt_RoleName.TabIndex = 14;
			// 
			// btn_SaveNewRoleName
			// 
			this.btn_SaveNewRoleName.Location = new System.Drawing.Point(681, 7);
			this.btn_SaveNewRoleName.Name = "btn_SaveNewRoleName";
			this.btn_SaveNewRoleName.Size = new System.Drawing.Size(61, 23);
			this.btn_SaveNewRoleName.TabIndex = 15;
			this.btn_SaveNewRoleName.Text = "Save";
			this.btn_SaveNewRoleName.UseVisualStyleBackColor = true;
			this.btn_SaveNewRoleName.Click += new System.EventHandler(this.btn_SaveRoleName_Click);
			// 
			// btn_SearchCancel
			// 
			this.btn_SearchCancel.Image = global::RBACManager.Properties.Resources.cancel;
			this.btn_SearchCancel.Location = new System.Drawing.Point(195, 9);
			this.btn_SearchCancel.Name = "btn_SearchCancel";
			this.btn_SearchCancel.Size = new System.Drawing.Size(24, 24);
			this.btn_SearchCancel.TabIndex = 21;
			this.btn_SearchCancel.UseVisualStyleBackColor = true;
			this.btn_SearchCancel.Click += new System.EventHandler(this.btn_SearchCancel_Click);
			// 
			// btn_SearchRole
			// 
			this.btn_SearchRole.Image = global::RBACManager.Properties.Resources.search;
			this.btn_SearchRole.Location = new System.Drawing.Point(171, 9);
			this.btn_SearchRole.Name = "btn_SearchRole";
			this.btn_SearchRole.Size = new System.Drawing.Size(24, 24);
			this.btn_SearchRole.TabIndex = 20;
			this.btn_SearchRole.UseVisualStyleBackColor = true;
			this.btn_SearchRole.Click += new System.EventHandler(this.btn_SearchRole_Click);
			// 
			// txt_SearchRole
			// 
			this.txt_SearchRole.Location = new System.Drawing.Point(12, 12);
			this.txt_SearchRole.Name = "txt_SearchRole";
			this.txt_SearchRole.Size = new System.Drawing.Size(161, 20);
			this.txt_SearchRole.TabIndex = 19;
			this.txt_SearchRole.Text = "Search for role";
			this.txt_SearchRole.Enter += new System.EventHandler(this.txt_SearchRole_Enter);
			this.txt_SearchRole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SearchRole_KeyDown);
			this.txt_SearchRole.Leave += new System.EventHandler(this.txt_SearchRole_Leave);
			// 
			// lbl_SelectGivenPermissionsInvert
			// 
			this.lbl_SelectGivenPermissionsInvert.AutoSize = true;
			this.lbl_SelectGivenPermissionsInvert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectGivenPermissionsInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectGivenPermissionsInvert.Location = new System.Drawing.Point(445, 35);
			this.lbl_SelectGivenPermissionsInvert.Name = "lbl_SelectGivenPermissionsInvert";
			this.lbl_SelectGivenPermissionsInvert.Size = new System.Drawing.Size(40, 13);
			this.lbl_SelectGivenPermissionsInvert.TabIndex = 25;
			this.lbl_SelectGivenPermissionsInvert.Text = "Invert";
			this.lbl_SelectGivenPermissionsInvert.Click += new System.EventHandler(this.lbl_SelectGivenPermissionsInvert_Click);
			// 
			// lbl_SelectGivenPermissionsNone
			// 
			this.lbl_SelectGivenPermissionsNone.AutoSize = true;
			this.lbl_SelectGivenPermissionsNone.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectGivenPermissionsNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectGivenPermissionsNone.Location = new System.Drawing.Point(402, 35);
			this.lbl_SelectGivenPermissionsNone.Name = "lbl_SelectGivenPermissionsNone";
			this.lbl_SelectGivenPermissionsNone.Size = new System.Drawing.Size(37, 13);
			this.lbl_SelectGivenPermissionsNone.TabIndex = 24;
			this.lbl_SelectGivenPermissionsNone.Text = "None";
			this.lbl_SelectGivenPermissionsNone.Click += new System.EventHandler(this.lbl_SelectGivenPermissionsNone_Click);
			// 
			// lbl_SelectGivenPermissionsAll
			// 
			this.lbl_SelectGivenPermissionsAll.AutoSize = true;
			this.lbl_SelectGivenPermissionsAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectGivenPermissionsAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectGivenPermissionsAll.Location = new System.Drawing.Point(377, 35);
			this.lbl_SelectGivenPermissionsAll.Name = "lbl_SelectGivenPermissionsAll";
			this.lbl_SelectGivenPermissionsAll.Size = new System.Drawing.Size(21, 13);
			this.lbl_SelectGivenPermissionsAll.TabIndex = 23;
			this.lbl_SelectGivenPermissionsAll.Text = "All";
			this.lbl_SelectGivenPermissionsAll.Click += new System.EventHandler(this.lbl_SelectGivenPermissionsAll_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(331, 35);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Select:";
			// 
			// lbl_SelectNotGivenPermissionsInvert
			// 
			this.lbl_SelectNotGivenPermissionsInvert.AutoSize = true;
			this.lbl_SelectNotGivenPermissionsInvert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectNotGivenPermissionsInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectNotGivenPermissionsInvert.Location = new System.Drawing.Point(445, 319);
			this.lbl_SelectNotGivenPermissionsInvert.Name = "lbl_SelectNotGivenPermissionsInvert";
			this.lbl_SelectNotGivenPermissionsInvert.Size = new System.Drawing.Size(40, 13);
			this.lbl_SelectNotGivenPermissionsInvert.TabIndex = 29;
			this.lbl_SelectNotGivenPermissionsInvert.Text = "Invert";
			this.lbl_SelectNotGivenPermissionsInvert.Click += new System.EventHandler(this.lbl_SelectNotGivenPermissionsInvert_Click);
			// 
			// lbl_SelectNotGivenPermissionsNone
			// 
			this.lbl_SelectNotGivenPermissionsNone.AutoSize = true;
			this.lbl_SelectNotGivenPermissionsNone.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectNotGivenPermissionsNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectNotGivenPermissionsNone.Location = new System.Drawing.Point(402, 319);
			this.lbl_SelectNotGivenPermissionsNone.Name = "lbl_SelectNotGivenPermissionsNone";
			this.lbl_SelectNotGivenPermissionsNone.Size = new System.Drawing.Size(37, 13);
			this.lbl_SelectNotGivenPermissionsNone.TabIndex = 28;
			this.lbl_SelectNotGivenPermissionsNone.Text = "None";
			this.lbl_SelectNotGivenPermissionsNone.Click += new System.EventHandler(this.lbl_SelectNotGivenPermissionsNone_Click);
			// 
			// lbl_SelectNotGivenPermissionsAll
			// 
			this.lbl_SelectNotGivenPermissionsAll.AutoSize = true;
			this.lbl_SelectNotGivenPermissionsAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectNotGivenPermissionsAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectNotGivenPermissionsAll.Location = new System.Drawing.Point(377, 319);
			this.lbl_SelectNotGivenPermissionsAll.Name = "lbl_SelectNotGivenPermissionsAll";
			this.lbl_SelectNotGivenPermissionsAll.Size = new System.Drawing.Size(21, 13);
			this.lbl_SelectNotGivenPermissionsAll.TabIndex = 27;
			this.lbl_SelectNotGivenPermissionsAll.Text = "All";
			this.lbl_SelectNotGivenPermissionsAll.Click += new System.EventHandler(this.lbl_SelectNotGivenPermissionsAll_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(331, 319);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 26;
			this.label7.Text = "Select:";
			// 
			// button_CancelChangeName
			// 
			this.button_CancelChangeName.Image = global::RBACManager.Properties.Resources.cancel;
			this.button_CancelChangeName.Location = new System.Drawing.Point(748, 7);
			this.button_CancelChangeName.Name = "button_CancelChangeName";
			this.button_CancelChangeName.Size = new System.Drawing.Size(24, 24);
			this.button_CancelChangeName.TabIndex = 21;
			this.button_CancelChangeName.UseVisualStyleBackColor = true;
			this.button_CancelChangeName.Click += new System.EventHandler(this.button_CancelChangeName_Click);
			// 
			// button_ChangeName
			// 
			this.button_ChangeName.Image = global::RBACManager.Properties.Resources.edit_small;
			this.button_ChangeName.Location = new System.Drawing.Point(748, 8);
			this.button_ChangeName.Name = "button_ChangeName";
			this.button_ChangeName.Size = new System.Drawing.Size(24, 24);
			this.button_ChangeName.TabIndex = 30;
			this.button_ChangeName.UseVisualStyleBackColor = true;
			this.button_ChangeName.Click += new System.EventHandler(this.button_EditName_Click);
			// 
			// RoleView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 565);
			this.Controls.Add(this.button_ChangeName);
			this.Controls.Add(this.lbl_SelectNotGivenPermissionsInvert);
			this.Controls.Add(this.lbl_SelectNotGivenPermissionsNone);
			this.Controls.Add(this.lbl_SelectNotGivenPermissionsAll);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lbl_SelectGivenPermissionsInvert);
			this.Controls.Add(this.lbl_SelectGivenPermissionsNone);
			this.Controls.Add(this.lbl_SelectGivenPermissionsAll);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button_CancelChangeName);
			this.Controls.Add(this.btn_SearchCancel);
			this.Controls.Add(this.btn_SearchRole);
			this.Controls.Add(this.txt_SearchRole);
			this.Controls.Add(this.btn_SaveNewRoleName);
			this.Controls.Add(this.lbl_Role);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_CreateRole);
			this.Controls.Add(this.btn_DeleteRole);
			this.Controls.Add(this.tv_RoleNotGivenPermissions);
			this.Controls.Add(this.tv_RoleGivenPermissions);
			this.Controls.Add(this.tv_Roles);
			this.Controls.Add(this.btn_EditRole);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.txt_RoleName);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(800, 600);
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "RoleView";
			this.Text = "Roles";
			this.Load += new System.EventHandler(this.Roles_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TreeView tv_Roles;
        private System.Windows.Forms.TreeView tv_RoleGivenPermissions;
        private System.Windows.Forms.TreeView tv_RoleNotGivenPermissions;
        private System.Windows.Forms.Button btn_DeleteRole;
        private System.Windows.Forms.Button btn_CreateRole;
        private System.Windows.Forms.Button btn_EditRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RoleAddPermissions;
        private System.Windows.Forms.Button btn_RoleRemovePermission;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_RoleName;
        private System.Windows.Forms.Button btn_SaveNewRoleName;
        private System.Windows.Forms.Button btn_SearchCancel;
        private System.Windows.Forms.Button btn_SearchRole;
        private System.Windows.Forms.TextBox txt_SearchRole;
        private System.Windows.Forms.Label lbl_SelectGivenPermissionsInvert;
        private System.Windows.Forms.Label lbl_SelectGivenPermissionsNone;
        private System.Windows.Forms.Label lbl_SelectGivenPermissionsAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_SelectNotGivenPermissionsInvert;
        private System.Windows.Forms.Label lbl_SelectNotGivenPermissionsNone;
        private System.Windows.Forms.Label lbl_SelectNotGivenPermissionsAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_CancelChangeName;
        private System.Windows.Forms.Button button_ChangeName;
    }
}