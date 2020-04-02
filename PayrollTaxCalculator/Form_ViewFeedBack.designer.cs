namespace TaxPayrollPay
{
    partial class viewFeedBackForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblFeedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFeedbackTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFeedbackTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            this.tblFeedbackDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeedbackDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(709, 474);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 37);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(115, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.txtDeleteID);
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.label4);
            this.grpDelete.Location = new System.Drawing.Point(70, 357);
            this.grpDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDelete.Size = new System.Drawing.Size(257, 154);
            this.grpDelete.TabIndex = 4;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete FeedBack";
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.Location = new System.Drawing.Point(91, 51);
            this.txtDeleteID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(115, 26);
            this.txtDeleteID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
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
            // tblFeedbackDataGridView
            // 
            this.tblFeedbackDataGridView.AutoGenerateColumns = false;
            this.tblFeedbackDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFeedbackDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFeedbackDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tblFeedbackDataGridView.DataSource = this.tblFeedbackBindingSource;
            this.tblFeedbackDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblFeedbackDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tblFeedbackDataGridView.Name = "tblFeedbackDataGridView";
            this.tblFeedbackDataGridView.RowTemplate.Height = 28;
            this.tblFeedbackDataGridView.Size = new System.Drawing.Size(914, 324);
            this.tblFeedbackDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "User_Name";
            this.dataGridViewTextBoxColumn7.HeaderText = "User_Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "Email";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn9.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Cmt_Date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Cmt_Date";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // viewFeedBackForm
            // 
            this.AcceptButton = this.btnDelete;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 552);
            this.Controls.Add(this.tblFeedbackDataGridView);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.btnBack);
            this.Name = "viewFeedBackForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.viewFeedBackForm_FormClosing);
            this.Load += new System.EventHandler(this.viewFeedBackForm_Load);
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFeedbackDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
  
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblFeedbackBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFeedbackTableAdapter tblFeedbackTableAdapter;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblFeedbackDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}