namespace Payroll_Tax_Application
{
    partial class Form_Review
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
            this.label = new System.Windows.Forms.Label();
            this.lblReviewPage = new System.Windows.Forms.Label();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.lvwSummary = new System.Windows.Forms.ListView();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ExportSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.lblStateDetails = new System.Windows.Forms.Label();
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSalaryTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblSalaryTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(18, 14);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(436, 43);
            this.label.TabIndex = 15;
            this.label.Text = "Review && Confirmation:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReviewPage
            // 
            this.lblReviewPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewPage.Location = new System.Drawing.Point(18, 57);
            this.lblReviewPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReviewPage.Name = "lblReviewPage";
            this.lblReviewPage.Size = new System.Drawing.Size(724, 58);
            this.lblReviewPage.TabIndex = 16;
            this.lblReviewPage.Text = "lblNote";
            this.lblReviewPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDetails.Location = new System.Drawing.Point(18, 115);
            this.lblUserDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(216, 106);
            this.lblUserDetails.TabIndex = 18;
            // 
            // lvwSummary
            // 
            this.lvwSummary.BackColor = System.Drawing.Color.Ivory;
            this.lvwSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSummary.Location = new System.Drawing.Point(16, 231);
            this.lvwSummary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwSummary.Name = "lvwSummary";
            this.lvwSummary.Size = new System.Drawing.Size(724, 581);
            this.lvwSummary.TabIndex = 20;
            this.lvwSummary.UseCompatibleStateImageBehavior = false;
            this.lvwSummary.View = System.Windows.Forms.View.Details;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(586, 949);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(154, 46);
            this.btnDownload.TabIndex = 22;
            this.btnDownload.Text = "&Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(399, 949);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 46);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ExportSaveDialog
            // 
            this.ExportSaveDialog.FileName = "Payroll Tax Detail";
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisclaimer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.Location = new System.Drawing.Point(16, 818);
            this.lblDisclaimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(726, 122);
            this.lblDisclaimer.TabIndex = 24;
            // 
            // lblStateDetails
            // 
            this.lblStateDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStateDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateDetails.Location = new System.Drawing.Point(243, 115);
            this.lblStateDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStateDetails.Name = "lblStateDetails";
            this.lblStateDetails.Size = new System.Drawing.Size(498, 106);
            this.lblStateDetails.TabIndex = 25;
            // 
            // taxUsersDataSet
            // 
            this.taxUsersDataSet.DataSetName = "TaxUsersDataSet";
            this.taxUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSalaryBindingSource
            // 
            this.tblSalaryBindingSource.DataMember = "tblSalary";
            this.tblSalaryBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // tblSalaryTableAdapter
            // 
            this.tblSalaryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblFederalRatesTableAdapter = null;
            this.tableAdapterManager.tblFederalWHTableAdapter = null;
            this.tableAdapterManager.tblFeedbackTableAdapter = null;
            this.tableAdapterManager.tblSalaryTableAdapter = this.tblSalaryTableAdapter;
            this.tableAdapterManager.tblStateWHTableAdapter = null;
            this.tableAdapterManager.tblSUTARatesTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(219, 949);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(154, 46);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "&Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form_Review
            // 
            this.AcceptButton = this.btnDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(759, 1009);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblStateDetails);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lvwSummary);
            this.Controls.Add(this.lblUserDetails);
            this.Controls.Add(this.lblReviewPage);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Review";
            this.Text = "Payroll Tax Review Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Review_FormClosing);
            this.Load += new System.EventHandler(this.Form_Review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblReviewPage;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.ListView lvwSummary;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSave;
         private System.Windows.Forms.SaveFileDialog ExportSaveDialog;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.Label lblStateDetails;
        private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblSalaryBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblSalaryTableAdapter tblSalaryTableAdapter;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnLogout;
    }
}