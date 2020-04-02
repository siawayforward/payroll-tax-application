namespace Payroll_Tax_Application
{
    partial class Form_Application
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
            this.lblWeeklyHoursAZ = new System.Windows.Forms.Label();
            this.lblPayAZ = new System.Windows.Forms.Label();
            this.lblPayDetailsAZ = new System.Windows.Forms.Label();
            this.txtWeeklyHoursAZ = new System.Windows.Forms.TextBox();
            this.txtPayAZ = new System.Windows.Forms.TextBox();
            this.rdbBiweeklyAZ = new System.Windows.Forms.RadioButton();
            this.rdbAnnualAZ = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.lblW4AZ = new System.Windows.Forms.Label();
            this.tabPayrollTaxApplication = new System.Windows.Forms.TabControl();
            this.tabArizona = new System.Windows.Forms.TabPage();
            this.btnBackAZ = new System.Windows.Forms.Button();
            this.lblAllowancesAZ = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnContinueAZ = new System.Windows.Forms.Button();
            this.hsbAllowancesAZ = new System.Windows.Forms.HScrollBar();
            this.txtMonthsWorkedAZ = new System.Windows.Forms.TextBox();
            this.lblMonthsAZ = new System.Windows.Forms.Label();
            this.tabNevada = new System.Windows.Forms.TabPage();
            this.btnBackNV = new System.Windows.Forms.Button();
            this.lblAllowancesNV = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnContinueNV = new System.Windows.Forms.Button();
            this.hsbAllowancesNV = new System.Windows.Forms.HScrollBar();
            this.txtMonthsWorkedNV = new System.Windows.Forms.TextBox();
            this.lblMonthsNV = new System.Windows.Forms.Label();
            this.rdbBiweeklyNV = new System.Windows.Forms.RadioButton();
            this.rdbAnnualNV = new System.Windows.Forms.RadioButton();
            this.lblPayDetailsNV = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWeeklyHoursNV = new System.Windows.Forms.Label();
            this.lblPayNV = new System.Windows.Forms.Label();
            this.txtWeeklyHoursNV = new System.Windows.Forms.TextBox();
            this.lblW4NV = new System.Windows.Forms.Label();
            this.txtPayNV = new System.Windows.Forms.TextBox();
            this.tabUtah = new System.Windows.Forms.TabPage();
            this.btnBackUT = new System.Windows.Forms.Button();
            this.lblAllowancesUT = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnContinueUT = new System.Windows.Forms.Button();
            this.hsbAllowancesUT = new System.Windows.Forms.HScrollBar();
            this.txtMonthsWorkedUT = new System.Windows.Forms.TextBox();
            this.lblMonthsUT = new System.Windows.Forms.Label();
            this.rdbBiweeklyUT = new System.Windows.Forms.RadioButton();
            this.rdbAnnualUT = new System.Windows.Forms.RadioButton();
            this.lblPayDetailsUT = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWeeklyHoursUT = new System.Windows.Forms.Label();
            this.lblPayUT = new System.Windows.Forms.Label();
            this.txtWeeklyHoursUT = new System.Windows.Forms.TextBox();
            this.lblW4UT = new System.Windows.Forms.Label();
            this.txtPayUT = new System.Windows.Forms.TextBox();
            this.toolFormW4 = new System.Windows.Forms.ToolTip(this.components);
            this.taxUsersDataSet = new PayRollTaxCalculator.TaxUsersDataSet();
            this.tblSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSalaryTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblSalaryTableAdapter();
            this.tableAdapterManager = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager();
            this.tblFederalRatesTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalRatesTableAdapter();
            this.tblFederalWHTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalWHTableAdapter();
            this.tblStateWHTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblStateWHTableAdapter();
            this.tblSUTARatesTableAdapter = new PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblSUTARatesTableAdapter();
            this.tblFederalRatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFederalWHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblStateWHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSUTARatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPayrollTaxApplication.SuspendLayout();
            this.tabArizona.SuspendLayout();
            this.tabNevada.SuspendLayout();
            this.tabUtah.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalRatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalWHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateWHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSUTARatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWeeklyHoursAZ
            // 
            this.lblWeeklyHoursAZ.AutoSize = true;
            this.lblWeeklyHoursAZ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyHoursAZ.Location = new System.Drawing.Point(507, 260);
            this.lblWeeklyHoursAZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeeklyHoursAZ.Name = "lblWeeklyHoursAZ";
            this.lblWeeklyHoursAZ.Size = new System.Drawing.Size(117, 25);
            this.lblWeeklyHoursAZ.TabIndex = 6;
            this.lblWeeklyHoursAZ.Text = "Hours/week:";
            // 
            // lblPayAZ
            // 
            this.lblPayAZ.AutoSize = true;
            this.lblPayAZ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayAZ.Location = new System.Drawing.Point(297, 260);
            this.lblPayAZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayAZ.Name = "lblPayAZ";
            this.lblPayAZ.Size = new System.Drawing.Size(105, 25);
            this.lblPayAZ.TabIndex = 4;
            this.lblPayAZ.Text = "Hourly Pay:";
            // 
            // lblPayDetailsAZ
            // 
            this.lblPayDetailsAZ.AutoSize = true;
            this.lblPayDetailsAZ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDetailsAZ.Location = new System.Drawing.Point(82, 260);
            this.lblPayDetailsAZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayDetailsAZ.Name = "lblPayDetailsAZ";
            this.lblPayDetailsAZ.Size = new System.Drawing.Size(191, 25);
            this.lblPayDetailsAZ.TabIndex = 17;
            this.lblPayDetailsAZ.Text = "Bi-weekly Pay Details:";
            // 
            // txtWeeklyHoursAZ
            // 
            this.txtWeeklyHoursAZ.Location = new System.Drawing.Point(627, 245);
            this.txtWeeklyHoursAZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeeklyHoursAZ.Multiline = true;
            this.txtWeeklyHoursAZ.Name = "txtWeeklyHoursAZ";
            this.txtWeeklyHoursAZ.Size = new System.Drawing.Size(70, 36);
            this.txtWeeklyHoursAZ.TabIndex = 7;
            this.txtWeeklyHoursAZ.Enter += new System.EventHandler(this.selectAll);
            this.txtWeeklyHoursAZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // txtPayAZ
            // 
            this.txtPayAZ.Location = new System.Drawing.Point(408, 245);
            this.txtPayAZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayAZ.Multiline = true;
            this.txtPayAZ.Name = "txtPayAZ";
            this.txtPayAZ.Size = new System.Drawing.Size(70, 36);
            this.txtPayAZ.TabIndex = 5;
            this.txtPayAZ.Enter += new System.EventHandler(this.selectAll);
            this.txtPayAZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // rdbBiweeklyAZ
            // 
            this.rdbBiweeklyAZ.AutoSize = true;
            this.rdbBiweeklyAZ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBiweeklyAZ.Location = new System.Drawing.Point(302, 185);
            this.rdbBiweeklyAZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbBiweeklyAZ.Name = "rdbBiweeklyAZ";
            this.rdbBiweeklyAZ.Size = new System.Drawing.Size(117, 29);
            this.rdbBiweeklyAZ.TabIndex = 2;
            this.rdbBiweeklyAZ.Text = "Bi-weekly";
            this.rdbBiweeklyAZ.UseVisualStyleBackColor = true;
            this.rdbBiweeklyAZ.CheckedChanged += new System.EventHandler(this.input_CheckedChanged);
            // 
            // rdbAnnualAZ
            // 
            this.rdbAnnualAZ.AutoSize = true;
            this.rdbAnnualAZ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnnualAZ.Location = new System.Drawing.Point(450, 185);
            this.rdbAnnualAZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbAnnualAZ.Name = "rdbAnnualAZ";
            this.rdbAnnualAZ.Size = new System.Drawing.Size(96, 29);
            this.rdbAnnualAZ.TabIndex = 3;
            this.rdbAnnualAZ.Text = "Annual";
            this.rdbAnnualAZ.UseVisualStyleBackColor = true;
            this.rdbAnnualAZ.CheckedChanged += new System.EventHandler(this.input_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(93, 191);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(179, 25);
            this.label23.TabIndex = 3;
            this.label23.Text = "Payment Frequency:";
            // 
            // lblW4AZ
            // 
            this.lblW4AZ.AutoSize = true;
            this.lblW4AZ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW4AZ.Location = new System.Drawing.Point(38, 122);
            this.lblW4AZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblW4AZ.Name = "lblW4AZ";
            this.lblW4AZ.Size = new System.Drawing.Size(234, 25);
            this.lblW4AZ.TabIndex = 31;
            this.lblW4AZ.Text = "Form W-4 # of Allowances:";
            // 
            // tabPayrollTaxApplication
            // 
            this.tabPayrollTaxApplication.Controls.Add(this.tabArizona);
            this.tabPayrollTaxApplication.Controls.Add(this.tabNevada);
            this.tabPayrollTaxApplication.Controls.Add(this.tabUtah);
            this.tabPayrollTaxApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPayrollTaxApplication.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPayrollTaxApplication.Location = new System.Drawing.Point(0, 0);
            this.tabPayrollTaxApplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPayrollTaxApplication.Name = "tabPayrollTaxApplication";
            this.tabPayrollTaxApplication.SelectedIndex = 0;
            this.tabPayrollTaxApplication.Size = new System.Drawing.Size(747, 495);
            this.tabPayrollTaxApplication.TabIndex = 0;
            // 
            // tabArizona
            // 
            this.tabArizona.AutoScroll = true;
            this.tabArizona.BackColor = System.Drawing.SystemColors.Control;
            this.tabArizona.Controls.Add(this.btnBackAZ);
            this.tabArizona.Controls.Add(this.lblAllowancesAZ);
            this.tabArizona.Controls.Add(this.label15);
            this.tabArizona.Controls.Add(this.btnContinueAZ);
            this.tabArizona.Controls.Add(this.hsbAllowancesAZ);
            this.tabArizona.Controls.Add(this.txtMonthsWorkedAZ);
            this.tabArizona.Controls.Add(this.lblMonthsAZ);
            this.tabArizona.Controls.Add(this.rdbBiweeklyAZ);
            this.tabArizona.Controls.Add(this.rdbAnnualAZ);
            this.tabArizona.Controls.Add(this.lblPayDetailsAZ);
            this.tabArizona.Controls.Add(this.label23);
            this.tabArizona.Controls.Add(this.lblWeeklyHoursAZ);
            this.tabArizona.Controls.Add(this.lblPayAZ);
            this.tabArizona.Controls.Add(this.txtWeeklyHoursAZ);
            this.tabArizona.Controls.Add(this.lblW4AZ);
            this.tabArizona.Controls.Add(this.txtPayAZ);
            this.tabArizona.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabArizona.Location = new System.Drawing.Point(4, 37);
            this.tabArizona.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabArizona.Name = "tabArizona";
            this.tabArizona.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabArizona.Size = new System.Drawing.Size(739, 454);
            this.tabArizona.TabIndex = 0;
            this.tabArizona.Text = "Arizona";
            // 
            // btnBackAZ
            // 
            this.btnBackAZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAZ.Location = new System.Drawing.Point(408, 368);
            this.btnBackAZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackAZ.Name = "btnBackAZ";
            this.btnBackAZ.Size = new System.Drawing.Size(135, 46);
            this.btnBackAZ.TabIndex = 9;
            this.btnBackAZ.Text = "&Back";
            this.btnBackAZ.UseVisualStyleBackColor = true;
            this.btnBackAZ.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAllowancesAZ
            // 
            this.lblAllowancesAZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllowancesAZ.Location = new System.Drawing.Point(627, 106);
            this.lblAllowancesAZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllowancesAZ.Name = "lblAllowancesAZ";
            this.lblAllowancesAZ.Size = new System.Drawing.Size(71, 37);
            this.lblAllowancesAZ.TabIndex = 1;
            this.lblAllowancesAZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 38);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(524, 43);
            this.label15.TabIndex = 52;
            this.label15.Text = "Allowance && Salary Information: Arizona";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnContinueAZ
            // 
            this.btnContinueAZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueAZ.Location = new System.Drawing.Point(564, 368);
            this.btnContinueAZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContinueAZ.Name = "btnContinueAZ";
            this.btnContinueAZ.Size = new System.Drawing.Size(135, 46);
            this.btnContinueAZ.TabIndex = 10;
            this.btnContinueAZ.Text = "&Continue";
            this.btnContinueAZ.UseVisualStyleBackColor = true;
            this.btnContinueAZ.Click += new System.EventHandler(this.btnContinueAZ_Click);
            // 
            // hsbAllowancesAZ
            // 
            this.hsbAllowancesAZ.LargeChange = 1;
            this.hsbAllowancesAZ.Location = new System.Drawing.Point(302, 105);
            this.hsbAllowancesAZ.Maximum = 10;
            this.hsbAllowancesAZ.Name = "hsbAllowancesAZ";
            this.hsbAllowancesAZ.Size = new System.Drawing.Size(316, 26);
            this.hsbAllowancesAZ.TabIndex = 0;
            this.hsbAllowancesAZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbAllowances_Scroll);
            // 
            // txtMonthsWorkedAZ
            // 
            this.txtMonthsWorkedAZ.Location = new System.Drawing.Point(302, 314);
            this.txtMonthsWorkedAZ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonthsWorkedAZ.Multiline = true;
            this.txtMonthsWorkedAZ.Name = "txtMonthsWorkedAZ";
            this.txtMonthsWorkedAZ.Size = new System.Drawing.Size(70, 36);
            this.txtMonthsWorkedAZ.TabIndex = 8;
            this.txtMonthsWorkedAZ.Enter += new System.EventHandler(this.selectAll);
            this.txtMonthsWorkedAZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // lblMonthsAZ
            // 
            this.lblMonthsAZ.AutoSize = true;
            this.lblMonthsAZ.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthsAZ.Location = new System.Drawing.Point(38, 329);
            this.lblMonthsAZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthsAZ.Name = "lblMonthsAZ";
            this.lblMonthsAZ.Size = new System.Drawing.Size(233, 25);
            this.lblMonthsAZ.TabIndex = 34;
            this.lblMonthsAZ.Text = "Total # of Months Worked:";
            // 
            // tabNevada
            // 
            this.tabNevada.BackColor = System.Drawing.SystemColors.Control;
            this.tabNevada.Controls.Add(this.btnBackNV);
            this.tabNevada.Controls.Add(this.lblAllowancesNV);
            this.tabNevada.Controls.Add(this.label13);
            this.tabNevada.Controls.Add(this.btnContinueNV);
            this.tabNevada.Controls.Add(this.hsbAllowancesNV);
            this.tabNevada.Controls.Add(this.txtMonthsWorkedNV);
            this.tabNevada.Controls.Add(this.lblMonthsNV);
            this.tabNevada.Controls.Add(this.rdbBiweeklyNV);
            this.tabNevada.Controls.Add(this.rdbAnnualNV);
            this.tabNevada.Controls.Add(this.lblPayDetailsNV);
            this.tabNevada.Controls.Add(this.label3);
            this.tabNevada.Controls.Add(this.lblWeeklyHoursNV);
            this.tabNevada.Controls.Add(this.lblPayNV);
            this.tabNevada.Controls.Add(this.txtWeeklyHoursNV);
            this.tabNevada.Controls.Add(this.lblW4NV);
            this.tabNevada.Controls.Add(this.txtPayNV);
            this.tabNevada.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNevada.Location = new System.Drawing.Point(4, 37);
            this.tabNevada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNevada.Name = "tabNevada";
            this.tabNevada.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNevada.Size = new System.Drawing.Size(739, 454);
            this.tabNevada.TabIndex = 1;
            this.tabNevada.Text = "Nevada";
            // 
            // btnBackNV
            // 
            this.btnBackNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackNV.Location = new System.Drawing.Point(412, 363);
            this.btnBackNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackNV.Name = "btnBackNV";
            this.btnBackNV.Size = new System.Drawing.Size(135, 46);
            this.btnBackNV.TabIndex = 11;
            this.btnBackNV.Text = "&Back";
            this.btnBackNV.UseVisualStyleBackColor = true;
            this.btnBackNV.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAllowancesNV
            // 
            this.lblAllowancesNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllowancesNV.Location = new System.Drawing.Point(630, 102);
            this.lblAllowancesNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllowancesNV.Name = "lblAllowancesNV";
            this.lblAllowancesNV.Size = new System.Drawing.Size(71, 37);
            this.lblAllowancesNV.TabIndex = 3;
            this.lblAllowancesNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 32);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(524, 43);
            this.label13.TabIndex = 52;
            this.label13.Text = "Allowance && Salary Information: Nevada";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnContinueNV
            // 
            this.btnContinueNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueNV.Location = new System.Drawing.Point(567, 363);
            this.btnContinueNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContinueNV.Name = "btnContinueNV";
            this.btnContinueNV.Size = new System.Drawing.Size(135, 46);
            this.btnContinueNV.TabIndex = 12;
            this.btnContinueNV.Text = "&Continue";
            this.btnContinueNV.UseVisualStyleBackColor = true;
            this.btnContinueNV.Click += new System.EventHandler(this.btnContinueNV_Click);
            // 
            // hsbAllowancesNV
            // 
            this.hsbAllowancesNV.LargeChange = 1;
            this.hsbAllowancesNV.Location = new System.Drawing.Point(304, 100);
            this.hsbAllowancesNV.Maximum = 10;
            this.hsbAllowancesNV.Name = "hsbAllowancesNV";
            this.hsbAllowancesNV.Size = new System.Drawing.Size(316, 26);
            this.hsbAllowancesNV.TabIndex = 2;
            this.hsbAllowancesNV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbAllowances_Scroll);
            // 
            // txtMonthsWorkedNV
            // 
            this.txtMonthsWorkedNV.Location = new System.Drawing.Point(304, 309);
            this.txtMonthsWorkedNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonthsWorkedNV.Multiline = true;
            this.txtMonthsWorkedNV.Name = "txtMonthsWorkedNV";
            this.txtMonthsWorkedNV.Size = new System.Drawing.Size(70, 36);
            this.txtMonthsWorkedNV.TabIndex = 10;
            this.txtMonthsWorkedNV.Enter += new System.EventHandler(this.selectAll);
            this.txtMonthsWorkedNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // lblMonthsNV
            // 
            this.lblMonthsNV.AutoSize = true;
            this.lblMonthsNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthsNV.Location = new System.Drawing.Point(40, 325);
            this.lblMonthsNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthsNV.Name = "lblMonthsNV";
            this.lblMonthsNV.Size = new System.Drawing.Size(233, 25);
            this.lblMonthsNV.TabIndex = 47;
            this.lblMonthsNV.Text = "Total # of Months Worked:";
            // 
            // rdbBiweeklyNV
            // 
            this.rdbBiweeklyNV.AutoSize = true;
            this.rdbBiweeklyNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBiweeklyNV.Location = new System.Drawing.Point(304, 180);
            this.rdbBiweeklyNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbBiweeklyNV.Name = "rdbBiweeklyNV";
            this.rdbBiweeklyNV.Size = new System.Drawing.Size(117, 29);
            this.rdbBiweeklyNV.TabIndex = 4;
            this.rdbBiweeklyNV.Text = "Bi-weekly";
            this.rdbBiweeklyNV.UseVisualStyleBackColor = true;
            this.rdbBiweeklyNV.CheckedChanged += new System.EventHandler(this.input_CheckedChanged);
            // 
            // rdbAnnualNV
            // 
            this.rdbAnnualNV.AutoSize = true;
            this.rdbAnnualNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnnualNV.Location = new System.Drawing.Point(453, 180);
            this.rdbAnnualNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbAnnualNV.Name = "rdbAnnualNV";
            this.rdbAnnualNV.Size = new System.Drawing.Size(96, 29);
            this.rdbAnnualNV.TabIndex = 5;
            this.rdbAnnualNV.Text = "Annual";
            this.rdbAnnualNV.UseVisualStyleBackColor = true;
            this.rdbAnnualNV.CheckedChanged += new System.EventHandler(this.input_CheckedChanged);
            // 
            // lblPayDetailsNV
            // 
            this.lblPayDetailsNV.AutoSize = true;
            this.lblPayDetailsNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDetailsNV.Location = new System.Drawing.Point(86, 255);
            this.lblPayDetailsNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayDetailsNV.Name = "lblPayDetailsNV";
            this.lblPayDetailsNV.Size = new System.Drawing.Size(191, 25);
            this.lblPayDetailsNV.TabIndex = 43;
            this.lblPayDetailsNV.Text = "Bi-weekly Pay Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Payment Frequency:";
            // 
            // lblWeeklyHoursNV
            // 
            this.lblWeeklyHoursNV.AutoSize = true;
            this.lblWeeklyHoursNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyHoursNV.Location = new System.Drawing.Point(510, 255);
            this.lblWeeklyHoursNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeeklyHoursNV.Name = "lblWeeklyHoursNV";
            this.lblWeeklyHoursNV.Size = new System.Drawing.Size(117, 25);
            this.lblWeeklyHoursNV.TabIndex = 8;
            this.lblWeeklyHoursNV.Text = "Hours/week:";
            // 
            // lblPayNV
            // 
            this.lblPayNV.AutoSize = true;
            this.lblPayNV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayNV.Location = new System.Drawing.Point(300, 255);
            this.lblPayNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayNV.Name = "lblPayNV";
            this.lblPayNV.Size = new System.Drawing.Size(105, 25);
            this.lblPayNV.TabIndex = 6;
            this.lblPayNV.Text = "Hourly Pay:";
            // 
            // txtWeeklyHoursNV
            // 
            this.txtWeeklyHoursNV.Location = new System.Drawing.Point(630, 240);
            this.txtWeeklyHoursNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeeklyHoursNV.Multiline = true;
            this.txtWeeklyHoursNV.Name = "txtWeeklyHoursNV";
            this.txtWeeklyHoursNV.Size = new System.Drawing.Size(70, 36);
            this.txtWeeklyHoursNV.TabIndex = 9;
            this.txtWeeklyHoursNV.Enter += new System.EventHandler(this.selectAll);
            this.txtWeeklyHoursNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // lblW4NV
            // 
            this.lblW4NV.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW4NV.Location = new System.Drawing.Point(40, 117);
            this.lblW4NV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblW4NV.Name = "lblW4NV";
            this.lblW4NV.Size = new System.Drawing.Size(662, 58);
            this.lblW4NV.TabIndex = 46;
            this.lblW4NV.Text = "Form W-4 # of Allowances:";
            // 
            // txtPayNV
            // 
            this.txtPayNV.Location = new System.Drawing.Point(411, 240);
            this.txtPayNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayNV.Multiline = true;
            this.txtPayNV.Name = "txtPayNV";
            this.txtPayNV.Size = new System.Drawing.Size(70, 36);
            this.txtPayNV.TabIndex = 7;
            this.txtPayNV.Enter += new System.EventHandler(this.selectAll);
            this.txtPayNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // tabUtah
            // 
            this.tabUtah.BackColor = System.Drawing.SystemColors.Control;
            this.tabUtah.Controls.Add(this.btnBackUT);
            this.tabUtah.Controls.Add(this.lblAllowancesUT);
            this.tabUtah.Controls.Add(this.label14);
            this.tabUtah.Controls.Add(this.btnContinueUT);
            this.tabUtah.Controls.Add(this.hsbAllowancesUT);
            this.tabUtah.Controls.Add(this.txtMonthsWorkedUT);
            this.tabUtah.Controls.Add(this.lblMonthsUT);
            this.tabUtah.Controls.Add(this.rdbBiweeklyUT);
            this.tabUtah.Controls.Add(this.rdbAnnualUT);
            this.tabUtah.Controls.Add(this.lblPayDetailsUT);
            this.tabUtah.Controls.Add(this.label9);
            this.tabUtah.Controls.Add(this.lblWeeklyHoursUT);
            this.tabUtah.Controls.Add(this.lblPayUT);
            this.tabUtah.Controls.Add(this.txtWeeklyHoursUT);
            this.tabUtah.Controls.Add(this.lblW4UT);
            this.tabUtah.Controls.Add(this.txtPayUT);
            this.tabUtah.Location = new System.Drawing.Point(4, 37);
            this.tabUtah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUtah.Name = "tabUtah";
            this.tabUtah.Size = new System.Drawing.Size(739, 454);
            this.tabUtah.TabIndex = 2;
            this.tabUtah.Text = "Utah";
            // 
            // btnBackUT
            // 
            this.btnBackUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUT.Location = new System.Drawing.Point(408, 362);
            this.btnBackUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackUT.Name = "btnBackUT";
            this.btnBackUT.Size = new System.Drawing.Size(135, 46);
            this.btnBackUT.TabIndex = 9;
            this.btnBackUT.Text = "&Back";
            this.btnBackUT.UseVisualStyleBackColor = true;
            this.btnBackUT.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAllowancesUT
            // 
            this.lblAllowancesUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAllowancesUT.Location = new System.Drawing.Point(627, 100);
            this.lblAllowancesUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllowancesUT.Name = "lblAllowancesUT";
            this.lblAllowancesUT.Size = new System.Drawing.Size(71, 37);
            this.lblAllowancesUT.TabIndex = 1;
            this.lblAllowancesUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 37);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(524, 43);
            this.label14.TabIndex = 51;
            this.label14.Text = "Allowance && Salary Information: Utah";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnContinueUT
            // 
            this.btnContinueUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinueUT.Location = new System.Drawing.Point(564, 362);
            this.btnContinueUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContinueUT.Name = "btnContinueUT";
            this.btnContinueUT.Size = new System.Drawing.Size(135, 46);
            this.btnContinueUT.TabIndex = 10;
            this.btnContinueUT.Text = "&Continue";
            this.btnContinueUT.UseVisualStyleBackColor = true;
            this.btnContinueUT.Click += new System.EventHandler(this.btnContinueUT_Click);
            // 
            // hsbAllowancesUT
            // 
            this.hsbAllowancesUT.LargeChange = 1;
            this.hsbAllowancesUT.Location = new System.Drawing.Point(302, 98);
            this.hsbAllowancesUT.Maximum = 10;
            this.hsbAllowancesUT.Name = "hsbAllowancesUT";
            this.hsbAllowancesUT.Size = new System.Drawing.Size(316, 26);
            this.hsbAllowancesUT.TabIndex = 0;
            this.hsbAllowancesUT.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbAllowances_Scroll);
            // 
            // txtMonthsWorkedUT
            // 
            this.txtMonthsWorkedUT.Location = new System.Drawing.Point(302, 308);
            this.txtMonthsWorkedUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonthsWorkedUT.Multiline = true;
            this.txtMonthsWorkedUT.Name = "txtMonthsWorkedUT";
            this.txtMonthsWorkedUT.Size = new System.Drawing.Size(70, 36);
            this.txtMonthsWorkedUT.TabIndex = 8;
            this.txtMonthsWorkedUT.Enter += new System.EventHandler(this.selectAll);
            this.txtMonthsWorkedUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // lblMonthsUT
            // 
            this.lblMonthsUT.AutoSize = true;
            this.lblMonthsUT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthsUT.Location = new System.Drawing.Point(38, 323);
            this.lblMonthsUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthsUT.Name = "lblMonthsUT";
            this.lblMonthsUT.Size = new System.Drawing.Size(233, 25);
            this.lblMonthsUT.TabIndex = 47;
            this.lblMonthsUT.Text = "Total # of Months Worked:";
            // 
            // rdbBiweeklyUT
            // 
            this.rdbBiweeklyUT.AutoSize = true;
            this.rdbBiweeklyUT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBiweeklyUT.Location = new System.Drawing.Point(302, 178);
            this.rdbBiweeklyUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbBiweeklyUT.Name = "rdbBiweeklyUT";
            this.rdbBiweeklyUT.Size = new System.Drawing.Size(117, 29);
            this.rdbBiweeklyUT.TabIndex = 2;
            this.rdbBiweeklyUT.Text = "Bi-weekly";
            this.rdbBiweeklyUT.UseVisualStyleBackColor = true;
            this.rdbBiweeklyUT.CheckedChanged += new System.EventHandler(this.input_CheckedChanged);
            // 
            // rdbAnnualUT
            // 
            this.rdbAnnualUT.AutoSize = true;
            this.rdbAnnualUT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnnualUT.Location = new System.Drawing.Point(450, 178);
            this.rdbAnnualUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbAnnualUT.Name = "rdbAnnualUT";
            this.rdbAnnualUT.Size = new System.Drawing.Size(96, 29);
            this.rdbAnnualUT.TabIndex = 3;
            this.rdbAnnualUT.Text = "Annual";
            this.rdbAnnualUT.UseVisualStyleBackColor = true;
            this.rdbAnnualUT.CheckedChanged += new System.EventHandler(this.input_CheckedChanged);
            // 
            // lblPayDetailsUT
            // 
            this.lblPayDetailsUT.AutoSize = true;
            this.lblPayDetailsUT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDetailsUT.Location = new System.Drawing.Point(82, 254);
            this.lblPayDetailsUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayDetailsUT.Name = "lblPayDetailsUT";
            this.lblPayDetailsUT.Size = new System.Drawing.Size(191, 25);
            this.lblPayDetailsUT.TabIndex = 43;
            this.lblPayDetailsUT.Text = "Bi-weekly Pay Details:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Payment Frequency:";
            // 
            // lblWeeklyHoursUT
            // 
            this.lblWeeklyHoursUT.AutoSize = true;
            this.lblWeeklyHoursUT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyHoursUT.Location = new System.Drawing.Point(507, 254);
            this.lblWeeklyHoursUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeeklyHoursUT.Name = "lblWeeklyHoursUT";
            this.lblWeeklyHoursUT.Size = new System.Drawing.Size(117, 25);
            this.lblWeeklyHoursUT.TabIndex = 6;
            this.lblWeeklyHoursUT.Text = "Hours/week:";
            // 
            // lblPayUT
            // 
            this.lblPayUT.AutoSize = true;
            this.lblPayUT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayUT.Location = new System.Drawing.Point(297, 254);
            this.lblPayUT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayUT.Name = "lblPayUT";
            this.lblPayUT.Size = new System.Drawing.Size(105, 25);
            this.lblPayUT.TabIndex = 4;
            this.lblPayUT.Text = "Hourly Pay:";
            // 
            // txtWeeklyHoursUT
            // 
            this.txtWeeklyHoursUT.Location = new System.Drawing.Point(627, 238);
            this.txtWeeklyHoursUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeeklyHoursUT.Multiline = true;
            this.txtWeeklyHoursUT.Name = "txtWeeklyHoursUT";
            this.txtWeeklyHoursUT.Size = new System.Drawing.Size(70, 36);
            this.txtWeeklyHoursUT.TabIndex = 7;
            this.txtWeeklyHoursUT.Enter += new System.EventHandler(this.selectAll);
            this.txtWeeklyHoursUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // lblW4UT
            // 
            this.lblW4UT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblW4UT.Location = new System.Drawing.Point(38, 115);
            this.lblW4UT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblW4UT.Name = "lblW4UT";
            this.lblW4UT.Size = new System.Drawing.Size(662, 58);
            this.lblW4UT.TabIndex = 46;
            this.lblW4UT.Text = "Form W-4 # of Allowances:";
            // 
            // txtPayUT
            // 
            this.txtPayUT.Location = new System.Drawing.Point(408, 238);
            this.txtPayUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayUT.Multiline = true;
            this.txtPayUT.Name = "txtPayUT";
            this.txtPayUT.Size = new System.Drawing.Size(70, 36);
            this.txtPayUT.TabIndex = 5;
            this.txtPayUT.Enter += new System.EventHandler(this.selectAll);
            this.txtPayUT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // toolFormW4
            // 
            this.toolFormW4.BackColor = System.Drawing.Color.LightSalmon;
            this.toolFormW4.ShowAlways = true;
            this.toolFormW4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolFormW4.ToolTipTitle = "Form W-4 Allowances";
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
            this.tableAdapterManager.tblFederalRatesTableAdapter = this.tblFederalRatesTableAdapter;
            this.tableAdapterManager.tblFederalWHTableAdapter = this.tblFederalWHTableAdapter;
            this.tableAdapterManager.tblFeedbackTableAdapter = null;
            this.tableAdapterManager.tblSalaryTableAdapter = this.tblSalaryTableAdapter;
            this.tableAdapterManager.tblStateWHTableAdapter = this.tblStateWHTableAdapter;
            this.tableAdapterManager.tblSUTARatesTableAdapter = this.tblSUTARatesTableAdapter;
            this.tableAdapterManager.tblUsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblFederalRatesTableAdapter
            // 
            this.tblFederalRatesTableAdapter.ClearBeforeFill = true;
            // 
            // tblFederalWHTableAdapter
            // 
            this.tblFederalWHTableAdapter.ClearBeforeFill = true;
            // 
            // tblStateWHTableAdapter
            // 
            this.tblStateWHTableAdapter.ClearBeforeFill = true;
            // 
            // tblSUTARatesTableAdapter
            // 
            this.tblSUTARatesTableAdapter.ClearBeforeFill = true;
            // 
            // tblFederalRatesBindingSource
            // 
            this.tblFederalRatesBindingSource.DataMember = "tblFederalRates";
            this.tblFederalRatesBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // tblFederalWHBindingSource
            // 
            this.tblFederalWHBindingSource.DataMember = "tblFederalWH";
            this.tblFederalWHBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // tblStateWHBindingSource
            // 
            this.tblStateWHBindingSource.DataMember = "tblStateWH";
            this.tblStateWHBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // tblSUTARatesBindingSource
            // 
            this.tblSUTARatesBindingSource.DataMember = "tblSUTARates";
            this.tblSUTARatesBindingSource.DataSource = this.taxUsersDataSet;
            // 
            // Form_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 495);
            this.Controls.Add(this.tabPayrollTaxApplication);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Application";
            this.Text = "Payroll Tax Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Application_FormClosing);
            this.Load += new System.EventHandler(this.Form_Application_Load);
            this.tabPayrollTaxApplication.ResumeLayout(false);
            this.tabArizona.ResumeLayout(false);
            this.tabArizona.PerformLayout();
            this.tabNevada.ResumeLayout(false);
            this.tabNevada.PerformLayout();
            this.tabUtah.ResumeLayout(false);
            this.tabUtah.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalRatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFederalWHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStateWHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSUTARatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWeeklyHoursAZ;
        private System.Windows.Forms.Label lblPayAZ;
        private System.Windows.Forms.Label lblPayDetailsAZ;
        private System.Windows.Forms.TextBox txtWeeklyHoursAZ;
        private System.Windows.Forms.TextBox txtPayAZ;
        private System.Windows.Forms.RadioButton rdbBiweeklyAZ;
        private System.Windows.Forms.RadioButton rdbAnnualAZ;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblW4AZ;
        private System.Windows.Forms.TabControl tabPayrollTaxApplication;
        private System.Windows.Forms.TabPage tabArizona;
        private System.Windows.Forms.TabPage tabNevada;
        private System.Windows.Forms.TextBox txtMonthsWorkedAZ;
        private System.Windows.Forms.Label lblMonthsAZ;
        private System.Windows.Forms.HScrollBar hsbAllowancesAZ;
        private System.Windows.Forms.Button btnContinueAZ;
        private System.Windows.Forms.TabPage tabUtah;
        private System.Windows.Forms.Button btnContinueNV;
        private System.Windows.Forms.HScrollBar hsbAllowancesNV;
        private System.Windows.Forms.TextBox txtMonthsWorkedNV;
        private System.Windows.Forms.Label lblMonthsNV;
        private System.Windows.Forms.RadioButton rdbBiweeklyNV;
        private System.Windows.Forms.RadioButton rdbAnnualNV;
        private System.Windows.Forms.Label lblPayDetailsNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWeeklyHoursNV;
        private System.Windows.Forms.Label lblPayNV;
        private System.Windows.Forms.TextBox txtWeeklyHoursNV;
        private System.Windows.Forms.Label lblW4NV;
        private System.Windows.Forms.TextBox txtPayNV;
        private System.Windows.Forms.Button btnContinueUT;
        private System.Windows.Forms.HScrollBar hsbAllowancesUT;
        private System.Windows.Forms.TextBox txtMonthsWorkedUT;
        private System.Windows.Forms.Label lblMonthsUT;
        private System.Windows.Forms.RadioButton rdbBiweeklyUT;
        private System.Windows.Forms.RadioButton rdbAnnualUT;
        private System.Windows.Forms.Label lblPayDetailsUT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWeeklyHoursUT;
        private System.Windows.Forms.Label lblPayUT;
        private System.Windows.Forms.TextBox txtWeeklyHoursUT;
        private System.Windows.Forms.Label lblW4UT;
        private System.Windows.Forms.TextBox txtPayUT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAllowancesAZ;
        private System.Windows.Forms.Label lblAllowancesNV;
        private System.Windows.Forms.Label lblAllowancesUT;
        private System.Windows.Forms.Button btnBackAZ;
        private System.Windows.Forms.Button btnBackNV;
        private System.Windows.Forms.Button btnBackUT;
        private System.Windows.Forms.ToolTip toolFormW4;
        private PayRollTaxCalculator.TaxUsersDataSet taxUsersDataSet;
        private System.Windows.Forms.BindingSource tblSalaryBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblSalaryTableAdapter tblSalaryTableAdapter;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalRatesTableAdapter tblFederalRatesTableAdapter;
        private System.Windows.Forms.BindingSource tblFederalRatesBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblFederalWHTableAdapter tblFederalWHTableAdapter;
        private System.Windows.Forms.BindingSource tblFederalWHBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblStateWHTableAdapter tblStateWHTableAdapter;
        private System.Windows.Forms.BindingSource tblStateWHBindingSource;
        private PayRollTaxCalculator.TaxUsersDataSetTableAdapters.tblSUTARatesTableAdapter tblSUTARatesTableAdapter;
        private System.Windows.Forms.BindingSource tblSUTARatesBindingSource;
    }
}