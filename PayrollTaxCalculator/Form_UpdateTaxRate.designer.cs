namespace TaxPayrollPay
{
    partial class updateTaxRateForm
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
            this.btnLoadIRS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnArizonastateTax = new System.Windows.Forms.Button();
            this.btnUpdateStateTax = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNevedastateTax = new System.Windows.Forms.Button();
            this.lblFICARate = new System.Windows.Forms.Label();
            this.lblFUTARate = new System.Windows.Forms.Label();
            this.lblMedicareRate = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblFederalRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFederalRatesTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalRatesTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalRatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadIRS
            // 
            this.btnLoadIRS.Location = new System.Drawing.Point(422, 295);
            this.btnLoadIRS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadIRS.Name = "btnLoadIRS";
            this.btnLoadIRS.Size = new System.Drawing.Size(201, 32);
            this.btnLoadIRS.TabIndex = 3;
            this.btnLoadIRS.Text = "&Load New IRS Table";
            this.btnLoadIRS.UseVisualStyleBackColor = true;
            this.btnLoadIRS.Click += new System.EventHandler(this.btnLoadIRS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Federal Withholding Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Federal Tax Rates";
            // 
            // btnArizonastateTax
            // 
            this.btnArizonastateTax.Location = new System.Drawing.Point(69, 362);
            this.btnArizonastateTax.Name = "btnArizonastateTax";
            this.btnArizonastateTax.Size = new System.Drawing.Size(554, 52);
            this.btnArizonastateTax.TabIndex = 4;
            this.btnArizonastateTax.Text = "Update &Arizona State Tax";
            this.btnArizonastateTax.UseVisualStyleBackColor = true;
            this.btnArizonastateTax.Click += new System.EventHandler(this.btnArizonastateTax_Click);
            // 
            // btnUpdateStateTax
            // 
            this.btnUpdateStateTax.Location = new System.Drawing.Point(68, 448);
            this.btnUpdateStateTax.Name = "btnUpdateStateTax";
            this.btnUpdateStateTax.Size = new System.Drawing.Size(554, 52);
            this.btnUpdateStateTax.TabIndex = 5;
            this.btnUpdateStateTax.Text = "Update &Utah State Tax";
            this.btnUpdateStateTax.UseVisualStyleBackColor = true;
            this.btnUpdateStateTax.Click += new System.EventHandler(this.btnUpdateStateTax_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(342, 634);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "FICA_Medicare Rates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "FUTA(Federal Unemployement)Rates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "FICA (Social Security) Rate:";
            // 
            // btnNevedastateTax
            // 
            this.btnNevedastateTax.Location = new System.Drawing.Point(69, 532);
            this.btnNevedastateTax.Name = "btnNevedastateTax";
            this.btnNevedastateTax.Size = new System.Drawing.Size(554, 52);
            this.btnNevedastateTax.TabIndex = 6;
            this.btnNevedastateTax.Text = "Update &Nevada Tax Rate";
            this.btnNevedastateTax.UseVisualStyleBackColor = true;
            this.btnNevedastateTax.Click += new System.EventHandler(this.btnNevedastateTax_Click);
            // 
            // lblFICARate
            // 
            this.lblFICARate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFICARate.Location = new System.Drawing.Point(422, 131);
            this.lblFICARate.Name = "lblFICARate";
            this.lblFICARate.Size = new System.Drawing.Size(202, 31);
            this.lblFICARate.TabIndex = 0;
            this.lblFICARate.Click += new System.EventHandler(this.lblFICARate_Click);
            // 
            // lblFUTARate
            // 
            this.lblFUTARate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFUTARate.Location = new System.Drawing.Point(422, 188);
            this.lblFUTARate.Name = "lblFUTARate";
            this.lblFUTARate.Size = new System.Drawing.Size(202, 31);
            this.lblFUTARate.TabIndex = 1;
            this.lblFUTARate.Click += new System.EventHandler(this.lblFUTARate_Click);
            // 
            // lblMedicareRate
            // 
            this.lblMedicareRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMedicareRate.Location = new System.Drawing.Point(422, 242);
            this.lblMedicareRate.Name = "lblMedicareRate";
            this.lblMedicareRate.Size = new System.Drawing.Size(202, 31);
            this.lblMedicareRate.TabIndex = 2;
            this.lblMedicareRate.Click += new System.EventHandler(this.lblMedicareRate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(505, 634);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 35);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // taxUsersDataSet
            // 
            this.taxUsersDataSet.DataSetName = "TaxUsersDataSet";
            this.taxUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFederalRatesBindingSource
            // 
            this.tblFederalRatesBindingSource.DataMember = "tblFederalRates";
            this.tblFederalRatesBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // tblFederalRatesTableAdapter
            // 
            this.tblFederalRatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblFederalRatesTableAdapter = this.tblFederalRatesTableAdapter;
            this.tableAdapterManager.tblFederalWHTableAdapter = null;
            this.tableAdapterManager.tblFeedbackTableAdapter = null;
            this.tableAdapterManager.tblSalaryTableAdapter = null;
            this.tableAdapterManager.tblStateWHTableAdapter = null;
            this.tableAdapterManager.tblSUTARatesTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // updateTaxRateForm
            // 
            this.AcceptButton = this.btnRefresh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 694);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblMedicareRate);
            this.Controls.Add(this.lblFUTARate);
            this.Controls.Add(this.lblFICARate);
            this.Controls.Add(this.btnNevedastateTax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdateStateTax);
            this.Controls.Add(this.btnArizonastateTax);
            this.Controls.Add(this.btnLoadIRS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "updateTaxRateForm";
            this.Text = "Update Tax Rate Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.updateTaxRateForm_FormClosing);
            this.Load += new System.EventHandler(this.updateTaxRateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalRatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadIRS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArizonastateTax;
        private System.Windows.Forms.Button btnUpdateStateTax;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
     
        private System.Windows.Forms.Button btnNevedastateTax;
           private System.Windows.Forms.Label lblFICARate;
        private System.Windows.Forms.Label lblFUTARate;
        private System.Windows.Forms.Label lblMedicareRate;
        private System.Windows.Forms.Button btnRefresh;
        private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblFederalRatesBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalRatesTableAdapter tblFederalRatesTableAdapter;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}