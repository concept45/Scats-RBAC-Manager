namespace RBACManager
{
    partial class CreateAccountDialog
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
			this.btn_CreateAccount = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_Username = new System.Windows.Forms.TextBox();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.drpdwn_Expansion = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btn_CreateAccount
			// 
			this.btn_CreateAccount.Location = new System.Drawing.Point(108, 108);
			this.btn_CreateAccount.Name = "btn_CreateAccount";
			this.btn_CreateAccount.Size = new System.Drawing.Size(75, 23);
			this.btn_CreateAccount.TabIndex = 4;
			this.btn_CreateAccount.Text = "Create";
			this.btn_CreateAccount.UseVisualStyleBackColor = true;
			this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(189, 108);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 5;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Expansion:";
			// 
			// txt_Username
			// 
			this.txt_Username.Location = new System.Drawing.Point(91, 23);
			this.txt_Username.MaxLength = 32;
			this.txt_Username.Name = "txt_Username";
			this.txt_Username.Size = new System.Drawing.Size(173, 20);
			this.txt_Username.TabIndex = 1;
			this.txt_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Username_KeyDown);
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(91, 49);
			this.txt_Password.MaxLength = 20;
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(173, 20);
			this.txt_Password.TabIndex = 2;
			this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
			// 
			// drpdwn_Expansion
			// 
			this.drpdwn_Expansion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drpdwn_Expansion.FormattingEnabled = true;
			this.drpdwn_Expansion.Location = new System.Drawing.Point(91, 75);
			this.drpdwn_Expansion.Name = "drpdwn_Expansion";
			this.drpdwn_Expansion.Size = new System.Drawing.Size(134, 21);
			this.drpdwn_Expansion.TabIndex = 3;
			this.drpdwn_Expansion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.drpdwn_Expansion_KeyDown);
			// 
			// CreateAccountDialog
			// 
			this.AcceptButton = this.btn_CreateAccount;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 143);
			this.ControlBox = false;
			this.Controls.Add(this.drpdwn_Expansion);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txt_Username);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_CreateAccount);
			this.Name = "CreateAccountDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Create Account";
			this.Load += new System.EventHandler(this.create_acc_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.ComboBox drpdwn_Expansion;
    }
}