namespace PayRollTaxCalculator
{
    partial class Form_Main
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
            System.Windows.Forms.Label commentsLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label user_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lvwNews = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAbout = new System.Windows.Forms.Label();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.lvwHelp = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwIRS = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnContinue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabContact = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLoginAsGuest = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblFeedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFeedbackTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFeedbackTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblUsersTableAdapter();
            commentsLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            user_NameLabel = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabHelp.SuspendLayout();
            this.tabContact.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // commentsLabel
            // 
            commentsLabel.AutoSize = true;
            commentsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            commentsLabel.ForeColor = System.Drawing.Color.Black;
            commentsLabel.Location = new System.Drawing.Point(90, 202);
            commentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            commentsLabel.Name = "commentsLabel";
            commentsLabel.Size = new System.Drawing.Size(116, 28);
            commentsLabel.TabIndex = 16;
            commentsLabel.Text = "Comments:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.Black;
            emailLabel.Location = new System.Drawing.Point(90, 134);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(65, 28);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Email:";
            // 
            // user_NameLabel
            // 
            user_NameLabel.AutoSize = true;
            user_NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            user_NameLabel.ForeColor = System.Drawing.Color.Black;
            user_NameLabel.Location = new System.Drawing.Point(90, 66);
            user_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            user_NameLabel.Name = "user_NameLabel";
            user_NameLabel.Size = new System.Drawing.Size(165, 28);
            user_NameLabel.TabIndex = 14;
            user_NameLabel.Text = "Customer Name:";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabHome);
            this.tabMain.Controls.Add(this.tabHelp);
            this.tabMain.Controls.Add(this.tabContact);
            this.tabMain.Controls.Add(this.tabAccount);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(966, 1050);
            this.tabMain.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.AutoScroll = true;
            this.tabHome.Controls.Add(this.pictureBox1);
            this.tabHome.Controls.Add(this.lblHeader);
            this.tabHome.Controls.Add(this.btnAccount);
            this.tabHome.Controls.Add(this.btnContact);
            this.tabHome.Controls.Add(this.btnHelp);
            this.tabHome.Controls.Add(this.lvwNews);
            this.tabHome.Controls.Add(this.lblAbout);
            this.tabHome.Location = new System.Drawing.Point(4, 29);
            this.tabHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHome.Size = new System.Drawing.Size(958, 1017);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 297);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Maroon;
            this.lblHeader.Location = new System.Drawing.Point(12, 21);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(858, 49);
            this.lblHeader.TabIndex = 17;
            this.lblHeader.Text = "label2";
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(776, 953);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(130, 35);
            this.btnAccount.TabIndex = 15;
            this.btnAccount.Text = "My &Account";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnGoToAccount_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(616, 953);
            this.btnContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(135, 35);
            this.btnContact.TabIndex = 14;
            this.btnContact.Text = "C&ontact Us";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(353, 953);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(237, 35);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "&Help and Information";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lvwNews
            // 
            this.lvwNews.BackColor = System.Drawing.Color.SkyBlue;
            this.lvwNews.CheckBoxes = true;
            this.lvwNews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvwNews.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwNews.Location = new System.Drawing.Point(64, 709);
            this.lvwNews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwNews.MultiSelect = false;
            this.lvwNews.Name = "lvwNews";
            this.lvwNews.Size = new System.Drawing.Size(854, 212);
            this.lvwNews.TabIndex = 10;
            this.lvwNews.UseCompatibleStateImageBehavior = false;
            this.lvwNews.View = System.Windows.Forms.View.Details;
            this.lvwNews.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwNews_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tax News";
            this.columnHeader1.Width = 563;
            // 
            // lblAbout
            // 
            this.lblAbout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAbout.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.MintCream;
            this.lblAbout.Location = new System.Drawing.Point(64, 397);
            this.lblAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(854, 253);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.lvwHelp);
            this.tabHelp.Controls.Add(this.lvwIRS);
            this.tabHelp.Controls.Add(this.btnContinue);
            this.tabHelp.Controls.Add(this.label7);
            this.tabHelp.Controls.Add(this.label6);
            this.tabHelp.Location = new System.Drawing.Point(4, 29);
            this.tabHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHelp.Size = new System.Drawing.Size(958, 1017);
            this.tabHelp.TabIndex = 1;
            this.tabHelp.Text = "Help and Information";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // lvwHelp
            // 
            this.lvwHelp.BackColor = System.Drawing.Color.SkyBlue;
            this.lvwHelp.CheckBoxes = true;
            this.lvwHelp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.lvwHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHelp.Location = new System.Drawing.Point(57, 366);
            this.lvwHelp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwHelp.Name = "lvwHelp";
            this.lvwHelp.Size = new System.Drawing.Size(757, 276);
            this.lvwHelp.TabIndex = 10;
            this.lvwHelp.UseCompatibleStateImageBehavior = false;
            this.lvwHelp.View = System.Windows.Forms.View.Details;
            this.lvwHelp.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwHelp_ItemChecked);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Category";
            this.columnHeader7.Width = 395;
            // 
            // lvwIRS
            // 
            this.lvwIRS.BackColor = System.Drawing.Color.SkyBlue;
            this.lvwIRS.CheckBoxes = true;
            this.lvwIRS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4});
            this.lvwIRS.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwIRS.Location = new System.Drawing.Point(57, 80);
            this.lvwIRS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwIRS.MultiSelect = false;
            this.lvwIRS.Name = "lvwIRS";
            this.lvwIRS.Size = new System.Drawing.Size(757, 213);
            this.lvwIRS.TabIndex = 9;
            this.lvwIRS.UseCompatibleStateImageBehavior = false;
            this.lvwIRS.View = System.Windows.Forms.View.Details;
            this.lvwIRS.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvwIRS_ItemChecked);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Topic";
            this.columnHeader4.Width = 501;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(508, 671);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(308, 55);
            this.btnContinue.TabIndex = 8;
            this.btnContinue.Text = "&Continue to Payroll Tax Application";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnGoToAccount_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 322);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Helpful Links";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "IRS Instructions";
            // 
            // tabContact
            // 
            this.tabContact.BackColor = System.Drawing.SystemColors.Control;
            this.tabContact.Controls.Add(this.groupBox2);
            this.tabContact.Controls.Add(this.groupBox1);
            this.tabContact.Location = new System.Drawing.Point(4, 29);
            this.tabContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabContact.Name = "tabContact";
            this.tabContact.Size = new System.Drawing.Size(958, 1017);
            this.tabContact.TabIndex = 3;
            this.tabContact.Text = "Contact Us";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(commentsLabel);
            this.groupBox2.Controls.Add(this.txtComments);
            this.groupBox2.Controls.Add(emailLabel);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(user_NameLabel);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(68, 326);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(756, 440);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Feedback";
            // 
            // txtComments
            // 
            this.txtComments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComments.Location = new System.Drawing.Point(280, 202);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(402, 182);
            this.txtComments.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(280, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(402, 42);
            this.txtEmail.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(280, 66);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(402, 42);
            this.txtName.TabIndex = 15;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(514, 395);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(170, 35);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(68, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(756, 232);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Us";
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(164, 143);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(330, 85);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "lblAddr";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(164, 103);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(496, 40);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "lblPhone";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(164, 52);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(496, 40);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "lblEmail";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(60, 62);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 25);
            this.label14.TabIndex = 0;
            this.label14.Text = "Email: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(60, 160);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 25);
            this.label17.TabIndex = 4;
            this.label17.Text = "Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(60, 109);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 25);
            this.label15.TabIndex = 2;
            this.label15.Text = "Phone:";
            // 
            // tabAccount
            // 
            this.tabAccount.Controls.Add(this.label3);
            this.tabAccount.Controls.Add(this.label2);
            this.tabAccount.Controls.Add(this.label1);
            this.tabAccount.Controls.Add(this.txtPassword);
            this.tabAccount.Controls.Add(this.txtUserName);
            this.tabAccount.Controls.Add(this.btnLogin);
            this.tabAccount.Controls.Add(this.btnLoginAsGuest);
            this.tabAccount.Controls.Add(this.btnSignUp);
            this.tabAccount.Location = new System.Drawing.Point(4, 29);
            this.tabAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(958, 1017);
            this.tabAccount.TabIndex = 2;
            this.tabAccount.Text = "My Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Login  in PayRoll Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(404, 195);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(343, 26);
            this.txtPassword.TabIndex = 18;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(404, 134);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(343, 26);
            this.txtUserName.TabIndex = 17;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(627, 278);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 35);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "&Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLoginAsGuest
            // 
            this.btnLoginAsGuest.Location = new System.Drawing.Point(214, 275);
            this.btnLoginAsGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoginAsGuest.Name = "btnLoginAsGuest";
            this.btnLoginAsGuest.Size = new System.Drawing.Size(140, 38);
            this.btnLoginAsGuest.TabIndex = 13;
            this.btnLoginAsGuest.Text = "Enter as &Guest";
            this.btnLoginAsGuest.UseVisualStyleBackColor = true;
            this.btnLoginAsGuest.Click += new System.EventHandler(this.btnLoginAsGuest_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(423, 278);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(140, 35);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Sign &Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // taxUsersDataSet
            // 
            this.taxUsersDataSet.DataSetName = "TaxUsersDataSet";
            this.taxUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFeedbackBindingSource
            // 
            this.tblFeedbackBindingSource.DataMember = "tblFeedback";
            this.tblFeedbackBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // tblFeedbackTableAdapter
            // 
            this.tblFeedbackTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblFederalRatesTableAdapter = null;
            this.tableAdapterManager.tblFederalWHTableAdapter = null;
            this.tableAdapterManager.tblFeedbackTableAdapter = this.tblFeedbackTableAdapter;
            this.tableAdapterManager.tblSalaryTableAdapter = null;
            this.tableAdapterManager.tblStateWHTableAdapter = null;
            this.tableAdapterManager.tblSUTARatesTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 1050);
            this.Controls.Add(this.tabMain);
            this.Name = "Main_Form";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Frm_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabHelp.ResumeLayout(false);
            this.tabHelp.PerformLayout();
            this.tabContact.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabAccount.ResumeLayout(false);
            this.tabAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.ListView lvwNews;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.ListView lvwHelp;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvwIRS;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabContact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginAsGuest;
        private System.Windows.Forms.Button btnSignUp;
        private TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblFeedbackBindingSource;
        private TaxUsersDataSetTableAdapters.tblFeedbackTableAdapter tblFeedbackTableAdapter;
        private TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private TaxUsersDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}