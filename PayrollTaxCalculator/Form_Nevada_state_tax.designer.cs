namespace TaxPayrollPay
{
    partial class NevadaStateTax
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
            this.txtSutaRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.txtWithholdingRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblSUTARatesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSUTARatesTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblSUTARatesTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            this.tblStateWHTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblStateWHTableAdapter();
            this.tblStateWHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSUTARatesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateWHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSutaRate
            // 
            this.txtSutaRate.Location = new System.Drawing.Point(302, 242);
            this.txtSutaRate.Name = "txtSutaRate";
            this.txtSutaRate.Size = new System.Drawing.Size(276, 26);
            this.txtSutaRate.TabIndex = 42;
            this.txtSutaRate.Enter += new System.EventHandler(this.SelectAllMethod);
            this.txtSutaRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cancelKey);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "SUTA Rate";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(477, 320);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 40);
            this.btnUpdate.TabIndex = 40;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nevada State Tax Rate";
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(478, 194);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(87, 24);
            this.rdbMarried.TabIndex = 38;
            this.rdbMarried.Text = "&Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            this.rdbMarried.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Checked = true;
            this.rdbSingle.Location = new System.Drawing.Point(302, 194);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(78, 24);
            this.rdbSingle.TabIndex = 37;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "&Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            this.rdbSingle.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // txtWithholdingRate
            // 
            this.txtWithholdingRate.Location = new System.Drawing.Point(302, 128);
            this.txtWithholdingRate.Name = "txtWithholdingRate";
            this.txtWithholdingRate.Size = new System.Drawing.Size(276, 26);
            this.txtWithholdingRate.TabIndex = 36;
            this.txtWithholdingRate.Enter += new System.EventHandler(this.SelectAllMethod);
            this.txtWithholdingRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cancelKey);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Marital Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "State With Holding Rate";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(310, 320);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 40);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // taxUsersDataSet
            // 
            this.taxUsersDataSet.DataSetName = "TaxUsersDataSet";
            this.taxUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSUTARatesBindingSource1
            // 
            this.tblSUTARatesBindingSource1.DataMember = "tblSUTARates";
            this.tblSUTARatesBindingSource1.DataSource = this.taxUsersDataSet;
            // 
            // tblSUTARatesTableAdapter
            // 
            this.tblSUTARatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblFederalRatesTableAdapter = null;
            this.tableAdapterManager.tblFederalWHTableAdapter = null;
            this.tableAdapterManager.tblFeedbackTableAdapter = null;
            this.tableAdapterManager.tblSalaryTableAdapter = null;
            this.tableAdapterManager.tblStateWHTableAdapter = this.tblStateWHTableAdapter;
            this.tableAdapterManager.tblSUTARatesTableAdapter = this.tblSUTARatesTableAdapter;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblStateWHTableAdapter
            // 
            this.tblStateWHTableAdapter.ClearBeforeFill = true;
            // 
            // tblStateWHBindingSource
            // 
            this.tblStateWHBindingSource.DataMember = "tblStateWH";
            this.tblStateWHBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // NevadaStateTax
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 398);
            this.Controls.Add(this.txtSutaRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbMarried);
            this.Controls.Add(this.rdbSingle);
            this.Controls.Add(this.txtWithholdingRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Name = "NevadaStateTax";
            this.Text = "NevadaStateTax";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NevadaStateTax_FormClosing);
            this.Load += new System.EventHandler(this.NevadaStateTax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSUTARatesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateWHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSutaRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.TextBox txtWithholdingRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
     
        private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblSUTARatesBindingSource1;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblSUTARatesTableAdapter tblSUTARatesTableAdapter;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblStateWHTableAdapter tblStateWHTableAdapter;
        private System.Windows.Forms.BindingSource tblStateWHBindingSource;
    }
}