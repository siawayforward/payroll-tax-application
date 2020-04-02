namespace TaxPayrollPay
{
    partial class Update_Federal_Tax_Dialog_frm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblFederalRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFederalRatesTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalRatesTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalRatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(157, 60);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 20);
            this.lblTitle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(260, 150);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(166, 26);
            this.txtRate.TabIndex = 0;
            this.txtRate.Enter += new System.EventHandler(this.txtRate_Enter);
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRate_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(301, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 42);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // Update_Federal_Tax_Dialog_frm
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 331);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Update_Federal_Tax_Dialog_frm";
            this.Text = "Update_Federal_Tax_Dialog_frm";
            this.Load += new System.EventHandler(this.Update_Federal_Tax_Dialog_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalRatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnUpdate;
        private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblFederalRatesBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalRatesTableAdapter tblFederalRatesTableAdapter;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}