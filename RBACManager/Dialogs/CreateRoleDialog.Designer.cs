namespace RBACManager
{
    partial class CreateRoleDialog
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
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_CreateRole = new System.Windows.Forms.Button();
			this.txt_Rolename = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(197, 64);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 3;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// btn_CreateRole
			// 
			this.btn_CreateRole.Location = new System.Drawing.Point(116, 64);
			this.btn_CreateRole.Name = "btn_CreateRole";
			this.btn_CreateRole.Size = new System.Drawing.Size(75, 23);
			this.btn_CreateRole.TabIndex = 2;
			this.btn_CreateRole.Text = "Create";
			this.btn_CreateRole.UseVisualStyleBackColor = true;
			this.btn_CreateRole.Click += new System.EventHandler(this.btn_CreateRole_Click);
			// 
			// txt_Rolename
			// 
			this.txt_Rolename.Location = new System.Drawing.Point(12, 34);
			this.txt_Rolename.MaxLength = 100;
			this.txt_Rolename.Name = "txt_Rolename";
			this.txt_Rolename.Size = new System.Drawing.Size(260, 20);
			this.txt_Rolename.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			// 
			// CreateRoleDialog
			// 
			this.AcceptButton = this.btn_CreateRole;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 100);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_Rolename);
			this.Controls.Add(this.btn_CreateRole);
			this.Controls.Add(this.btn_Cancel);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 135);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 135);
			this.Name = "CreateRoleDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Create role";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_CreateRole;
        private System.Windows.Forms.TextBox txt_Rolename;
        private System.Windows.Forms.Label label1;
    }
}