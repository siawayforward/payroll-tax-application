namespace TaxPayrollPay
{
    partial class Federal_Witholding_Rates_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPctWH = new System.Windows.Forms.TextBox();
            this.txtWithholding = new System.Windows.Forms.TextBox();
            this.txtHighBound = new System.Windows.Forms.TextBox();
            this.txtaddLowBound = new System.Windows.Forms.TextBox();
            this.txtaddPeriod = new System.Windows.Forms.TextBox();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.txtLowbound = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblFederalWHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFederalWHTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalWHTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            this.tblFederalWHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdelHighBound = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalWHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalWHDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPctWH);
            this.groupBox1.Controls.Add(this.txtWithholding);
            this.groupBox1.Controls.Add(this.txtHighBound);
            this.groupBox1.Controls.Add(this.txtaddLowBound);
            this.groupBox1.Controls.Add(this.txtaddPeriod);
            this.groupBox1.Controls.Add(this.rdbMarried);
            this.groupBox1.Controls.Add(this.rdbSingle);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(39, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 370);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(357, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPctWH
            // 
            this.txtPctWH.Location = new System.Drawing.Point(169, 267);
            this.txtPctWH.Name = "txtPctWH";
            this.txtPctWH.Size = new System.Drawing.Size(329, 26);
            this.txtPctWH.TabIndex = 6;
            this.txtPctWH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelKey);
            // 
            // txtWithholding
            // 
            this.txtWithholding.Location = new System.Drawing.Point(169, 227);
            this.txtWithholding.Name = "txtWithholding";
            this.txtWithholding.Size = new System.Drawing.Size(329, 26);
            this.txtWithholding.TabIndex = 5;
            this.txtWithholding.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelKey);
            // 
            // txtHighBound
            // 
            this.txtHighBound.Location = new System.Drawing.Point(169, 186);
            this.txtHighBound.Name = "txtHighBound";
            this.txtHighBound.Size = new System.Drawing.Size(329, 26);
            this.txtHighBound.TabIndex = 4;
            this.txtHighBound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelKey);
            // 
            // txtaddLowBound
            // 
            this.txtaddLowBound.Location = new System.Drawing.Point(169, 142);
            this.txtaddLowBound.Name = "txtaddLowBound";
            this.txtaddLowBound.Size = new System.Drawing.Size(329, 26);
            this.txtaddLowBound.TabIndex = 3;
            this.txtaddLowBound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelKey);
            // 
            // txtaddPeriod
            // 
            this.txtaddPeriod.Location = new System.Drawing.Point(169, 97);
            this.txtaddPeriod.Name = "txtaddPeriod";
            this.txtaddPeriod.Size = new System.Drawing.Size(329, 26);
            this.txtaddPeriod.TabIndex = 2;
            this.txtaddPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriod_KeyPress);
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(357, 48);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(87, 24);
            this.rdbMarried.TabIndex = 1;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "&Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            this.rdbMarried.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(169, 48);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(78, 24);
            this.rdbSingle.TabIndex = 0;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "&Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            this.rdbSingle.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "PctWH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Withholding Amount";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "High bound";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Low Bound";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Period";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marital Status";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(904, 792);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(67, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "* \'S\' denotes Single and \'M\' denotes married";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(71, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "*\'B\' denotes BI-Weekly and \'A\' denotes annually";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Low bound Income";
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.txtdelHighBound);
            this.grpDelete.Controls.Add(this.label11);
            this.grpDelete.Controls.Add(this.txtLowbound);
            this.grpDelete.Controls.Add(this.txtPeriod);
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.label4);
            this.grpDelete.Controls.Add(this.label3);
            this.grpDelete.Location = new System.Drawing.Point(636, 470);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(363, 257);
            this.grpDelete.TabIndex = 0;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete";
            // 
            // txtLowbound
            // 
            this.txtLowbound.Location = new System.Drawing.Point(174, 87);
            this.txtLowbound.Name = "txtLowbound";
            this.txtLowbound.Size = new System.Drawing.Size(149, 26);
            this.txtLowbound.TabIndex = 1;
            this.txtLowbound.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CancelKey);
            // 
            // txtPeriod
            // 
            this.txtPeriod.Location = new System.Drawing.Point(174, 35);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(149, 26);
            this.txtPeriod.TabIndex = 0;
            this.txtPeriod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeriod_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(232, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // taxUsersDataSet
            // 
            this.taxUsersDataSet.DataSetName = "TaxUsersDataSet";
            this.taxUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFederalWHBindingSource
            // 
            this.tblFederalWHBindingSource.DataMember = "tblFederalWH";
            this.tblFederalWHBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // tblFederalWHTableAdapter
            // 
            this.tblFederalWHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblFederalRatesTableAdapter = null;
            this.tableAdapterManager.tblFederalWHTableAdapter = this.tblFederalWHTableAdapter;
            this.tableAdapterManager.tblFeedbackTableAdapter = null;
            this.tableAdapterManager.tblSalaryTableAdapter = null;
            this.tableAdapterManager.tblStateWHTableAdapter = null;
            this.tableAdapterManager.tblSUTARatesTableAdapter = null;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblFederalWHDataGridView
            // 
            this.tblFederalWHDataGridView.AutoGenerateColumns = false;
            this.tblFederalWHDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblFederalWHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFederalWHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.tblFederalWHDataGridView.DataSource = this.tblFederalWHBindingSource;
            this.tblFederalWHDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblFederalWHDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tblFederalWHDataGridView.Name = "tblFederalWHDataGridView";
            this.tblFederalWHDataGridView.RowTemplate.Height = 28;
            this.tblFederalWHDataGridView.Size = new System.Drawing.Size(1064, 368);
            this.tblFederalWHDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MaritalStatus";
            this.dataGridViewTextBoxColumn9.HeaderText = "MaritalStatus";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Period";
            this.dataGridViewTextBoxColumn10.HeaderText = "Period";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Low_Bound";
            this.dataGridViewTextBoxColumn11.HeaderText = "Low_Bound";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "High_Bound";
            this.dataGridViewTextBoxColumn12.HeaderText = "High_Bound";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "WH_Amount";
            this.dataGridViewTextBoxColumn13.HeaderText = "WH_Amount";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Additional PctWH";
            this.dataGridViewTextBoxColumn14.HeaderText = "Additional PctWH";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // txtdelHighBound
            // 
            this.txtdelHighBound.Location = new System.Drawing.Point(174, 129);
            this.txtdelHighBound.Name = "txtdelHighBound";
            this.txtdelHighBound.Size = new System.Drawing.Size(149, 26);
            this.txtdelHighBound.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "High bound Income";
            // 
            // Federal_Witholding_Rates_Form
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 881);
            this.Controls.Add(this.tblFederalWHDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Name = "Federal_Witholding_Rates_Form";
            this.Text = "Federal_Witholding_Rates_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Federal_Witholding_Rates_Form_FormClosing);
            this.Load += new System.EventHandler(this.Federal_Witholding_Rates_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalWHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalWHDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtaddLowBound;
        private System.Windows.Forms.TextBox txtaddPeriod;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPctWH;
        private System.Windows.Forms.TextBox txtWithholding;
        private System.Windows.Forms.TextBox txtHighBound;
        private System.Windows.Forms.TextBox txtLowbound;
        private System.Windows.Forms.TextBox txtPeriod;
        private System.Windows.Forms.Button btnAdd;
              private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblFederalWHBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalWHTableAdapter tblFederalWHTableAdapter;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblFederalWHDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox txtdelHighBound;
        private System.Windows.Forms.Label label11;
    }
}