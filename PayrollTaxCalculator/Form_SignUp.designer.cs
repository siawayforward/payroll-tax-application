namespace SignUp_Form
{
    partial class Form_SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.chkArizona = new System.Windows.Forms.CheckBox();
            this.chkNevada = new System.Windows.Forms.CheckBox();
            this.chkUtah = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.gbxMarital = new System.Windows.Forms.GroupBox();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblUsersTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            this.gbxMarital.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "New Account Set Up:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Create Username:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Create Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 149);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(281, 26);
            this.txtName.TabIndex = 0;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(212, 315);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(281, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(212, 202);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 26);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(212, 258);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(281, 26);
            this.txtUserName.TabIndex = 2;
            // 
            // chkArizona
            // 
            this.chkArizona.AutoSize = true;
            this.chkArizona.Location = new System.Drawing.Point(40, 41);
            this.chkArizona.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkArizona.Name = "chkArizona";
            this.chkArizona.Size = new System.Drawing.Size(56, 24);
            this.chkArizona.TabIndex = 0;
            this.chkArizona.Text = "AZ";
            this.chkArizona.UseVisualStyleBackColor = true;
            this.chkArizona.CheckedChanged += new System.EventHandler(this.chkArizona_CheckedChanged);
            // 
            // chkNevada
            // 
            this.chkNevada.AutoSize = true;
            this.chkNevada.Location = new System.Drawing.Point(129, 41);
            this.chkNevada.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkNevada.Name = "chkNevada";
            this.chkNevada.Size = new System.Drawing.Size(57, 24);
            this.chkNevada.TabIndex = 1;
            this.chkNevada.Text = "NV";
            this.chkNevada.UseVisualStyleBackColor = true;
            this.chkNevada.CheckedChanged += new System.EventHandler(this.chkArizona_CheckedChanged);
            // 
            // chkUtah
            // 
            this.chkUtah.AutoSize = true;
            this.chkUtah.Location = new System.Drawing.Point(241, 41);
            this.chkUtah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkUtah.Name = "chkUtah";
            this.chkUtah.Size = new System.Drawing.Size(56, 24);
            this.chkUtah.TabIndex = 2;
            this.chkUtah.Text = "UT";
            this.chkUtah.UseVisualStyleBackColor = true;
            this.chkUtah.CheckedChanged += new System.EventHandler(this.chkArizona_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(778, 382);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(123, 41);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "&Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // gbxMarital
            // 
            this.gbxMarital.Controls.Add(this.rdbMarried);
            this.gbxMarital.Controls.Add(this.rdbSingle);
            this.gbxMarital.Location = new System.Drawing.Point(542, 138);
            this.gbxMarital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxMarital.Name = "gbxMarital";
            this.gbxMarital.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxMarital.Size = new System.Drawing.Size(359, 78);
            this.gbxMarital.TabIndex = 5;
            this.gbxMarital.TabStop = false;
            this.gbxMarital.Text = "Marital Status:";
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(187, 32);
            this.rdbMarried.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(87, 24);
            this.rdbMarried.TabIndex = 1;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            this.rdbMarried.CheckedChanged += new System.EventHandler(this.maritalStateChangedTask);
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(29, 32);
            this.rdbSingle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(78, 24);
            this.rdbSingle.TabIndex = 0;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            this.rdbSingle.CheckedChanged += new System.EventHandler(this.maritalStateChangedTask);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm Password:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(212, 365);
            this.txtConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirm.MaxLength = 8;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(281, 26);
            this.txtConfirm.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkArizona);
            this.groupBox1.Controls.Add(this.chkNevada);
            this.groupBox1.Controls.Add(this.chkUtah);
            this.groupBox1.Location = new System.Drawing.Point(542, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(359, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State(s) where You worked";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(603, 382);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 41);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // taxUsersDataSet
            // 
            this.taxUsersDataSet.DataSetName = "TaxUsersDataSet";
            this.taxUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblFederalRatesTableAdapter = null;
            this.tableAdapterManager.tblFederalWHTableAdapter = null;
            this.tableAdapterManager.tblFeedbackTableAdapter = null;
            this.tableAdapterManager.tblSalaryTableAdapter = null;
            this.tableAdapterManager.tblStateWHTableAdapter = null;
            this.tableAdapterManager.tblSUTARatesTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = this.tblUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form_SignUp
            // 
            this.AcceptButton = this.btnSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 644);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbxMarital);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_SignUp";
            this.Text = "Form Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SignUp_FormClosing);
            this.Load += new System.EventHandler(this.Form_SignUp_Load);
            this.gbxMarital.ResumeLayout(false);
            this.gbxMarital.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.CheckBox chkArizona;
        private System.Windows.Forms.CheckBox chkNevada;
        private System.Windows.Forms.CheckBox chkUtah;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.GroupBox gbxMarital;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
       
        private System.Windows.Forms.Button btnBack;
        private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

