namespace RBACManager
{
    partial class SettingsView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
			this.label1 = new System.Windows.Forms.Label();
			this.txt_ip = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_port = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_user = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_authdb = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_CheckConnection = new System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Host/IP Address";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txt_ip
			// 
			this.txt_ip.Location = new System.Drawing.Point(156, 22);
			this.txt_ip.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.txt_ip.Name = "txt_ip";
			this.txt_ip.Size = new System.Drawing.Size(155, 20);
			this.txt_ip.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(107, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Port";
			// 
			// txt_port
			// 
			this.txt_port.Location = new System.Drawing.Point(156, 51);
			this.txt_port.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.txt_port.Name = "txt_port";
			this.txt_port.Size = new System.Drawing.Size(78, 20);
			this.txt_port.TabIndex = 2;
			this.txt_port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_port_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(78, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Username";
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(156, 80);
			this.txt_user.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(155, 20);
			this.txt_user.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(80, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password";
			// 
			// txt_pass
			// 
			this.txt_pass.Location = new System.Drawing.Point(156, 109);
			this.txt_pass.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(155, 20);
			this.txt_pass.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(60, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Authdatabase";
			// 
			// txt_authdb
			// 
			this.txt_authdb.Location = new System.Drawing.Point(156, 138);
			this.txt_authdb.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.txt_authdb.Name = "txt_authdb";
			this.txt_authdb.Size = new System.Drawing.Size(155, 20);
			this.txt_authdb.TabIndex = 5;
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.txt_ip);
			this.GroupBox1.Controls.Add(this.txt_authdb);
			this.GroupBox1.Controls.Add(this.label1);
			this.GroupBox1.Controls.Add(this.label5);
			this.GroupBox1.Controls.Add(this.label2);
			this.GroupBox1.Controls.Add(this.txt_pass);
			this.GroupBox1.Controls.Add(this.txt_port);
			this.GroupBox1.Controls.Add(this.label4);
			this.GroupBox1.Controls.Add(this.label3);
			this.GroupBox1.Controls.Add(this.txt_user);
			this.GroupBox1.Location = new System.Drawing.Point(12, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(322, 171);
			this.GroupBox1.TabIndex = 8;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "MySQL Settings";
			// 
			// btn_Close
			// 
			this.btn_Close.Location = new System.Drawing.Point(259, 189);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(75, 23);
			this.btn_Close.TabIndex = 8;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(178, 189);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 7;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_CheckConnection
			// 
			this.btn_CheckConnection.Location = new System.Drawing.Point(12, 189);
			this.btn_CheckConnection.Name = "btn_CheckConnection";
			this.btn_CheckConnection.Size = new System.Drawing.Size(160, 23);
			this.btn_CheckConnection.TabIndex = 6;
			this.btn_CheckConnection.Text = "Check Database Connection";
			this.btn_CheckConnection.UseVisualStyleBackColor = true;
			this.btn_CheckConnection.Click += new System.EventHandler(this.btn_CheckConnection_Click);
			// 
			// SettingsView
			// 
			this.AcceptButton = this.btn_Save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 220);
			this.ControlBox = false;
			this.Controls.Add(this.btn_CheckConnection);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.GroupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsView";
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.settings_Load);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_authdb;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_CheckConnection;
    }
}