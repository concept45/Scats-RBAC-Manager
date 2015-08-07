namespace RBACManager
{
    partial class AccountView
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
			this.tv_Accounts = new System.Windows.Forms.TreeView();
			this.btn_PermissionsRemove = new System.Windows.Forms.Button();
			this.btn_PermissionsAdd = new System.Windows.Forms.Button();
			this.tv_AccountNotGivenPermissions = new System.Windows.Forms.TreeView();
			this.tv_AccountGivenPermissions = new System.Windows.Forms.TreeView();
			this.label_Account = new System.Windows.Forms.Label();
			this.label_AccountName = new System.Windows.Forms.Label();
			this.btn_RoleRemove = new System.Windows.Forms.Button();
			this.btn_RoleAdd = new System.Windows.Forms.Button();
			this.tv_RolesAccountHasNot = new System.Windows.Forms.TreeView();
			this.tv_RolesAccountHas = new System.Windows.Forms.TreeView();
			this.btn_EditAccount = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btn_CreateAccount = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lbl_SelectNotGivenPermissionsInvert = new System.Windows.Forms.Label();
			this.lbl_SelectGivenPermissionsInvert = new System.Windows.Forms.Label();
			this.lbl_SelectNotGivenPermissionsNone = new System.Windows.Forms.Label();
			this.lbl_SelectGivenPermissionsNone = new System.Windows.Forms.Label();
			this.lbl_SelectNotGivenPermissionsAll = new System.Windows.Forms.Label();
			this.lbl_SelectGivenPermissionsAll = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lbl_SelectRolesHasNotInvert = new System.Windows.Forms.Label();
			this.lbl_SelectRolesHasInvert = new System.Windows.Forms.Label();
			this.lbl_SelectRolesHasNotNone = new System.Windows.Forms.Label();
			this.lbl_SelectRolesHasNone = new System.Windows.Forms.Label();
			this.lbl_SelectRolesHasNotAll = new System.Windows.Forms.Label();
			this.lbl_SelectRolesHasAll = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button_SaveSecurityLevel = new System.Windows.Forms.Button();
			this.comboBox_SecurityLevel = new System.Windows.Forms.ComboBox();
			this.label_SecurityLevel = new System.Windows.Forms.Label();
			this.btn_SaveEmail = new System.Windows.Forms.Button();
			this.btn_SaveExpansion = new System.Windows.Forms.Button();
			this.btn_ChangePassword = new System.Windows.Forms.Button();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.txt_LastLogin = new System.Windows.Forms.TextBox();
			this.txt_Joined = new System.Windows.Forms.TextBox();
			this.txt_LastIP = new System.Windows.Forms.TextBox();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.drpdwn_Expansion = new System.Windows.Forms.ComboBox();
			this.label_Password = new System.Windows.Forms.Label();
			this.label_LastLogin = new System.Windows.Forms.Label();
			this.label_Joindate = new System.Windows.Forms.Label();
			this.label_LastIP = new System.Windows.Forms.Label();
			this.label_Expansion = new System.Windows.Forms.Label();
			this.label_Email = new System.Windows.Forms.Label();
			this.txt_SearchAccount = new System.Windows.Forms.TextBox();
			this.btn_SearchAccount = new System.Windows.Forms.Button();
			this.btn_SearchCancel = new System.Windows.Forms.Button();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tv_Accounts
			// 
			this.tv_Accounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.tv_Accounts.FullRowSelect = true;
			this.tv_Accounts.HideSelection = false;
			this.tv_Accounts.Location = new System.Drawing.Point(12, 38);
			this.tv_Accounts.Name = "tv_Accounts";
			this.tv_Accounts.ShowLines = false;
			this.tv_Accounts.ShowPlusMinus = false;
			this.tv_Accounts.ShowRootLines = false;
			this.tv_Accounts.Size = new System.Drawing.Size(207, 470);
			this.tv_Accounts.TabIndex = 1;
			this.tv_Accounts.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_Accounts_NodeMouseDoubleClick);
			// 
			// btn_PermissionsRemove
			// 
			this.btn_PermissionsRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_PermissionsRemove.Location = new System.Drawing.Point(272, 248);
			this.btn_PermissionsRemove.Margin = new System.Windows.Forms.Padding(3, 6, 3, 5);
			this.btn_PermissionsRemove.Name = "btn_PermissionsRemove";
			this.btn_PermissionsRemove.Size = new System.Drawing.Size(41, 31);
			this.btn_PermissionsRemove.TabIndex = 6;
			this.btn_PermissionsRemove.Text = "∨";
			this.btn_PermissionsRemove.UseVisualStyleBackColor = true;
			this.btn_PermissionsRemove.Click += new System.EventHandler(this.btn_PermissionsRemove_Click);
			// 
			// btn_PermissionsAdd
			// 
			this.btn_PermissionsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_PermissionsAdd.Location = new System.Drawing.Point(225, 248);
			this.btn_PermissionsAdd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 5);
			this.btn_PermissionsAdd.Name = "btn_PermissionsAdd";
			this.btn_PermissionsAdd.Size = new System.Drawing.Size(41, 31);
			this.btn_PermissionsAdd.TabIndex = 5;
			this.btn_PermissionsAdd.Text = "∧";
			this.btn_PermissionsAdd.UseVisualStyleBackColor = true;
			this.btn_PermissionsAdd.Click += new System.EventHandler(this.btn_PermissionsAdd_Click);
			// 
			// tv_AccountNotGivenPermissions
			// 
			this.tv_AccountNotGivenPermissions.CheckBoxes = true;
			this.tv_AccountNotGivenPermissions.FullRowSelect = true;
			this.tv_AccountNotGivenPermissions.HideSelection = false;
			this.tv_AccountNotGivenPermissions.ItemHeight = 18;
			this.tv_AccountNotGivenPermissions.Location = new System.Drawing.Point(2, 287);
			this.tv_AccountNotGivenPermissions.Name = "tv_AccountNotGivenPermissions";
			this.tv_AccountNotGivenPermissions.ShowLines = false;
			this.tv_AccountNotGivenPermissions.ShowPlusMinus = false;
			this.tv_AccountNotGivenPermissions.ShowRootLines = false;
			this.tv_AccountNotGivenPermissions.Size = new System.Drawing.Size(533, 218);
			this.tv_AccountNotGivenPermissions.TabIndex = 7;
			this.tv_AccountNotGivenPermissions.DoubleClick += new System.EventHandler(this.tv_AccountNotGivenPermissions_DoubleClick);
			// 
			// tv_AccountGivenPermissions
			// 
			this.tv_AccountGivenPermissions.CheckBoxes = true;
			this.tv_AccountGivenPermissions.FullRowSelect = true;
			this.tv_AccountGivenPermissions.HideSelection = false;
			this.tv_AccountGivenPermissions.ItemHeight = 18;
			this.tv_AccountGivenPermissions.Location = new System.Drawing.Point(2, 24);
			this.tv_AccountGivenPermissions.Name = "tv_AccountGivenPermissions";
			this.tv_AccountGivenPermissions.ShowLines = false;
			this.tv_AccountGivenPermissions.ShowPlusMinus = false;
			this.tv_AccountGivenPermissions.ShowRootLines = false;
			this.tv_AccountGivenPermissions.Size = new System.Drawing.Size(533, 218);
			this.tv_AccountGivenPermissions.TabIndex = 4;
			this.tv_AccountGivenPermissions.DoubleClick += new System.EventHandler(this.tv_AccountGivenPermissions_DoubleClick);
			// 
			// label_Account
			// 
			this.label_Account.AutoSize = true;
			this.label_Account.Location = new System.Drawing.Point(228, 9);
			this.label_Account.Name = "label_Account";
			this.label_Account.Size = new System.Drawing.Size(50, 13);
			this.label_Account.TabIndex = 0;
			this.label_Account.Text = "Account:";
			// 
			// label_AccountName
			// 
			this.label_AccountName.AutoSize = true;
			this.label_AccountName.Location = new System.Drawing.Point(284, 9);
			this.label_AccountName.Name = "label_AccountName";
			this.label_AccountName.Size = new System.Drawing.Size(91, 13);
			this.label_AccountName.TabIndex = 2;
			this.label_AccountName.Text = "lbl_AccountName";
			// 
			// btn_RoleRemove
			// 
			this.btn_RoleRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RoleRemove.Location = new System.Drawing.Point(272, 248);
			this.btn_RoleRemove.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.btn_RoleRemove.Name = "btn_RoleRemove";
			this.btn_RoleRemove.Size = new System.Drawing.Size(41, 31);
			this.btn_RoleRemove.TabIndex = 10;
			this.btn_RoleRemove.Text = "∨";
			this.btn_RoleRemove.UseVisualStyleBackColor = true;
			this.btn_RoleRemove.Click += new System.EventHandler(this.btn_RoleRemove_Click);
			// 
			// btn_RoleAdd
			// 
			this.btn_RoleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RoleAdd.Location = new System.Drawing.Point(225, 248);
			this.btn_RoleAdd.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
			this.btn_RoleAdd.Name = "btn_RoleAdd";
			this.btn_RoleAdd.Size = new System.Drawing.Size(41, 31);
			this.btn_RoleAdd.TabIndex = 9;
			this.btn_RoleAdd.Text = "∧";
			this.btn_RoleAdd.UseVisualStyleBackColor = true;
			this.btn_RoleAdd.Click += new System.EventHandler(this.btn_RoleAdd_Click);
			// 
			// tv_RolesAccountHasNot
			// 
			this.tv_RolesAccountHasNot.CheckBoxes = true;
			this.tv_RolesAccountHasNot.FullRowSelect = true;
			this.tv_RolesAccountHasNot.HideSelection = false;
			this.tv_RolesAccountHasNot.Location = new System.Drawing.Point(2, 287);
			this.tv_RolesAccountHasNot.Name = "tv_RolesAccountHasNot";
			this.tv_RolesAccountHasNot.ShowLines = false;
			this.tv_RolesAccountHasNot.ShowPlusMinus = false;
			this.tv_RolesAccountHasNot.ShowRootLines = false;
			this.tv_RolesAccountHasNot.Size = new System.Drawing.Size(533, 218);
			this.tv_RolesAccountHasNot.TabIndex = 11;
			this.tv_RolesAccountHasNot.DoubleClick += new System.EventHandler(this.tv_RolesAccountHasNot_DoubleClick);
			// 
			// tv_RolesAccountHas
			// 
			this.tv_RolesAccountHas.CheckBoxes = true;
			this.tv_RolesAccountHas.FullRowSelect = true;
			this.tv_RolesAccountHas.HideSelection = false;
			this.tv_RolesAccountHas.Location = new System.Drawing.Point(2, 24);
			this.tv_RolesAccountHas.Name = "tv_RolesAccountHas";
			this.tv_RolesAccountHas.ShowLines = false;
			this.tv_RolesAccountHas.ShowPlusMinus = false;
			this.tv_RolesAccountHas.ShowRootLines = false;
			this.tv_RolesAccountHas.Size = new System.Drawing.Size(533, 218);
			this.tv_RolesAccountHas.TabIndex = 8;
			this.tv_RolesAccountHas.DoubleClick += new System.EventHandler(this.tv_RolesAccountHas_DoubleClick);
			// 
			// btn_EditAccount
			// 
			this.btn_EditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_EditAccount.Image = global::RBACManager.Properties.Resources.edit;
			this.btn_EditAccount.Location = new System.Drawing.Point(67, 514);
			this.btn_EditAccount.Margin = new System.Windows.Forms.Padding(28, 3, 28, 3);
			this.btn_EditAccount.Name = "btn_EditAccount";
			this.btn_EditAccount.Size = new System.Drawing.Size(42, 42);
			this.btn_EditAccount.TabIndex = 2;
			this.btn_EditAccount.UseVisualStyleBackColor = true;
			this.btn_EditAccount.Click += new System.EventHandler(this.btn_EditAccount_Click);
			// 
			// btn_CreateAccount
			// 
			this.btn_CreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_CreateAccount.Image = global::RBACManager.Properties.Resources.add_;
			this.btn_CreateAccount.Location = new System.Drawing.Point(115, 514);
			this.btn_CreateAccount.Name = "btn_CreateAccount";
			this.btn_CreateAccount.Size = new System.Drawing.Size(42, 42);
			this.btn_CreateAccount.TabIndex = 3;
			this.btn_CreateAccount.UseVisualStyleBackColor = true;
			this.btn_CreateAccount.Click += new System.EventHandler(this.btn_CreateAccount_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(225, 25);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(547, 535);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lbl_SelectNotGivenPermissionsInvert);
			this.tabPage1.Controls.Add(this.lbl_SelectGivenPermissionsInvert);
			this.tabPage1.Controls.Add(this.lbl_SelectNotGivenPermissionsNone);
			this.tabPage1.Controls.Add(this.lbl_SelectGivenPermissionsNone);
			this.tabPage1.Controls.Add(this.lbl_SelectNotGivenPermissionsAll);
			this.tabPage1.Controls.Add(this.lbl_SelectGivenPermissionsAll);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.btn_PermissionsRemove);
			this.tabPage1.Controls.Add(this.tv_AccountGivenPermissions);
			this.tabPage1.Controls.Add(this.btn_PermissionsAdd);
			this.tabPage1.Controls.Add(this.tv_AccountNotGivenPermissions);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(539, 509);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Permissions";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lbl_SelectNotGivenPermissionsInvert
			// 
			this.lbl_SelectNotGivenPermissionsInvert.AutoSize = true;
			this.lbl_SelectNotGivenPermissionsInvert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectNotGivenPermissionsInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectNotGivenPermissionsInvert.Location = new System.Drawing.Point(121, 271);
			this.lbl_SelectNotGivenPermissionsInvert.Name = "lbl_SelectNotGivenPermissionsInvert";
			this.lbl_SelectNotGivenPermissionsInvert.Size = new System.Drawing.Size(40, 13);
			this.lbl_SelectNotGivenPermissionsInvert.TabIndex = 11;
			this.lbl_SelectNotGivenPermissionsInvert.Text = "Invert";
			this.lbl_SelectNotGivenPermissionsInvert.Click += new System.EventHandler(this.lbl_SelectNotGivenPermissionsInvert_Click);
			// 
			// lbl_SelectGivenPermissionsInvert
			// 
			this.lbl_SelectGivenPermissionsInvert.AutoSize = true;
			this.lbl_SelectGivenPermissionsInvert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectGivenPermissionsInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectGivenPermissionsInvert.Location = new System.Drawing.Point(121, 8);
			this.lbl_SelectGivenPermissionsInvert.Name = "lbl_SelectGivenPermissionsInvert";
			this.lbl_SelectGivenPermissionsInvert.Size = new System.Drawing.Size(40, 13);
			this.lbl_SelectGivenPermissionsInvert.TabIndex = 11;
			this.lbl_SelectGivenPermissionsInvert.Text = "Invert";
			this.lbl_SelectGivenPermissionsInvert.Click += new System.EventHandler(this.lbl_SelectGivenPermissionsInvert_Click);
			// 
			// lbl_SelectNotGivenPermissionsNone
			// 
			this.lbl_SelectNotGivenPermissionsNone.AutoSize = true;
			this.lbl_SelectNotGivenPermissionsNone.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectNotGivenPermissionsNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectNotGivenPermissionsNone.Location = new System.Drawing.Point(78, 271);
			this.lbl_SelectNotGivenPermissionsNone.Name = "lbl_SelectNotGivenPermissionsNone";
			this.lbl_SelectNotGivenPermissionsNone.Size = new System.Drawing.Size(37, 13);
			this.lbl_SelectNotGivenPermissionsNone.TabIndex = 10;
			this.lbl_SelectNotGivenPermissionsNone.Text = "None";
			this.lbl_SelectNotGivenPermissionsNone.Click += new System.EventHandler(this.lbl_SelectNotGivenPermissionsNone_Click);
			// 
			// lbl_SelectGivenPermissionsNone
			// 
			this.lbl_SelectGivenPermissionsNone.AutoSize = true;
			this.lbl_SelectGivenPermissionsNone.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectGivenPermissionsNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectGivenPermissionsNone.Location = new System.Drawing.Point(78, 8);
			this.lbl_SelectGivenPermissionsNone.Name = "lbl_SelectGivenPermissionsNone";
			this.lbl_SelectGivenPermissionsNone.Size = new System.Drawing.Size(37, 13);
			this.lbl_SelectGivenPermissionsNone.TabIndex = 10;
			this.lbl_SelectGivenPermissionsNone.Text = "None";
			this.lbl_SelectGivenPermissionsNone.Click += new System.EventHandler(this.lbl_SelectGivenPermissionsNone_Click);
			// 
			// lbl_SelectNotGivenPermissionsAll
			// 
			this.lbl_SelectNotGivenPermissionsAll.AutoSize = true;
			this.lbl_SelectNotGivenPermissionsAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectNotGivenPermissionsAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectNotGivenPermissionsAll.Location = new System.Drawing.Point(53, 271);
			this.lbl_SelectNotGivenPermissionsAll.Name = "lbl_SelectNotGivenPermissionsAll";
			this.lbl_SelectNotGivenPermissionsAll.Size = new System.Drawing.Size(21, 13);
			this.lbl_SelectNotGivenPermissionsAll.TabIndex = 9;
			this.lbl_SelectNotGivenPermissionsAll.Text = "All";
			this.lbl_SelectNotGivenPermissionsAll.Click += new System.EventHandler(this.lbl_SelectNotGivenPermissionsAll_Click);
			// 
			// lbl_SelectGivenPermissionsAll
			// 
			this.lbl_SelectGivenPermissionsAll.AutoSize = true;
			this.lbl_SelectGivenPermissionsAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectGivenPermissionsAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectGivenPermissionsAll.Location = new System.Drawing.Point(53, 8);
			this.lbl_SelectGivenPermissionsAll.Name = "lbl_SelectGivenPermissionsAll";
			this.lbl_SelectGivenPermissionsAll.Size = new System.Drawing.Size(21, 13);
			this.lbl_SelectGivenPermissionsAll.TabIndex = 9;
			this.lbl_SelectGivenPermissionsAll.Text = "All";
			this.lbl_SelectGivenPermissionsAll.Click += new System.EventHandler(this.lbl_SelectGivenPermissionsAll_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(7, 271);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(40, 13);
			this.label12.TabIndex = 8;
			this.label12.Text = "Select:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Select:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lbl_SelectRolesHasNotInvert);
			this.tabPage2.Controls.Add(this.lbl_SelectRolesHasInvert);
			this.tabPage2.Controls.Add(this.lbl_SelectRolesHasNotNone);
			this.tabPage2.Controls.Add(this.lbl_SelectRolesHasNone);
			this.tabPage2.Controls.Add(this.lbl_SelectRolesHasNotAll);
			this.tabPage2.Controls.Add(this.lbl_SelectRolesHasAll);
			this.tabPage2.Controls.Add(this.label20);
			this.tabPage2.Controls.Add(this.label19);
			this.tabPage2.Controls.Add(this.btn_RoleRemove);
			this.tabPage2.Controls.Add(this.tv_RolesAccountHas);
			this.tabPage2.Controls.Add(this.btn_RoleAdd);
			this.tabPage2.Controls.Add(this.tv_RolesAccountHasNot);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(539, 509);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Roles";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lbl_SelectRolesHasNotInvert
			// 
			this.lbl_SelectRolesHasNotInvert.AutoSize = true;
			this.lbl_SelectRolesHasNotInvert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectRolesHasNotInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectRolesHasNotInvert.Location = new System.Drawing.Point(121, 271);
			this.lbl_SelectRolesHasNotInvert.Name = "lbl_SelectRolesHasNotInvert";
			this.lbl_SelectRolesHasNotInvert.Size = new System.Drawing.Size(40, 13);
			this.lbl_SelectRolesHasNotInvert.TabIndex = 15;
			this.lbl_SelectRolesHasNotInvert.Text = "Invert";
			this.lbl_SelectRolesHasNotInvert.Click += new System.EventHandler(this.lbl_SelectRolesHasNotInvert_Click);
			// 
			// lbl_SelectRolesHasInvert
			// 
			this.lbl_SelectRolesHasInvert.AutoSize = true;
			this.lbl_SelectRolesHasInvert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectRolesHasInvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectRolesHasInvert.Location = new System.Drawing.Point(121, 8);
			this.lbl_SelectRolesHasInvert.Name = "lbl_SelectRolesHasInvert";
			this.lbl_SelectRolesHasInvert.Size = new System.Drawing.Size(40, 13);
			this.lbl_SelectRolesHasInvert.TabIndex = 15;
			this.lbl_SelectRolesHasInvert.Text = "Invert";
			this.lbl_SelectRolesHasInvert.Click += new System.EventHandler(this.lbl_SelectRolesHasInvert_Click);
			// 
			// lbl_SelectRolesHasNotNone
			// 
			this.lbl_SelectRolesHasNotNone.AutoSize = true;
			this.lbl_SelectRolesHasNotNone.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectRolesHasNotNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectRolesHasNotNone.Location = new System.Drawing.Point(78, 271);
			this.lbl_SelectRolesHasNotNone.Name = "lbl_SelectRolesHasNotNone";
			this.lbl_SelectRolesHasNotNone.Size = new System.Drawing.Size(37, 13);
			this.lbl_SelectRolesHasNotNone.TabIndex = 14;
			this.lbl_SelectRolesHasNotNone.Text = "None";
			this.lbl_SelectRolesHasNotNone.Click += new System.EventHandler(this.lbl_SelectRolesHasNotNone_Click);
			// 
			// lbl_SelectRolesHasNone
			// 
			this.lbl_SelectRolesHasNone.AutoSize = true;
			this.lbl_SelectRolesHasNone.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectRolesHasNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectRolesHasNone.Location = new System.Drawing.Point(78, 8);
			this.lbl_SelectRolesHasNone.Name = "lbl_SelectRolesHasNone";
			this.lbl_SelectRolesHasNone.Size = new System.Drawing.Size(37, 13);
			this.lbl_SelectRolesHasNone.TabIndex = 14;
			this.lbl_SelectRolesHasNone.Text = "None";
			this.lbl_SelectRolesHasNone.Click += new System.EventHandler(this.lbl_SelectRolesHasNone_Click);
			// 
			// lbl_SelectRolesHasNotAll
			// 
			this.lbl_SelectRolesHasNotAll.AutoSize = true;
			this.lbl_SelectRolesHasNotAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectRolesHasNotAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectRolesHasNotAll.Location = new System.Drawing.Point(53, 271);
			this.lbl_SelectRolesHasNotAll.Name = "lbl_SelectRolesHasNotAll";
			this.lbl_SelectRolesHasNotAll.Size = new System.Drawing.Size(21, 13);
			this.lbl_SelectRolesHasNotAll.TabIndex = 13;
			this.lbl_SelectRolesHasNotAll.Text = "All";
			this.lbl_SelectRolesHasNotAll.Click += new System.EventHandler(this.lbl_SelectRolesHasNotAll_Click);
			// 
			// lbl_SelectRolesHasAll
			// 
			this.lbl_SelectRolesHasAll.AutoSize = true;
			this.lbl_SelectRolesHasAll.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_SelectRolesHasAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_SelectRolesHasAll.Location = new System.Drawing.Point(53, 8);
			this.lbl_SelectRolesHasAll.Name = "lbl_SelectRolesHasAll";
			this.lbl_SelectRolesHasAll.Size = new System.Drawing.Size(21, 13);
			this.lbl_SelectRolesHasAll.TabIndex = 13;
			this.lbl_SelectRolesHasAll.Text = "All";
			this.lbl_SelectRolesHasAll.Click += new System.EventHandler(this.lbl_SelectRolesHasAll_Click);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(7, 271);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(40, 13);
			this.label20.TabIndex = 12;
			this.label20.Text = "Select:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(7, 8);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(40, 13);
			this.label19.TabIndex = 12;
			this.label19.Text = "Select:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.button_SaveSecurityLevel);
			this.tabPage3.Controls.Add(this.comboBox_SecurityLevel);
			this.tabPage3.Controls.Add(this.label_SecurityLevel);
			this.tabPage3.Controls.Add(this.btn_SaveEmail);
			this.tabPage3.Controls.Add(this.btn_SaveExpansion);
			this.tabPage3.Controls.Add(this.btn_ChangePassword);
			this.tabPage3.Controls.Add(this.txt_Password);
			this.tabPage3.Controls.Add(this.txt_LastLogin);
			this.tabPage3.Controls.Add(this.txt_Joined);
			this.tabPage3.Controls.Add(this.txt_LastIP);
			this.tabPage3.Controls.Add(this.txt_Email);
			this.tabPage3.Controls.Add(this.drpdwn_Expansion);
			this.tabPage3.Controls.Add(this.label_Password);
			this.tabPage3.Controls.Add(this.label_LastLogin);
			this.tabPage3.Controls.Add(this.label_Joindate);
			this.tabPage3.Controls.Add(this.label_LastIP);
			this.tabPage3.Controls.Add(this.label_Expansion);
			this.tabPage3.Controls.Add(this.label_Email);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(539, 509);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Account Details";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button_SaveSecurityLevel
			// 
			this.button_SaveSecurityLevel.Location = new System.Drawing.Point(191, 86);
			this.button_SaveSecurityLevel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.button_SaveSecurityLevel.Name = "button_SaveSecurityLevel";
			this.button_SaveSecurityLevel.Size = new System.Drawing.Size(117, 23);
			this.button_SaveSecurityLevel.TabIndex = 20;
			this.button_SaveSecurityLevel.Text = "Save Security Level";
			this.button_SaveSecurityLevel.UseVisualStyleBackColor = true;
			this.button_SaveSecurityLevel.Visible = false;
			// 
			// comboBox_SecurityLevel
			// 
			this.comboBox_SecurityLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_SecurityLevel.FormattingEnabled = true;
			this.comboBox_SecurityLevel.Items.AddRange(new object[] {
            "0"});
			this.comboBox_SecurityLevel.Location = new System.Drawing.Point(119, 88);
			this.comboBox_SecurityLevel.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
			this.comboBox_SecurityLevel.Name = "comboBox_SecurityLevel";
			this.comboBox_SecurityLevel.Size = new System.Drawing.Size(66, 21);
			this.comboBox_SecurityLevel.TabIndex = 19;
			this.comboBox_SecurityLevel.Visible = false;
			// 
			// label_SecurityLevel
			// 
			this.label_SecurityLevel.AutoSize = true;
			this.label_SecurityLevel.Location = new System.Drawing.Point(23, 91);
			this.label_SecurityLevel.Name = "label_SecurityLevel";
			this.label_SecurityLevel.Size = new System.Drawing.Size(77, 13);
			this.label_SecurityLevel.TabIndex = 18;
			this.label_SecurityLevel.Text = "Security Level:";
			this.label_SecurityLevel.Visible = false;
			// 
			// btn_SaveEmail
			// 
			this.btn_SaveEmail.Location = new System.Drawing.Point(370, 25);
			this.btn_SaveEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_SaveEmail.Name = "btn_SaveEmail";
			this.btn_SaveEmail.Size = new System.Drawing.Size(75, 23);
			this.btn_SaveEmail.TabIndex = 17;
			this.btn_SaveEmail.Text = "Save Email";
			this.btn_SaveEmail.UseVisualStyleBackColor = true;
			this.btn_SaveEmail.Click += new System.EventHandler(this.btn_SaveEmail_Click);
			// 
			// btn_SaveExpansion
			// 
			this.btn_SaveExpansion.Location = new System.Drawing.Point(292, 55);
			this.btn_SaveExpansion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_SaveExpansion.Name = "btn_SaveExpansion";
			this.btn_SaveExpansion.Size = new System.Drawing.Size(99, 23);
			this.btn_SaveExpansion.TabIndex = 14;
			this.btn_SaveExpansion.Text = "Save Expansion";
			this.btn_SaveExpansion.UseVisualStyleBackColor = true;
			this.btn_SaveExpansion.Click += new System.EventHandler(this.btn_SaveExpansion_Click);
			// 
			// btn_ChangePassword
			// 
			this.btn_ChangePassword.Location = new System.Drawing.Point(292, 235);
			this.btn_ChangePassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.btn_ChangePassword.Name = "btn_ChangePassword";
			this.btn_ChangePassword.Size = new System.Drawing.Size(111, 23);
			this.btn_ChangePassword.TabIndex = 13;
			this.btn_ChangePassword.Text = "Change Password";
			this.btn_ChangePassword.UseVisualStyleBackColor = true;
			this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(117, 237);
			this.txt_Password.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(169, 20);
			this.txt_Password.TabIndex = 12;
			// 
			// txt_LastLogin
			// 
			this.txt_LastLogin.BackColor = System.Drawing.SystemColors.Window;
			this.txt_LastLogin.Location = new System.Drawing.Point(117, 179);
			this.txt_LastLogin.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
			this.txt_LastLogin.Name = "txt_LastLogin";
			this.txt_LastLogin.ReadOnly = true;
			this.txt_LastLogin.Size = new System.Drawing.Size(169, 20);
			this.txt_LastLogin.TabIndex = 11;
			// 
			// txt_Joined
			// 
			this.txt_Joined.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Joined.Location = new System.Drawing.Point(117, 149);
			this.txt_Joined.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
			this.txt_Joined.Name = "txt_Joined";
			this.txt_Joined.ReadOnly = true;
			this.txt_Joined.Size = new System.Drawing.Size(169, 20);
			this.txt_Joined.TabIndex = 10;
			// 
			// txt_LastIP
			// 
			this.txt_LastIP.BackColor = System.Drawing.SystemColors.Window;
			this.txt_LastIP.Location = new System.Drawing.Point(119, 119);
			this.txt_LastIP.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
			this.txt_LastIP.Name = "txt_LastIP";
			this.txt_LastIP.ReadOnly = true;
			this.txt_LastIP.Size = new System.Drawing.Size(167, 20);
			this.txt_LastIP.TabIndex = 9;
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(119, 27);
			this.txt_Email.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(245, 20);
			this.txt_Email.TabIndex = 8;
			// 
			// drpdwn_Expansion
			// 
			this.drpdwn_Expansion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.drpdwn_Expansion.FormattingEnabled = true;
			this.drpdwn_Expansion.Location = new System.Drawing.Point(119, 57);
			this.drpdwn_Expansion.Margin = new System.Windows.Forms.Padding(10, 5, 3, 5);
			this.drpdwn_Expansion.Name = "drpdwn_Expansion";
			this.drpdwn_Expansion.Size = new System.Drawing.Size(167, 21);
			this.drpdwn_Expansion.TabIndex = 7;
			// 
			// label_Password
			// 
			this.label_Password.AutoSize = true;
			this.label_Password.Location = new System.Drawing.Point(42, 240);
			this.label_Password.Margin = new System.Windows.Forms.Padding(3, 45, 3, 0);
			this.label_Password.Name = "label_Password";
			this.label_Password.Size = new System.Drawing.Size(56, 13);
			this.label_Password.TabIndex = 5;
			this.label_Password.Text = "Password:";
			// 
			// label_LastLogin
			// 
			this.label_LastLogin.AutoSize = true;
			this.label_LastLogin.Location = new System.Drawing.Point(39, 182);
			this.label_LastLogin.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.label_LastLogin.Name = "label_LastLogin";
			this.label_LastLogin.Size = new System.Drawing.Size(59, 13);
			this.label_LastLogin.TabIndex = 4;
			this.label_LastLogin.Text = "Last Login:";
			// 
			// label_Joindate
			// 
			this.label_Joindate.AutoSize = true;
			this.label_Joindate.Location = new System.Drawing.Point(48, 152);
			this.label_Joindate.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.label_Joindate.Name = "label_Joindate";
			this.label_Joindate.Size = new System.Drawing.Size(50, 13);
			this.label_Joindate.TabIndex = 3;
			this.label_Joindate.Text = "Joindate:";
			// 
			// label_LastIP
			// 
			this.label_LastIP.AutoSize = true;
			this.label_LastIP.Location = new System.Drawing.Point(57, 122);
			this.label_LastIP.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.label_LastIP.Name = "label_LastIP";
			this.label_LastIP.Size = new System.Drawing.Size(43, 13);
			this.label_LastIP.TabIndex = 2;
			this.label_LastIP.Text = "Last IP:";
			// 
			// label_Expansion
			// 
			this.label_Expansion.AutoSize = true;
			this.label_Expansion.Location = new System.Drawing.Point(41, 60);
			this.label_Expansion.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.label_Expansion.Name = "label_Expansion";
			this.label_Expansion.Size = new System.Drawing.Size(59, 13);
			this.label_Expansion.TabIndex = 1;
			this.label_Expansion.Text = "Expansion:";
			// 
			// label_Email
			// 
			this.label_Email.AutoSize = true;
			this.label_Email.Location = new System.Drawing.Point(65, 30);
			this.label_Email.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
			this.label_Email.Name = "label_Email";
			this.label_Email.Size = new System.Drawing.Size(35, 13);
			this.label_Email.TabIndex = 0;
			this.label_Email.Text = "Email:";
			// 
			// txt_SearchAccount
			// 
			this.txt_SearchAccount.Location = new System.Drawing.Point(12, 12);
			this.txt_SearchAccount.Name = "txt_SearchAccount";
			this.txt_SearchAccount.Size = new System.Drawing.Size(161, 20);
			this.txt_SearchAccount.TabIndex = 5;
			this.txt_SearchAccount.Text = "Search for account";
			this.txt_SearchAccount.Enter += new System.EventHandler(this.txt_SearchAccount_Enter);
			this.txt_SearchAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SearchAccount_KeyDown);
			this.txt_SearchAccount.Leave += new System.EventHandler(this.txt_SearchAccount_Leave);
			// 
			// btn_SearchAccount
			// 
			this.btn_SearchAccount.Image = global::RBACManager.Properties.Resources.search;
			this.btn_SearchAccount.Location = new System.Drawing.Point(171, 9);
			this.btn_SearchAccount.Name = "btn_SearchAccount";
			this.btn_SearchAccount.Size = new System.Drawing.Size(24, 24);
			this.btn_SearchAccount.TabIndex = 6;
			this.btn_SearchAccount.UseVisualStyleBackColor = true;
			this.btn_SearchAccount.Click += new System.EventHandler(this.btn_SearchAccount_Click);
			// 
			// btn_SearchCancel
			// 
			this.btn_SearchCancel.Image = global::RBACManager.Properties.Resources.cancel;
			this.btn_SearchCancel.Location = new System.Drawing.Point(195, 9);
			this.btn_SearchCancel.Name = "btn_SearchCancel";
			this.btn_SearchCancel.Size = new System.Drawing.Size(24, 24);
			this.btn_SearchCancel.TabIndex = 18;
			this.btn_SearchCancel.UseVisualStyleBackColor = true;
			this.btn_SearchCancel.Click += new System.EventHandler(this.btn_SearchCancel_Click);
			// 
			// AccountView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.btn_SearchCancel);
			this.Controls.Add(this.btn_SearchAccount);
			this.Controls.Add(this.txt_SearchAccount);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btn_CreateAccount);
			this.Controls.Add(this.btn_EditAccount);
			this.Controls.Add(this.label_AccountName);
			this.Controls.Add(this.label_Account);
			this.Controls.Add(this.tv_Accounts);
			this.MaximizeBox = false;
			this.Name = "AccountView";
			this.Text = "Account Permissions";
			this.Load += new System.EventHandler(this.accounts_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Accounts;
        private System.Windows.Forms.Button btn_PermissionsRemove;
        private System.Windows.Forms.Button btn_PermissionsAdd;
        private System.Windows.Forms.TreeView tv_AccountNotGivenPermissions;
        private System.Windows.Forms.TreeView tv_AccountGivenPermissions;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.Label label_AccountName;
        private System.Windows.Forms.Button btn_RoleRemove;
        private System.Windows.Forms.Button btn_RoleAdd;
        private System.Windows.Forms.TreeView tv_RolesAccountHasNot;
        private System.Windows.Forms.TreeView tv_RolesAccountHas;
        private System.Windows.Forms.Button btn_EditAccount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_CreateAccount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_SaveEmail;
        private System.Windows.Forms.Button btn_SaveExpansion;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_LastLogin;
        private System.Windows.Forms.TextBox txt_Joined;
        private System.Windows.Forms.TextBox txt_LastIP;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.ComboBox drpdwn_Expansion;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_LastLogin;
        private System.Windows.Forms.Label label_Joindate;
        private System.Windows.Forms.Label label_LastIP;
        private System.Windows.Forms.Label label_Expansion;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox txt_SearchAccount;
        private System.Windows.Forms.Button btn_SearchAccount;
        private System.Windows.Forms.Button btn_SearchCancel;
        private System.Windows.Forms.Label lbl_SelectNotGivenPermissionsInvert;
        private System.Windows.Forms.Label lbl_SelectGivenPermissionsInvert;
        private System.Windows.Forms.Label lbl_SelectNotGivenPermissionsNone;
        private System.Windows.Forms.Label lbl_SelectGivenPermissionsNone;
        private System.Windows.Forms.Label lbl_SelectNotGivenPermissionsAll;
        private System.Windows.Forms.Label lbl_SelectGivenPermissionsAll;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_SelectRolesHasNotInvert;
        private System.Windows.Forms.Label lbl_SelectRolesHasInvert;
        private System.Windows.Forms.Label lbl_SelectRolesHasNotNone;
        private System.Windows.Forms.Label lbl_SelectRolesHasNone;
        private System.Windows.Forms.Label lbl_SelectRolesHasNotAll;
        private System.Windows.Forms.Label lbl_SelectRolesHasAll;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox_SecurityLevel;
        private System.Windows.Forms.Label label_SecurityLevel;
        private System.Windows.Forms.Button button_SaveSecurityLevel;
    }
}