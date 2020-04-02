/* Name: Payroll Tax Calculator
 *       Section: Payroll Tax Calculator by State (AZ, NV, UT)
 * Purpose: For this section of the application, the user enters their salary information including amounts, frequency,
 *          and the period worked in each state. Each state is separated by tab, and the user seeso only the tabs for 
 *          the states that they selected in the profile confirmation page. When entering amounts, the user has the 
 *          option to enter bi-weekly or annual pay details. The application will verify whether the total number of 
 *          months within all states selected are for a year (12 months) and notify the user if the period goes over. 
 *          Additionally, if the salary amounts, months, or frequency are not entered, the user will be prompted to 
 *          enter the amounts. Once information is given, federal and state taxes are calculated, stored, and displayed
 *          in the review page. Lastly users can go back and forth within state tabs, and to the profile confirmation
 *          page if they need to adjust or review information.
 * Programmer: Sia Mbatia
 * Date: November 20, 2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PayRollTaxCalculator;

namespace Payroll_Tax_Application
{
    public partial class Form_Application : Form
    {
        //declare array for user data from previous form
        string[] appData = new string[6];        

        public Form_Application(string[] uData)
        {
            InitializeComponent();

            //get values from user data
            appData = uData;
            //order of items stored in array:
            //username, name, state1(AZ), state2(NV), state3(UT), marital status
        }

        private void Form_Application_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close the application
            Application.Exit();
        }

        private void taxRatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

    

        //defining UI messages
        const string REVIEW_MSG = "Please review the state inputs before proceeding. Once you hit 'Continue', you will not be able to view this page again";
        const string REVIEW_QUESTION = "Proceed to review page?";
        const string MONTHS_ERR = "You entered a total period of over 12 months. Please adjust months worked for every state to total a calendar year";
        const string MONTHS_NULL_ERR = "Please enter your work duration in ";
        const string FREQ_NULL_ERR = "Please enter the pay schedule that applies to your compensation in ";
        const string HOURS_NULL_ERR = "Please enter the average number of hours you work per week";
        const string SALARY_ERR = "Your salary in all states exceeds USD 100,000. Please adjust the amounts to proceed";
        const string SALARY_NULL_ERR = "Please enter a salary amount for your compensation in ";

        //declare input and output arrays and variables for tax calculations and salary details
        double monthsAZ = 0, monthsNV = 0, monthsUT = 0, salaryAZ = 0, salaryNV = 0, salaryUT = 0;
        double formW4_AllowancesAZ = 0, formW4_AllowancesNV = 0, formW4_AllowancesUT = 0;
        string frequencyAZ = "", frequencyNV = "", frequencyUT = "";
        double AZweekHours = 0, NVweekHours = 0, UTweekHours = 0;
        string[] AZsalary = new string[7]; string[] NVsalary = new string[7]; string[] UTsalary = new string[7];
        bool[] multipleTabs; 
        double[] fedTaxesAZ = new double[6]; double[] fedTaxesNV = new double[6];  double[] fedTaxesUT = new double[6];
        double[] stateTaxesAZ = new double[2]; double[] stateTaxesNV = new double[2]; double[] stateTaxesUT = new double[2];

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            //for month entries, integers only
            if(sender == txtMonthsWorkedAZ || sender == txtMonthsWorkedNV || sender == txtMonthsWorkedUT)
            {
                if (!char.IsControl(e.KeyChar) & !char.IsNumber(e.KeyChar))
                    e.Handled = true;
            }

            //numerical values only (salary and week hours)
            if (sender == txtPayAZ || sender == txtPayNV || sender == txtPayUT || //salary entries
                    sender == txtWeeklyHoursAZ || sender == txtWeeklyHoursNV || sender == txtWeeklyHoursUT)
            {
                if (!char.IsControl(e.KeyChar) & !char.IsNumber(e.KeyChar) & e.KeyChar != '.')
                    e.Handled = true;
            }
        }

        private void Form_Application_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblSUTARates' table. You can move, or remove it, as needed.
            this.tblSUTARatesTableAdapter.Fill(this.taxUsersDataSet.tblSUTARates);
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblStateWH' table. You can move, or remove it, as needed.
            this.tblStateWHTableAdapter.Fill(this.taxUsersDataSet.tblStateWH);
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblFederalWH' table. You can move, or remove it, as needed.
            this.tblFederalWHTableAdapter.Fill(this.taxUsersDataSet.tblFederalWH);
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblFederalRates' table. You can move, or remove it, as needed.
            this.tblFederalRatesTableAdapter.Fill(this.taxUsersDataSet.tblFederalRates);
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblSalary' table. You can move, or remove it, as needed.
            this.tblSalaryTableAdapter.Fill(this.taxUsersDataSet.tblSalary);

            //display tabs based on states selected
            if (appData[2] != 1.ToString())
                tabPayrollTaxApplication.TabPages.Remove(tabArizona);
            if (appData[3] != 1.ToString())
                tabPayrollTaxApplication.TabPages.Remove(tabNevada);
            if (appData[4] != 1.ToString())
                tabPayrollTaxApplication.TabPages.Remove(tabUtah);

            //initial number of allowances displayed
            lblAllowancesAZ.Text = 0.ToString();
            lblAllowancesNV.Text = 0.ToString();
            lblAllowancesUT.Text = 0.ToString();

            //Set tooltip for Form W4 Allowances
            toolFormW4.SetToolTip(this.hsbAllowancesAZ, "Allowances can only be set for one state. " +
                "If your calculation involves more than one state, this option will only appear in the first state out of your options.");
            toolFormW4.SetToolTip(this.hsbAllowancesNV, "Allowances can only be set for one state. " +
                "If your calculation involves more than one state, this option will only appear in the first state out of your options.");
            toolFormW4.SetToolTip(this.hsbAllowancesUT, "Allowances can only be set for one state. " +
                "If your calculation involves more than one state, this option will only appear in the first state out of your options.");

            //Note for allowances if more than one state
            if (tabPayrollTaxApplication.TabPages.Count > 1 && tabPayrollTaxApplication.TabPages.IndexOf(tabNevada) == 1)
            {
                //hide back button and Form W4 Allowance entry boxes
                btnBackNV.Hide();
                lblW4NV.Text = "Allowances for federal tax withholding have been selected in your first state of employment";
                lblW4NV.ForeColor = Color.DarkRed;
                hsbAllowancesNV.Hide();
                lblAllowancesNV.Hide();
            }
            if(tabPayrollTaxApplication.TabPages.Count > 1 && tabPayrollTaxApplication.TabPages.IndexOf(tabUtah) >= 1)
            {
                //hide back button and Form W4 Allowance entry boxes
                btnBackUT.Hide();
                lblW4UT.Text = "Allowances for federal tax withholding have been selected in your first state of employment";
                lblW4UT.ForeColor = Color.DarkRed;
                hsbAllowancesUT.Hide();
                lblAllowancesUT.Hide();
            }

            //set accept button on basis of selected tab
            //set accept button on basis of selected tab
            if (tabPayrollTaxApplication.SelectedTab == tabArizona)
            {
                this.AcceptButton = btnContinueAZ;
            }
            if (tabPayrollTaxApplication.SelectedTab == tabNevada)
            {
                this.AcceptButton = btnContinueNV;
            }
            if (tabPayrollTaxApplication.SelectedTab == tabUtah)
            {
                this.AcceptButton = btnContinueUT;
            }
        }

        private void selectAll(object sender, EventArgs e)
        {
            if (sender == txtMonthsWorkedAZ)
                txtMonthsWorkedAZ.SelectAll();
            if (sender == txtPayAZ)
                txtPayAZ.SelectAll();
            if (sender == txtWeeklyHoursAZ)
                txtWeeklyHoursAZ.SelectAll();
            if (sender == txtMonthsWorkedNV)
                txtMonthsWorkedNV.SelectAll();
            if (sender == txtPayNV)
                txtPayNV.SelectAll();
            if (sender == txtWeeklyHoursNV)
                txtWeeklyHoursNV.SelectAll();
            if (sender == txtMonthsWorkedUT)
                txtMonthsWorkedUT.SelectAll();
            if (sender == txtPayUT)
                txtPayUT.SelectAll();
            if (sender == txtWeeklyHoursUT)
                txtWeeklyHoursUT.SelectAll();
        }

        //method to validate user has checked radio buttons to indicate work pay frequency
        private void Validate_RadioButton(string state, RadioButton rdbAnnual, RadioButton rdbBiweekly, Label lblweekHrs, Label lblpay, Label lblpayDetails, TextBox txtweekHrs, TextBox txtpay)
        {
            //radio buttons to determine how salary frequency labels are displayed
            if (rdbAnnual.Checked)
            {
                //hide hour detail labels and textboxes
                lblweekHrs.Hide();
                txtweekHrs.Hide();
                lblpayDetails.Hide();

                //set frequency and update labels and textboxes
                lblpay.Text = "Annual Salary:";
                txtpay.Width = 140;
                txtpay.Location = new Point(286, 159);
            }
            if (rdbBiweekly.Checked)
            {
                //show hour detail labels and textboxes
                lblweekHrs.Show();
                txtweekHrs.Show();
                lblpayDetails.Show();

                //set frequency and update labels and textboxes
                lblpay.Text = "Hourly Pay:";
                txtpay.Width = 48;
                txtpay.Location = new Point(274, 159);
            }
        }

        //methods to validate that user has entered value for all input boxes
        private bool Validate_Frequency(string state, RadioButton annual, RadioButton biweekly)
        {
            bool frequencyValid = true;
            //check for null values
            if (annual.Checked == false && biweekly.Checked == false) //frequency not selected
                frequencyValid = false;
            return frequencyValid;
        }

        private bool Validate_Pay(string state, TextBox txtPay)
        {
            bool salaryValid = true;
            //check for null values
            if (txtPay.Text.Trim().Length == 0) //weekHours not entered for bi-weekly pay frequency
                salaryValid = false;
            return salaryValid;
        }

        private double Validate_Hours(RadioButton rdbBiweekly, TextBox txtweekHrs)
        {
            double hours = 0;
            //check for null values
            if (txtweekHrs.Text.Trim().Length != 0 && rdbBiweekly.Checked) //weekHours not entered for bi-weekly pay frequency
                hours = double.Parse(txtweekHrs.Text.Trim());
            return hours;
        }

        private bool Validate_Months(string state, TextBox months)
        {
            bool monthsValid = true;
            //check for null values
            if (months.Text.Trim().Length == 0) //period in # of months not entered
                monthsValid = false;
            return monthsValid;
        }

        //define frequency as radio buttons are selected for salary pay
        private void input_CheckedChanged(object sender, EventArgs e)
        {
            //radio buttons to determine how salary frequency labels are displayed for each state tab
            if (tabArizona.Focus() == true)
                Validate_RadioButton("AZ", rdbAnnualAZ, rdbBiweeklyAZ, lblWeeklyHoursAZ, lblPayAZ, lblPayDetailsAZ, txtWeeklyHoursAZ, txtPayAZ);
            if (tabNevada.Focus() == true)
                Validate_RadioButton("NV", rdbAnnualNV, rdbBiweeklyNV, lblWeeklyHoursNV, lblPayNV, lblPayDetailsNV, txtWeeklyHoursNV, txtPayNV);
            if (tabUtah.Focus() == true)
                Validate_RadioButton("UT", rdbAnnualUT, rdbBiweeklyUT, lblWeeklyHoursUT, lblPayUT, lblPayDetailsUT, txtWeeklyHoursUT, txtPayUT);

            //Clear salary when radio button selection changes
            if (sender == rdbAnnualAZ || sender == rdbBiweeklyAZ)
                txtPayAZ.Clear();
            if (sender == rdbAnnualNV || sender == rdbBiweeklyNV)
                txtPayNV.Clear();
            if (sender == rdbAnnualUT || sender == rdbBiweeklyUT)
                txtPayUT.Clear();
        }

        private void tblSalaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSalaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }

        //method to verify the limits for number of months and salary amount
        private bool[] Verify_Locations_Months_Salary(double AZmonths, double AZsalary, double NVmonths, double NVsalary, double UTmonths, double UTsalary)
        {
            //variable for verifying
            bool calendarYear = true;
            bool salaryMax = false;
            bool AZ = false, NV = false, UT = false;

            //only check for unhidden tabs
            if (appData[2] == 1.ToString() && appData[3] == 1.ToString() && appData[4] == 1.ToString()) //All three
            {
                AZ = true;
                NV = true;
                UT = true;
                if (AZmonths + NVmonths + UTmonths > 12)
                    calendarYear = false;
                if (((AZsalary * monthsAZ) / 12) + ((NVsalary * monthsNV) / 12) + ((UTsalary * monthsUT) / 12) > 100000 && calendarYear)
                    salaryMax = true;
            }
            else if (appData[2] == 1.ToString() && appData[3] == 1.ToString() && appData[4] != 1.ToString()) //AZ & NV
            {
                AZ = true;
                NV = true;
                if (AZmonths + NVmonths > 12)
                    calendarYear = false;
                if (((AZsalary * monthsAZ) / 12) + ((NVsalary * monthsNV) / 12) > 100000 && calendarYear)
                    salaryMax = true;
            }
            else if (appData[2] == 1.ToString() && appData[3] != 1.ToString() && appData[4] == 1.ToString()) //AZ & UT
            {
                AZ = true;
                UT = true;
                if (AZmonths + UTmonths > 12)
                    calendarYear = false;
                if (((AZsalary * monthsAZ) / 12) + ((UTsalary * monthsUT) / 12) > 100000 && calendarYear)
                    salaryMax = true;
            }
            else if (appData[2] != 1.ToString() && appData[3] == 1.ToString() && appData[4] == 1.ToString()) //NV & UT
            {
                NV = true;
                UT = true;
                if (NVmonths + UTmonths > 12)
                    calendarYear = false;
                if (((NVsalary * monthsNV) / 12) + ((UTsalary * monthsUT) / 12) > 100000 && calendarYear)
                    salaryMax = true;
            }
            else if (appData[2] == 1.ToString() && appData[3] != 1.ToString() && appData[4] != 1.ToString()) //AZ only
            {
                AZ = true;
                if (AZmonths > 12)
                    calendarYear = false;
                if (AZsalary > 100000 && calendarYear)
                    salaryMax = true;
            }
            else if (appData[2] != 1.ToString() && appData[3] == 1.ToString() && appData[4] != 1.ToString()) //NV only
            {
                NV = true;
                if (NVmonths > 12)
                    calendarYear = false;
                if (NVsalary > 100000 && calendarYear)
                    salaryMax = true;
            }
            else if (appData[2] != 1.ToString() && appData[3] != 1.ToString() && appData[4] == 1.ToString()) //UT only
            {
                UT = true;
                if (UTmonths > 12)
                    calendarYear = false;
                if (UTsalary > 100000 && calendarYear)
                    salaryMax = true;
            }
            bool[] valid = { calendarYear, salaryMax, AZ, NV, UT };
            return valid;
        }

        //method to get federal tax rates from database
        private double[] Get_Federal_Rates()
        {
            //variables for output values
            double FICA_SS = 0, FICA_Medicare = 0, FUTA = 0;

            //get the tax calculation rates from datatable
            FICA_SS = Convert.ToDouble(this.tblFederalRatesTableAdapter.GetFederalRate("FICA_SS"));
            FICA_Medicare = Convert.ToDouble(this.tblFederalRatesTableAdapter.GetFederalRate("FICA_Medicare"));
            FUTA = Convert.ToDouble(this.tblFederalRatesTableAdapter.GetFederalRate("FUTA"));

            double[] fedrRates = { FICA_SS, FICA_Medicare, FUTA };
            return fedrRates;
        }

        private double Get_Federal_Withholding_Amount(double salary, double weekHours, double allowances, string frequency)
        {
            //define variables and values for calculation
            double fedWHAmount = 0;
            double withholdSalary = 0, salaryLowBound = 0, excessWHSalary = 0, initialWHAmount = 0, withholdPct = 0;
            const double BIWEEK_ALLOWANCE_AMT = 155.80; //from IRS
            const double ANNUAL_ALLOWANCE_AMT = 4050; //from IRS
            //remove exempt amount before getting amount to check for withholding
            if (frequency == "A") //annual
                withholdSalary = salary - (ANNUAL_ALLOWANCE_AMT * allowances);
            if (frequency == "B") //biweekly
                withholdSalary = (salary * weekHours * 2) - (BIWEEK_ALLOWANCE_AMT * allowances);
            //RECALL: appdata[5] has marital status information

            //get the initial withheld amount from database
            initialWHAmount = Convert.ToDouble(this.tblFederalWHTableAdapter.GetInitialFedWH(appData[5], frequency, salary, salary));
            //get low bound of salary bracket before getting excess to deduct from
            salaryLowBound = Convert.ToDouble(this.tblFederalWHTableAdapter.GetLowBound(appData[5], frequency, salary, salary));
            //get excess amount above low bound to deduct additional % withhold amount
            excessWHSalary = withholdSalary - salaryLowBound;
            //get percentage to withhold from excess amount
            withholdPct = Convert.ToDouble(this.tblFederalWHTableAdapter.GetAdditionalWHPct(appData[5], frequency, salary, salary));
            //get additional percentage to withhold and combine with initial withheld amount to get total federal WH
            fedWHAmount = (initialWHAmount + (excessWHSalary * withholdPct)) * -1;
            return fedWHAmount;
        }

        //method to calculate federal taxes 
        private double[] Calculate_Federal_Taxes(string frequency, double aSalary, double weekHours, double allowances)
        {
            //variables for tax calculation rates and salary
            double[] fedrRates = Get_Federal_Rates();

            //output variables
            double taxFICA_SS, taxFICA_SS_ER, taxFICAMedicare, taxFICAMedicare_ER, taxFUTA, taxFedWH = 0;

            //calculate all taxes owed based on duration of work
            //recall order from federal Rates method {FICASS, FICAMedicare, FUTA}
            taxFICA_SS = (aSalary * fedrRates[0] * -1);
            taxFICA_SS_ER = (aSalary * fedrRates[0]);
            taxFICAMedicare = (aSalary * fedrRates[1] * -1);
            taxFICAMedicare_ER = (aSalary * fedrRates[1]);
            if (aSalary * fedrRates[2] > 7000)
                taxFUTA = 7000; //unemployment tax is 6% up to 7000 USD
            else taxFUTA = (aSalary * fedrRates[2]);

            //get federal tax withheld amount based on user data from FedWH method
            taxFedWH = Get_Federal_Withholding_Amount(aSalary, weekHours, allowances, frequency);

            //store the tax calculation values in an array
            double[] fedTaxes = { taxFICA_SS, taxFICA_SS_ER, taxFICAMedicare, taxFICAMedicare_ER, taxFedWH, taxFUTA };
            return fedTaxes;
        }

        //method to get state tax rates from database
        private double[] Get_State_Rates(string marStatus, string state, double aSalary, double weekHours)
        {
            //variables and arrays for storing tax rates and salary
            double AZ_SUTA = 0, NV_SUTA = 0, UT_SUTA = 0; //SUTA tax rates
            double AZ_StateWH = 0, NV_StateWH = 0, UT_StateWH = 0; //State withholding rates

            //get state rates from database
            //State Unemployment rates
            AZ_SUTA = Convert.ToDouble(this.tblSUTARatesTableAdapter.GetSUTArate("AZ"));
            NV_SUTA = Convert.ToDouble(this.tblSUTARatesTableAdapter.GetSUTArate("NV"));
            UT_SUTA = Convert.ToDouble(this.tblSUTARatesTableAdapter.GetSUTArate("UT"));

            //State tax withholding rates (NV doesnt have state tax, stays at 0)
            //recall the order of items stored in array: appData: appData[5] = marital status

            //Arizona withholding
            AZ_StateWH = Convert.ToDouble(this.tblStateWHTableAdapter.GetAZStateWH
                (appData[5], aSalary));
            //NV = 0 stays the same, line in databasefor easier management
            NV_StateWH = Convert.ToDouble(this.tblStateWHTableAdapter.GetStateWH_NV_UT(appData[5], "NV"));
            UT_StateWH = Convert.ToDouble(this.tblStateWHTableAdapter.GetStateWH_NV_UT(appData[5], "UT"));
            //arrays to store annualized salary and tax values by state
            double[] AZtaxRates = { aSalary, AZ_StateWH, AZ_SUTA };
            double[] NVtaxRates = { aSalary, NV_StateWH, NV_SUTA };
            double[] UTtaxRates = { aSalary, UT_StateWH, UT_SUTA };
            double[] placeHold = { 0, 0, 0 }; //mitigating error

            //return array based on states selected by user
            //recall the order of items stored in array: appData
            //username, name, state1(AZ), state2(NV), state3(UT), marital status
            if (state == "AZ")
                return AZtaxRates;
            else if (state == "NV")
                return NVtaxRates;
            else if (state == "UT")
                return UTtaxRates;
            else
                return placeHold;
        }

        //method to calculate state taxes 
        private double[] Calculate_State_Taxes(string state, double months)
        {
            //define variables for tax amounts and input variables
            double weekHoursAZ = 0, weekHoursNV = 0, weekHoursUT = 0;
            double AZtaxSUTA = 0, NVtaxSUTA = 0, UTtaxSUTA = 0, AZtaxWH = 0, NVtaxWH = 0, UTtaxWH = 0; //output values

            //define weeklyHours by state
            if (txtWeeklyHoursAZ.Text.Trim().Length != 0)
                weekHoursAZ = double.Parse(txtWeeklyHoursAZ.Text.Trim());
            if (txtWeeklyHoursNV.Text.Trim().Length != 0)
                weekHoursAZ = double.Parse(txtWeeklyHoursNV.Text.Trim());
            if (txtWeeklyHoursUT.Text.Trim().Length != 0)
                weekHoursAZ = double.Parse(txtWeeklyHoursUT.Text.Trim());

            //get state taxes for each state and store them in an array
            //recall order of state tax rate arrays: annualized salary, StateWH, SUTA
            //recall order of appData array: appData[5] = marital status
            double[] AZtaxRates = Get_State_Rates(appData[5], "AZ", salaryAZ, weekHoursAZ);
            double[] NVtaxRates = Get_State_Rates(appData[5], "NV", salaryNV, weekHoursNV);
            double[] UTtaxRates = Get_State_Rates(appData[5], "UT", salaryUT, weekHoursUT);
            double[] placeHold = { 0, 0, 0 }; //empty for if state doesnt apply
            double[] stateTaxes;

            //calculate state taxes for each state and store and return them in an array
            //recall annualized salary from get rates method has index 0 for all states
            //calculate amounts: states will be numbered 1(AZ), 2(NV), 3(UT)
            if (state == "AZ")
            {
                AZtaxWH = AZtaxRates[0] * (AZtaxRates[1] / 100.0) * -1 / months;
                AZtaxSUTA = AZtaxRates[0] * (AZtaxRates[2]) / months;
                //array to store and return values
                double[] AZtaxes = { AZtaxWH, AZtaxSUTA };
                stateTaxes = AZtaxes;
            }
            else if (state == "NV")
            {
                NVtaxWH = NVtaxRates[0] * (NVtaxRates[1] / 100) * -1 / months;
                NVtaxSUTA = NVtaxRates[0] * (NVtaxRates[2]) / months;
                //array to store and return values
                double[] NVtaxes = { NVtaxWH, NVtaxSUTA };
                stateTaxes = NVtaxes;
            }
            else if (state == "UT")
            {
                UTtaxWH = UTtaxRates[0] * (UTtaxRates[1] / 100) * -1 / months;
                UTtaxSUTA = UTtaxRates[0] * (UTtaxRates[2]) / months;
                //array to store and return values
                double[] UTtaxes = { UTtaxWH, UTtaxSUTA };
                stateTaxes = UTtaxes;
            }
            else
                stateTaxes = placeHold;
            return stateTaxes;
        }

        private void hsbAllowances_Scroll(object sender, ScrollEventArgs e)
        {
            //update values as they are selected
            lblAllowancesAZ.Text = hsbAllowancesAZ.Value.ToString();
            lblAllowancesNV.Text = hsbAllowancesNV.Value.ToString();
            lblAllowancesUT.Text = hsbAllowancesUT.Value.ToString();
        }

        private void btnContinueAZ_Click(object sender, EventArgs e)
        {
            //validate and get inputs needed for calculations
            if (!Validate_Frequency("AZ", rdbAnnualAZ, rdbBiweeklyAZ))
                MessageBox.Show(FREQ_NULL_ERR + "AZ", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!Validate_Pay("AZ", txtPayAZ))
            {
                MessageBox.Show(SALARY_NULL_ERR + "AZ", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPayAZ.Focus();
            }
            else if (txtWeeklyHoursAZ.Text.Trim().Length == 0 && rdbBiweeklyAZ.Checked)
            {
                MessageBox.Show(HOURS_NULL_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWeeklyHoursAZ.Focus();
            }
            else if (!Validate_Months("AZ", txtMonthsWorkedAZ))
            {
                MessageBox.Show(MONTHS_NULL_ERR + "AZ", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonthsWorkedAZ.Focus();
            }
            else
            {
                //define values
                formW4_AllowancesAZ = (hsbAllowancesAZ.Value + hsbAllowancesNV.Value + hsbAllowancesUT.Value);
                monthsAZ = double.Parse(txtMonthsWorkedAZ.Text.Trim());
                Validate_RadioButton("AZ", rdbAnnualAZ, rdbBiweeklyAZ, lblWeeklyHoursAZ, lblPayAZ, lblPayDetailsAZ, txtWeeklyHoursAZ, txtPayAZ);
                if (rdbAnnualAZ.Checked)
                    frequencyAZ = "A";
                if (rdbBiweeklyAZ.Checked)
                    frequencyAZ = "B";
                salaryAZ = double.Parse(txtPayAZ.Text.Trim());
                AZweekHours = Validate_Hours(rdbBiweeklyAZ, txtWeeklyHoursAZ);
                if (frequencyAZ == "B") //biweekly
                    salaryAZ = salaryAZ * AZweekHours * 52;//annualized

                //calculate taxes and store values in array if all values are valid
                fedTaxesAZ = Calculate_Federal_Taxes(frequencyAZ, salaryAZ, AZweekHours, formW4_AllowancesAZ);
                stateTaxesAZ = Calculate_State_Taxes("AZ", monthsAZ);

                //store user's salary information in an array
                AZsalary[0] = appData[0]; AZsalary[1] = formW4_AllowancesAZ.ToString();
                AZsalary[2] = salaryAZ.ToString(); //annualized salary
                AZsalary[3] = txtPayAZ.Text; //salary as given
                AZsalary[4] = frequencyAZ; AZsalary[5] = AZweekHours.ToString(); AZsalary[6] = monthsAZ.ToString();

                //check for more states/tabs/salary and months errors or go to the review page
                if (appData[3] != 1.ToString())
                {
                    fedTaxesNV[0] = 0; fedTaxesNV[1] = 0; fedTaxesNV[2] = 0; fedTaxesNV[3] = 0; fedTaxesNV[4] = 0; fedTaxesNV[5] = 0;
                    stateTaxesNV[0] = 0; stateTaxesNV[1] = 0;
                }
                else if (appData[4] != 1.ToString()) //UT not selected
                {
                    //fill empty arrays
                    fedTaxesUT[0] = 0; fedTaxesUT[1] = 0; fedTaxesUT[2] = 0; fedTaxesUT[3] = 0; fedTaxesUT[4] = 0; fedTaxesUT[5] = 0;
                    stateTaxesUT[0] = 0; stateTaxesUT[1] = 0;
                }
                if (appData[3] == 1.ToString()) //NV also selected
                    tabPayrollTaxApplication.SelectedTab = tabNevada; //go to tabNevada
                else if (appData[4] == 1.ToString()) //UT is also selected
                    tabPayrollTaxApplication.SelectedTab = tabUtah; //go to tabUtah
                else
                {
                    //check for salary and months errors or calculate taxes
                    multipleTabs = Verify_Locations_Months_Salary(monthsAZ, salaryAZ, monthsNV, salaryNV, monthsUT, salaryUT);
                    //check for entry errors before proceeding
                    if (multipleTabs[1] == true)
                    {
                        MessageBox.Show(SALARY_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPayAZ.Focus(); txtPayAZ.SelectAll();
                    }
                    else if (multipleTabs[0] == false)
                    {
                        MessageBox.Show(MONTHS_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMonthsWorkedAZ.Focus(); txtMonthsWorkedAZ.SelectAll();
                    }
                    else
                    {
                        MessageBox.Show(REVIEW_MSG, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show(REVIEW_QUESTION, Program.APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            //create review page instance where all user data and tax calculated values will be displayed
                            Form_Review frmReview = new Form_Review(appData, AZsalary, NVsalary, UTsalary, fedTaxesAZ, fedTaxesNV, fedTaxesUT, stateTaxesAZ, stateTaxesNV, stateTaxesUT);
                            //show the review form
                            frmReview.Show();
                            //hide current form
                            this.Hide();
                            //placeholder for previous form
                            Program.previousPage = this;


                        }
                    }
                }
            }
        }

        private void btnContinueNV_Click(object sender, EventArgs e)
        {
            //validate and get inputs needed for calculations
            if (!Validate_Frequency("NV", rdbAnnualNV, rdbBiweeklyNV))
                MessageBox.Show(FREQ_NULL_ERR + "NV", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!Validate_Pay("NV", txtPayNV))
            {
                MessageBox.Show(SALARY_NULL_ERR + "NV", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPayNV.Focus();
            }
            else if (txtWeeklyHoursNV.Text.Trim().Length == 0 && rdbBiweeklyNV.Checked)
            {
                MessageBox.Show(HOURS_NULL_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWeeklyHoursNV.Focus();
            }
            else if (!Validate_Months("NV", txtMonthsWorkedNV))
            {
                MessageBox.Show(MONTHS_NULL_ERR + "NV", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonthsWorkedNV.Focus();
            }
            else
            { //define values
                formW4_AllowancesNV = (hsbAllowancesAZ.Value + hsbAllowancesNV.Value + hsbAllowancesUT.Value);
                monthsNV = double.Parse(txtMonthsWorkedNV.Text.Trim());
                Validate_RadioButton("NV", rdbAnnualNV, rdbBiweeklyNV, lblWeeklyHoursNV, lblPayNV, lblPayDetailsNV, txtWeeklyHoursNV, txtPayNV);
                if (rdbAnnualNV.Checked)
                    frequencyNV = "A";
                if (rdbBiweeklyNV.Checked)
                    frequencyNV = "B";
                salaryNV = double.Parse(txtPayNV.Text.Trim());
                NVweekHours = Validate_Hours(rdbBiweeklyNV, txtWeeklyHoursNV);
                if (frequencyNV == "B") //biweekly
                    salaryNV = salaryNV * NVweekHours * 52;//annualized               

                //calculate taxes and store values in array if all values are valid
                fedTaxesNV = Calculate_Federal_Taxes(frequencyNV, salaryNV, NVweekHours, formW4_AllowancesNV);
                stateTaxesNV = Calculate_State_Taxes("NV", monthsNV);
                //store user's salary information in an array
                NVsalary[0] = appData[0]; NVsalary[1] = formW4_AllowancesNV.ToString();
                NVsalary[2] = salaryNV.ToString(); //annualized salary
                NVsalary[3] = txtPayNV.Text; //salary as given
                NVsalary[4] = frequencyNV; NVsalary[5] = NVweekHours.ToString(); NVsalary[6] = monthsNV.ToString();

                //check for more states/tabs/salary and months errors or go to the review page
                if (appData[2] != 1.ToString()) //AZ is not selected
                {
                    fedTaxesAZ[0] = 0; fedTaxesAZ[1] = 0; fedTaxesAZ[2] = 0; fedTaxesAZ[3] = 0; fedTaxesAZ[4] = 0; fedTaxesAZ[5] = 0;
                    stateTaxesAZ[0] = 0; stateTaxesAZ[1] = 0;
                }
                if (appData[4] == 1.ToString()) //UT is also selected
                    tabPayrollTaxApplication.SelectedTab = tabUtah; //go to tabUtah
                else
                {
                    //fill empty arrays
                    fedTaxesUT[0] = 0; fedTaxesUT[1] = 0; fedTaxesUT[2] = 0; fedTaxesUT[3] = 0; fedTaxesUT[4] = 0; fedTaxesUT[5] = 0;
                    stateTaxesUT[0] = 0; stateTaxesUT[1] = 0;
                    //check for salary and months errors or calculate taxes
                    multipleTabs = Verify_Locations_Months_Salary(monthsAZ, salaryAZ, monthsNV, salaryNV, monthsUT, salaryUT);
                    //check for entry errors before proceeding
                    if (multipleTabs[1] == true)
                    {
                        MessageBox.Show(SALARY_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPayNV.Focus(); txtPayNV.SelectAll();
                    }
                    else if (multipleTabs[0] == false)
                    {
                        MessageBox.Show(MONTHS_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMonthsWorkedNV.Focus(); txtMonthsWorkedNV.SelectAll();
                    }
                    else
                    {
                        MessageBox.Show(REVIEW_MSG, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (MessageBox.Show(REVIEW_QUESTION, Program.APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {

                            //create review page instance where all user data and tax calculated values will be displayed
                            Form_Review frmReview = new Form_Review(appData, AZsalary, NVsalary, UTsalary, fedTaxesAZ, fedTaxesNV, fedTaxesUT, stateTaxesAZ, stateTaxesNV, stateTaxesUT);
                            //show the review form
                            frmReview.Show();
                            //hide current form
                            this.Hide();
                            //placeholder for previous form
                            Program.previousPage = this;

                        }
                    }
                }
            }
        }

        private void btnContinueUT_Click(object sender, EventArgs e)
        {
            //validate and get inputs needed for calculations
            if (!Validate_Frequency("UT", rdbAnnualUT, rdbBiweeklyUT))
                MessageBox.Show(FREQ_NULL_ERR + "UT", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (!Validate_Pay("UT", txtPayUT))
            {
                MessageBox.Show(SALARY_NULL_ERR + "UT", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPayUT.Focus();
            }
            else if (txtWeeklyHoursUT.Text.Trim().Length == 0 && rdbBiweeklyUT.Checked)
            {
                MessageBox.Show(HOURS_NULL_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtWeeklyHoursUT.Focus();
            }
            else if (!Validate_Months("UT", txtMonthsWorkedUT))
            {
                MessageBox.Show(MONTHS_NULL_ERR + "UT", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonthsWorkedUT.Focus();
            }
            else
            {  //define variables
                formW4_AllowancesUT = (hsbAllowancesAZ.Value + hsbAllowancesNV.Value + hsbAllowancesUT.Value);
                monthsUT = double.Parse(txtMonthsWorkedUT.Text.Trim());
                Validate_RadioButton("UT", rdbAnnualUT, rdbBiweeklyUT, lblWeeklyHoursUT, lblPayUT, lblPayDetailsUT, txtWeeklyHoursUT, txtPayUT);
                if (rdbAnnualUT.Checked)
                    frequencyUT = "A";
                if (rdbBiweeklyUT.Checked)
                    frequencyUT = "B";
                salaryUT = double.Parse(txtPayUT.Text.Trim());
                UTweekHours = Validate_Hours(rdbBiweeklyUT, txtWeeklyHoursUT);
                if (frequencyUT == "B") //biweekly
                    salaryUT = salaryUT * UTweekHours * 52;//annualized

                //calculate taxes and store values in array if all values are valid
                fedTaxesUT = Calculate_Federal_Taxes(frequencyUT, salaryUT, UTweekHours, formW4_AllowancesUT);
                stateTaxesUT = Calculate_State_Taxes("UT", monthsUT);
                //store user's salary information in an array
                UTsalary[0] = appData[0]; UTsalary[1] = formW4_AllowancesUT.ToString();
                UTsalary[2] = salaryUT.ToString(); //annualized salary
                UTsalary[3] = txtPayUT.Text; //salary as given
                UTsalary[4] = frequencyUT; UTsalary[5] = UTweekHours.ToString(); UTsalary[6] = monthsUT.ToString();

                //check for salary and months errors or calculate taxes
                multipleTabs = Verify_Locations_Months_Salary(monthsAZ, salaryAZ, monthsNV, salaryNV, monthsUT, salaryUT);
                //check for null values
                if (appData[2] != 1.ToString()) //AZ is not selected
                {
                    fedTaxesAZ[0] = 0; fedTaxesAZ[1] = 0; fedTaxesAZ[2] = 0; fedTaxesAZ[3] = 0; fedTaxesAZ[4] = 0; fedTaxesAZ[5] = 0;
                    stateTaxesAZ[0] = 0; stateTaxesAZ[1] = 0;
                }
                if (appData[3] != 1.ToString()) //NV is not selected
                {
                    fedTaxesNV[0] = 0; fedTaxesNV[1] = 0; fedTaxesNV[2] = 0; fedTaxesNV[3] = 0; fedTaxesNV[4] = 0; fedTaxesNV[5] = 0;
                    stateTaxesNV[0] = 0; stateTaxesNV[1] = 0;
                }
                //check for entry errors before proceeding
                if (multipleTabs[1] == true)
                {
                    MessageBox.Show(SALARY_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPayUT.Focus(); txtPayUT.SelectAll();
                }
                else if (multipleTabs[0] == false)
                {
                    MessageBox.Show(MONTHS_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMonthsWorkedUT.Focus(); txtMonthsWorkedUT.SelectAll();
                }
                else
                {
                    MessageBox.Show(REVIEW_MSG, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show(REVIEW_QUESTION, Program.APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        //create review page instance where all user data and tax calculated values will be displayed
                        Form_Review frmReview = new Form_Review(appData, AZsalary, NVsalary, UTsalary, fedTaxesAZ, fedTaxesNV, fedTaxesUT, stateTaxesAZ, stateTaxesNV, stateTaxesUT);
                        //show the review form
                        frmReview.Show();
                        //hide current form
                        this.Hide();
                        //placeholder for previous form
                        Program.previousPage = this;

                    }

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go to the previous form
            this.Hide();
            Program.previousPage.Show();
        }
    }
}
