namespace Payroll_Tax_Application
{
    partial class Form_ConfirmProfile
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
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkNevada = new System.Windows.Forms.CheckBox();
            this.chkArizona = new System.Windows.Forms.CheckBox();
            this.chkUtah = new System.Windows.Forms.CheckBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblConfirmProfile = new System.Windows.Forms.Label();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            this.tblUsersTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblUsersTableAdapter();
            this.tblUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(44, 95);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Employee Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(44, 162);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(198, 25);
            this.label22.TabIndex = 3;
            this.label22.Text = "States of Employment:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(44, 228);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 25);
            this.label21.TabIndex = 2;
            this.label21.Text = "Marital Status:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(252, 91);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 36);
            this.txtName.TabIndex = 4;
            // 
            // chkNevada
            // 
            this.chkNevada.AutoSize = true;
            this.chkNevada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNevada.Location = new System.Drawing.Point(342, 162);
            this.chkNevada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNevada.Name = "chkNevada";
            this.chkNevada.Size = new System.Drawing.Size(64, 29);
            this.chkNevada.TabIndex = 7;
            this.chkNevada.Text = "NV";
            this.chkNevada.UseVisualStyleBackColor = true;
            this.chkNevada.CheckedChanged += new System.EventHandler(this.input_SelectionChanged);
            // 
            // chkArizona
            // 
            this.chkArizona.AutoSize = true;
            this.chkArizona.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArizona.Location = new System.Drawing.Point(255, 162);
            this.chkArizona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkArizona.Name = "chkArizona";
            this.chkArizona.Size = new System.Drawing.Size(61, 29);
            this.chkArizona.TabIndex = 5;
            this.chkArizona.Text = "AZ";
            this.chkArizona.UseVisualStyleBackColor = true;
            this.chkArizona.CheckedChanged += new System.EventHandler(this.input_SelectionChanged);
            // 
            // chkUtah
            // 
            this.chkUtah.AutoSize = true;
            this.chkUtah.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUtah.Location = new System.Drawing.Point(432, 162);
            this.chkUtah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkUtah.Name = "chkUtah";
            this.chkUtah.Size = new System.Drawing.Size(61, 29);
            this.chkUtah.TabIndex = 6;
            this.chkUtah.Text = "UT";
            this.chkUtah.UseVisualStyleBackColor = true;
            this.chkUtah.CheckedChanged += new System.EventHandler(this.input_SelectionChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(430, 283);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(135, 46);
            this.btnContinue.TabIndex = 13;
            this.btnContinue.Text = "&Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblConfirmProfile
            // 
            this.lblConfirmProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmProfile.Location = new System.Drawing.Point(42, 29);
            this.lblConfirmProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmProfile.Name = "lblConfirmProfile";
            this.lblConfirmProfile.Size = new System.Drawing.Size(524, 43);
            this.lblConfirmProfile.TabIndex = 14;
            this.lblConfirmProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMarried.Location = new System.Drawing.Point(362, 223);
            this.rdbMarried.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(103, 29);
            this.rdbMarried.TabIndex = 16;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSingle.Location = new System.Drawing.Point(252, 223);
            this.rdbSingle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(89, 29);
            this.rdbSingle.TabIndex = 15;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single";
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
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsersBindingSource1
            // 
            this.tblUsersBindingSource1.DataMember = "tblUsers";
            // 
            // taxUsersDataSet
            // 
            this.taxUsersDataSet.DataSetName = "TaxUsersDataSet";
            this.taxUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form_ConfirmProfile
            // 
            this.AcceptButton = this.btnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(650, 382);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.chkNevada);
            this.Controls.Add(this.chkArizona);
            this.Controls.Add(this.rdbMarried);
            this.Controls.Add(this.chkUtah);
            this.Controls.Add(this.rdbSingle);
            this.Controls.Add(this.lblConfirmProfile);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_ConfirmProfile";
            this.Text = "Employee Status Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ConfirmProfile_FormClosing);
            this.Load += new System.EventHandler(this.frmConfirmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkNevada;
        private System.Windows.Forms.CheckBox chkArizona;
        private System.Windows.Forms.CheckBox chkUtah;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblConfirmProfile;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.RadioButton rdbSingle;
   
      
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.BindingSource tblUsersBindingSource1;
        private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
    }
}