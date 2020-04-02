/* Name: Payroll Tax Calculator
 *      Section: Review Page
 * Purpose: On this page, the user can review the calculations and download or save them to their profile. For profiles, the values will be saved into a database table which has their
 *          salary and employment information (tblSalary). The users are also able to download the items on the review page onto a pdf document. In this instance, the guest user does
 *          see the option to save the data; only to download.
 * Programmer: Sia Mbatia
 * Date: November 23rd, 2018
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using PayRollTaxCalculator;

namespace Payroll_Tax_Application
{
    public partial class Form_Review : Form
    {
        //define arrays to get data from previous form
        //users data order: username, name, state1(AZ), state2(NV), state3(UT), marital status
        string[] usersData;
        //username, allowances, annualized salary, salary, frequency, weekHours, months
        string[] AZsalary; string[] NVsalary; string[] UTsalary;
        //fed taxes order: taxFICA_SS, taxFICA_SS_ER, taxFICAMedicare, taxFICAMedicare_ER, taxFedWH, taxFUTA
        double[] AZfedTaxes; double[] NVfedTaxes; double[] UTfedTaxes;
        //state taxes order: AZtaxWH, AZtaxSUTA 
        double[] AZstateTaxes; double[] NVstateTaxes; double[] UTstateTaxes;

        //define messages for UI
        const string GUEST_NOTE = "Please review your tax calculation below before exporting the results.";
        const string USER_NOTE = "Please review your tax calculation below before exporting or saving the results.";
        const string THANK_YOU = "Thank you for using the Payroll Tax Calculator App! Please take a snapshot of the screen for your records";

        //arrays for headers for salaries and tax categories
        string[] headers = { "Tax Category", "Total", "Monthly", "Bi-weekly" };
        string[] summary = { "Salary", "Federal Taxes", "State Taxes", "Net Pay" };
        //order from array of values: taxFICA_SS, ER FICA_SS, taxFICAMedicare, ER Medicare, taxFedWH, taxFUTA
        string[] federalSection = { "FICA Social Security - EE", "FICA Social Security - ER", "FICA Medicare - EE",
                         "FICA Medicare - ER","Federal Income Tax Withholding", "Federal Unemployment (FUTA-ER)"};
        string[] stateSection = { "State Withholding", "State Unemployment (SUTA-ER)" }; //same order as array of values

        //placeholder array for null values
        string[] salaryNull = { "User", "0", "0", "0", "", "0", "0" };
        double[] fedNull = {  0, 0, 0, 0, 0, 0 };
        double[] stateNull = { 0, 0 };
        //salaries and months for each state
        double monthsAZ, monthsNV, monthsUT;
        double salaryAZ = 0, salaryNV = 0, salaryUT = 0, salaries = 0, netSalaries = 0;
        double fedTotal = 0, stateTotal = 0;

        public Form_Review(string[] users, string[] salaryAZ, string[] salaryNV, string[] salaryUT,
            double[] fedTaxesAZ, double[]fedTaxesNV, double[] fedTaxesUT, double[] stateTaxesAZ, double[] stateTaxesNV, double[]stateTaxesUT)
        {
            InitializeComponent();

            //get data from previous form calculations
            usersData = users;
            AZsalary = salaryAZ; NVsalary = salaryNV; UTsalary = salaryUT;
            AZfedTaxes = fedTaxesAZ; NVfedTaxes = fedTaxesNV; UTfedTaxes = fedTaxesUT;
            AZstateTaxes = stateTaxesAZ; NVstateTaxes = stateTaxesNV; UTstateTaxes = stateTaxesUT;
        }

        //method to check for empty arrays in cases where states were not selected
        private void Check_Null_Values()
        {
            //search salary arrays for non-applicable states to fill with placeholder
            if (usersData[2] != 1.ToString())
            {
                AZsalary = salaryNull;
                AZfedTaxes = fedNull;
                AZstateTaxes = stateNull;
            } 
            if (usersData[3] != 1.ToString())
            {
                NVsalary = salaryNull;
                NVfedTaxes = fedNull;
                NVstateTaxes = stateNull;
            }                
            if (usersData[4] != 1.ToString())
            {
                UTsalary = salaryNull;
                UTfedTaxes = fedNull;
                UTstateTaxes = stateNull;
            }

            //get values for months and salary
            monthsAZ = double.Parse(AZsalary[6]); monthsNV = double.Parse(NVsalary[6]); monthsUT = double.Parse(UTsalary[6]);
            salaryAZ = double.Parse(AZsalary[2]); salaryNV = double.Parse(NVsalary[2]); salaryUT = double.Parse(UTsalary[2]);

        }

        private void Form_Review_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close application
            Application.Exit();
        }

        //state count
        int count = 0;

        //method to display employee data
        private void Fill_Employee_Data(string state, string[] salaryData)
        {
            //Fill Salary details on top left of review form
            //recall salary order of elements in array
            //username, allowances, annualized salary, salary, frequency, weekHours, months
            if (salaryData[4] == "A")
            {
                lblStateDetails.Text += state + " - " + salaryData[6] + " months";
                lblStateDetails.Text += "   \tSalary: " + double.Parse(salaryData[3]).ToString("C2");
                lblStateDetails.Text += "   \tPay Frequency: Annual";
            }
            else if (salaryData[4] == "B")
            {
                lblStateDetails.Text += state + " - " + salaryData[6] + " months";
                lblStateDetails.Text += "  \tSalary: " + double.Parse(salaryData[3]).ToString("C2") + "/ hour (" + salaryData[5] + " hrs per week)";
                lblStateDetails.Text += "  \tPay Frequency: Bi-weekly";
            }
        }

        //method to get salary net and gross breakdown
        private ListViewGroup Load_Salary_Breakdown()
        {
            count = int.Parse(usersData[2].ToString()) + int.Parse(usersData[3].ToString()) + int.Parse(usersData[4].ToString());

            //get salaries and months for each state
            monthsAZ = double.Parse(AZsalary[6]); monthsNV = double.Parse(NVsalary[6]); monthsUT = double.Parse(UTsalary[6]);
            salaryAZ = double.Parse(AZsalary[2]); salaryNV = double.Parse(NVsalary[2]); salaryUT = double.Parse(UTsalary[2]);

            //strings for storing values to add to list view
            string salDisplayT = "", salDisplayM = "", salDisplayB = "";
            string netSalDisplayT = "", netSalDisplayM = "", netSalDisplayB = "";

            //Salary: (Sal)
            //convert annualized salary into period amounts and total them
            salaries = ((salaryAZ * monthsAZ) + (salaryNV * monthsNV) + (salaryUT * monthsUT)) / 12;
            salDisplayT = (salaries).ToString("C2");
            salDisplayM = (salaries / (monthsAZ + monthsNV + monthsUT)).ToString("C2");
            salDisplayB = (salaries / ((monthsAZ + monthsNV + monthsUT) * 2)).ToString("C2");
            //store in array and add as listview item to summary view
            string[] salary = { "Gross Salary", salDisplayT, salDisplayM, salDisplayB };
            ListViewItem salaryLVI = new ListViewItem(salary);

            //Federal taxes: only employee portions and fedWH
            for (int i = 0; i < federalSection.Length; i++)
            {
                fedTotal += (AZfedTaxes[i] + NVfedTaxes[i] + UTfedTaxes[i]) / count;
                i++;
            }
            //State taxes: only withholding
            stateTotal += AZstateTaxes[0] + NVstateTaxes[0] + UTstateTaxes[0];
            //deduct from gross salary
            //Net Pay (Take Home) = Gross Pay - taxes; get breakdown
            netSalaries = salaries + fedTotal + stateTotal;
            netSalDisplayT = netSalaries.ToString("C2");
            netSalDisplayM = (netSalaries / (monthsAZ + monthsNV + monthsUT)).ToString("C2");
            netSalDisplayB = (netSalaries / ((monthsAZ + monthsNV + monthsUT) * 2)).ToString("C2");
            //store in array and add as listview item
            string[] netSal = { "Net Salary (Take Home Amount)", netSalDisplayT, netSalDisplayM, netSalDisplayB };
            ListViewItem netSalLVI = new ListViewItem(netSal);

            //create listview group to place items in
            ListViewGroup comp = new ListViewGroup("U.S. Payroll Base Compensation", HorizontalAlignment.Left);
            salaryLVI.Group = comp;
            netSalLVI.Group = comp;
            this.lvwSummary.Items.AddRange(new ListViewItem[] { salaryLVI, netSalLVI });
            //return list viewgroup
            return comp;
        }

        private void tblSalaryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSalaryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.MainPage.Show();
        }



        //method to create federal tax section listview items
        private ListViewItem Load_Federal_Summary(int index)
        {
            //check null values and fill month and salary information
            Check_Null_Values();
            count = int.Parse(usersData[2].ToString()) + int.Parse(usersData[3].ToString()) + int.Parse(usersData[4].ToString());
            //fed taxes order: taxFICA_SS, taxFICA_SS_ER, taxFICAMedicare, taxFICAMedicare_ER, taxFedWH, taxFUTA
            double fedCategory = 0;
            string fedCatDisplayT = ""; string fedCatDisplayM = ""; string fedCatDisplayB = "";
            ListViewItem fedCatLVI;

            //breakdown each value
            //Federal Taxes - Calculated as total with all salaries from all states already
            //get the total tax value for all locations
            fedCategory = (AZfedTaxes[index] + NVfedTaxes[index] + UTfedTaxes[index]) * (monthsAZ + monthsNV + monthsUT) / (count * 12);
            //get all of the breakdowns
            fedCatDisplayT = fedCategory.ToString("C2");
            fedCatDisplayM = (fedCategory / (monthsAZ + monthsNV + monthsUT)).ToString("C2");
            fedCatDisplayB = (((fedCategory / (monthsAZ + monthsNV + monthsUT)) / 2)).ToString("C2");
            //store in array and add as listview item
            string[] fedCat = { federalSection[index], fedCatDisplayT, fedCatDisplayM, fedCatDisplayB };
            //convert the display array into a list view item and add it to the desired list view
            fedCatLVI = new ListViewItem(fedCat);

            //get list view item
            return fedCatLVI;
        }

        //method to create state tax section listview items
        private ListViewItem Load_State_Summary(double[] stateTax, double months, string state, int index)
        {
            //state taxes
            //output variables
            string STDisplayT = "", STDisplayM = "", STDisplayB = "";
            //State Taxes - each category; get breakdown
            stateTotal = stateTax[index];
            STDisplayT = stateTotal.ToString("C2");
            STDisplayM = (stateTotal / months).ToString("C2");
            STDisplayB = (stateTotal / (months * 2)).ToString("C2");
            //store in array and add as listview item
            string[] stateVal = { stateSection[index] + " - " + state, STDisplayT, STDisplayM, STDisplayB };
            ListViewItem stateLVI = new ListViewItem(stateVal);

            //get list view item for state taxes
            return stateLVI;
        }

        //method to display user data and section headers in list view
        private void Add_UserData_SectionHeaders()
        {
            lvwSummary.Columns.Add(" ", 220, HorizontalAlignment.Left);
            lvwSummary.Columns.Add(headers[1], 85, HorizontalAlignment.Right);
            lvwSummary.Columns.Add(headers[2], 85, HorizontalAlignment.Right);
            lvwSummary.Columns.Add(headers[3], 85, HorizontalAlignment.Right);

            //Add user data section
            //Fill User details on top left of review form
            lblUserDetails.Text = "";
            lblUserDetails.Text += usersData[1] + "\nState(s): ";

            //states
            if (usersData[2] == 1.ToString())
                lblUserDetails.Text += "AZ  ";
            if (usersData[3] == 1.ToString())
                lblUserDetails.Text += "NV  ";
            if (usersData[4] == 1.ToString())
                lblUserDetails.Text += "UT  ";

            //marital status
            lblUserDetails.Text += "\nMarital Status: " + usersData[5];
            //allowances
            count = int.Parse(usersData[2].ToString()) + int.Parse(usersData[3].ToString()) + int.Parse(usersData[4].ToString());
            lblUserDetails.Text += "\nForm W-4 Allowances: " + ((double.Parse(AZsalary[1]) + double.Parse(NVsalary[1]) + double.Parse(UTsalary[1])) / count).ToString();
        }

        //method to group tax amounts and categories
        private ListViewGroup[] Group_Payroll()
        {
            //output variables
            ListViewItem AZ_LVI_WH = Load_State_Summary(AZstateTaxes, monthsAZ, "AZ", 0);
            ListViewItem NV_LVI_WH = Load_State_Summary(NVstateTaxes, monthsNV, "NV", 0);
            ListViewItem UT_LVI_WH = Load_State_Summary(UTstateTaxes, monthsUT, "UT", 0);
            ListViewItem AZ_LVI_suta = Load_State_Summary(AZstateTaxes, monthsAZ, "AZ", 1);
            ListViewItem NV_LVI_suta = Load_State_Summary(NVstateTaxes, monthsNV, "NV", 1);
            ListViewItem UT_LVI_suta = Load_State_Summary(UTstateTaxes, monthsUT, "UT", 1);
            ListViewItem FICA_SS_LVI = Load_Federal_Summary(0);
            ListViewItem FICA_Med_LVI = Load_Federal_Summary(2);
            ListViewItem FedWH_LVI = Load_Federal_Summary(4);
            ListViewItem FICA_SS_eR = Load_Federal_Summary(1);
            ListViewItem FICA_Med_eR = Load_Federal_Summary(3);
            ListViewItem FUTA_eR = Load_Federal_Summary(5);

            //create listview group to place items in
            ListViewGroup deductions = new ListViewGroup("U.S. Payroll Deductions & Withholdings", HorizontalAlignment.Left);
            ListViewGroup contributions = new ListViewGroup("U.S. Payroll Employer Contributions", HorizontalAlignment.Left);

            //Deductions
            FICA_SS_LVI.Group = deductions; FICA_Med_LVI.Group = deductions; FedWH_LVI.Group = deductions;
            FICA_SS_eR.Group = contributions; FICA_Med_eR.Group = contributions; FUTA_eR.Group = contributions;
            if (usersData[2] == 1.ToString() && usersData[3] == 1.ToString() && usersData[4] == 1.ToString()) //All states
            {
                AZ_LVI_WH.Group = deductions; NV_LVI_WH.Group = deductions; UT_LVI_WH.Group = deductions;
                AZ_LVI_suta.Group = contributions; NV_LVI_suta.Group = contributions; UT_LVI_suta.Group = contributions;
                this.lvwSummary.Items.AddRange(new ListViewItem[] {
                    FICA_SS_LVI,FICA_SS_eR,FICA_Med_LVI,FICA_Med_eR,FedWH_LVI,FUTA_eR, AZ_LVI_WH,AZ_LVI_suta,NV_LVI_WH,NV_LVI_suta,UT_LVI_WH, UT_LVI_suta });
                //Add label notes
                Fill_Employee_Data("AZ", AZsalary); lblStateDetails.Text += "\n";
                Fill_Employee_Data("NV", NVsalary); lblStateDetails.Text += "\n";
                Fill_Employee_Data("UT", UTsalary);
            }
            else if (usersData[2] == 1.ToString() && usersData[3] == 1.ToString()) //AZ, NV
            {
                AZ_LVI_WH.Group = deductions; NV_LVI_WH.Group = deductions;
                AZ_LVI_suta.Group = contributions; NV_LVI_suta.Group = contributions;
                this.lvwSummary.Items.AddRange(new ListViewItem[] {
                    FICA_SS_LVI,FICA_SS_eR,FICA_Med_LVI,FICA_Med_eR,FedWH_LVI,FUTA_eR, AZ_LVI_WH,AZ_LVI_suta,NV_LVI_WH, NV_LVI_suta });
                //Add label notes
                Fill_Employee_Data("AZ", AZsalary); lblStateDetails.Text += "\n";
                Fill_Employee_Data("NV", NVsalary);
            }
            else if (usersData[3] == 1.ToString() && usersData[4] == 1.ToString()) //NV, UT
            {
                NV_LVI_WH.Group = deductions; UT_LVI_WH.Group = deductions;
                NV_LVI_suta.Group = contributions; UT_LVI_suta.Group = contributions;
                this.lvwSummary.Items.AddRange(new ListViewItem[] {
                    FICA_SS_LVI,FICA_SS_eR,FICA_Med_LVI,FICA_Med_eR,FedWH_LVI,FUTA_eR, NV_LVI_WH,NV_LVI_suta,UT_LVI_WH, UT_LVI_suta });
                //Add label notes
                Fill_Employee_Data("NV", NVsalary); lblStateDetails.Text += "\n";
                Fill_Employee_Data("UT", UTsalary);
            }
            else if (usersData[2] == 1.ToString() && usersData[4] == 1.ToString()) //AZ, UT
            {
                AZ_LVI_WH.Group = deductions; UT_LVI_WH.Group = deductions;
                AZ_LVI_suta.Group = contributions; UT_LVI_suta.Group = contributions;
                this.lvwSummary.Items.AddRange(new ListViewItem[] {
                    FICA_SS_LVI,FICA_SS_eR,FICA_Med_LVI,FICA_Med_eR,FedWH_LVI,FUTA_eR,AZ_LVI_WH,AZ_LVI_suta, UT_LVI_WH, UT_LVI_suta });
                //Add label notes
                Fill_Employee_Data("AZ", AZsalary); lblStateDetails.Text += "\n";
                Fill_Employee_Data("UT", UTsalary);
            }
            else if (usersData[2] == 1.ToString()) //AZonly
            {
                AZ_LVI_WH.Group = deductions; AZ_LVI_suta.Group = contributions;
                this.lvwSummary.Items.AddRange(new ListViewItem[] {
                    FICA_SS_LVI,FICA_SS_eR,FICA_Med_LVI,FICA_Med_eR,FedWH_LVI,FUTA_eR, AZ_LVI_WH, AZ_LVI_suta });
                //Add label notes
                Fill_Employee_Data("AZ", AZsalary);
            }
            else if (usersData[3] == 1.ToString()) //NVonly
            {
                NV_LVI_WH.Group = deductions; NV_LVI_suta.Group = contributions;
                this.lvwSummary.Items.AddRange(new ListViewItem[] {
                    FICA_SS_LVI,FICA_SS_eR,FICA_Med_LVI,FICA_Med_eR,FedWH_LVI,FUTA_eR, NV_LVI_WH, NV_LVI_suta });
                //Add label notes
                Fill_Employee_Data("NV", NVsalary);
            }
            else if (usersData[4] == 1.ToString()) //UTonly
            {
                UT_LVI_WH.Group = deductions; UT_LVI_suta.Group = contributions;
                this.lvwSummary.Items.AddRange(new ListViewItem[] {
                    FICA_SS_LVI,FICA_SS_eR,FICA_Med_LVI,FICA_Med_eR,FedWH_LVI,FUTA_eR, UT_LVI_WH, UT_LVI_suta });
                //Add label notes
                Fill_Employee_Data("UT", UTsalary);
            }

            //return list view groups
            return new ListViewGroup[] { deductions, contributions };
        }

        private void Form_Review_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblSalary' table. You can move, or remove it, as needed.
            this.tblSalaryTableAdapter.Fill(this.taxUsersDataSet.tblSalary);

            //Check Null Values:
            Check_Null_Values();
            //display note based on user type
            //from confirm profile form, each guest user has username of "guestUser"
            if (usersData[0] == "guestUser")
            {
                lblReviewPage.Text = GUEST_NOTE;
                btnSave.Hide(); //hide save button
            }
            else
                lblReviewPage.Text = USER_NOTE;

            //Add headers for summary and salary details
            Add_UserData_SectionHeaders();
            lvwSummary.Groups.Add(Load_Salary_Breakdown());

            //Load Federal and state values depending on user selection
            lvwSummary.Groups.AddRange(Group_Payroll());

            //Note about contributions and values
            lblDisclaimer.Text = "*Employer Contributions do not affect paycheck. \n**FUTA contribution is capped at USD 7,000\n";
            lblDisclaimer.Text += "Disclaimer: Amounts and taxes are only calculated for base earnings, deductions, and withholdings.  " +
                "\nFor a more detailed and robust analysis, please consult your tax provider.";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //get tax values
            //salary array order: username, allowances, annualized salary, salary, frequency, weekHours, months
            //fed taxes order: taxFICA_SS, taxFICA_SS_ER, taxFICAMedicare, taxFICAMedicare_ER, taxFedWH, taxFUTA
            //state taxes order: AZtaxWH, AZtaxSUTA 

            //update the database with user's salary values
            decimal hourlySalAZ = 0, annualSalAZ = 0, hourlySalNV = 0, annualSalNV = 0, hourlySalUT = 0, annualSalUT = 0;
            if (AZsalary[4] == "A")
                annualSalAZ = decimal.Parse(AZsalary[3]);
            if (AZsalary[5] == "B")
                hourlySalAZ = decimal.Parse(AZsalary[3]);
            if (NVsalary[4] == "A")
                annualSalNV = decimal.Parse(NVsalary[3]);
            if (NVsalary[5] == "B")
                hourlySalNV = decimal.Parse(NVsalary[3]);
            if (UTsalary[4] == "A")
                annualSalUT = decimal.Parse(UTsalary[3]);
            if (UTsalary[5] == "B")
                hourlySalUT = decimal.Parse(UTsalary[3]);


            this.tblSalaryTableAdapter.UpdateSalaryQuery(
                AZsalary[4], double.Parse(AZsalary[6]), (double)hourlySalAZ, double.Parse(AZsalary[5]), (double)annualSalAZ,
                NVsalary[4], double.Parse(NVsalary[6]), (double)hourlySalNV, double.Parse(NVsalary[5]), (double)annualSalNV,
                UTsalary[4], double.Parse(UTsalary[6]), (double)hourlySalUT, double.Parse(UTsalary[5]), (double)annualSalUT, usersData[0]);

            //update the database with user's tax values
            this.tblSalaryTableAdapter.UpdateTaxQuery(
                (decimal)AZfedTaxes[2], (decimal)AZfedTaxes[3], (decimal)AZfedTaxes[0], (decimal)AZfedTaxes[1], (decimal)AZfedTaxes[5], (decimal)AZfedTaxes[4],
                (decimal)AZstateTaxes[1], (decimal)AZstateTaxes[0],
                (decimal)NVfedTaxes[2], (decimal)NVfedTaxes[3], (decimal)NVfedTaxes[0], (decimal)NVfedTaxes[1], (decimal)NVfedTaxes[5], (decimal)NVfedTaxes[4],
                (decimal)NVstateTaxes[1], (decimal)NVstateTaxes[0],
                (decimal)UTfedTaxes[2], (decimal)UTfedTaxes[3], (decimal)UTfedTaxes[0], (decimal)UTfedTaxes[1], (decimal)UTfedTaxes[5], (decimal)UTfedTaxes[4],
                (decimal)UTstateTaxes[1], (decimal)UTstateTaxes[0], usersData[0]);

            //notify the user of updates
            MessageBox.Show("Your salary data and tax calculation summary has been saved", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

            //create a new document
            Document Export = new Document();
            //define file path and create pdf file (Debug folder)
            PdfWriter.GetInstance(Export, new FileStream("Payroll Tax Detail.pdf", FileMode.Create));
            //Open file to add image
            Export.Open();

            //Add a header to the document 
            string name = "Payroll Tax Application";
            string header = usersData[1] + "\nPayroll Tax Summary";
            Export.AddHeader(name, header);

            // saving image of the listview control.
            System.Drawing.Rectangle rect = lvwSummary.RectangleToScreen(lvwSummary.Bounds);

            Graphics g = lvwSummary.CreateGraphics();
            //new bitmap object to save the image        
            Bitmap bmp = new Bitmap(lvwSummary.Width, lvwSummary.Height);
            //Drawing control to the bitmap        
            lvwSummary.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, lvwSummary.Width, lvwSummary.Height));
            bmp.Save("Payroll Tax Detail.pdf", System.Drawing.Imaging.ImageFormat.Jpeg);
            //convert to pdf item image
            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(bmp,
              System.Drawing.Imaging.ImageFormat.Jpeg);
            Export.Add(pdfImage);
            Export.Close();

            //Thank you message
            MessageBox.Show(THANK_YOU, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

/* References
 * Updating multiple columns in one row - LINQ https://stackoverflow.com/questions/42850760/linq-update-multiple-columns
 * Creating a pdf file https://www.youtube.com/watch?v=dFKDAQmtv5c
 * Saving image https://www.youtube.com/watch?v=kVJhyXQtTXQ
 * Using an image to copy to file https://www.youtube.com/watch?v=tMWQuGNPRyM
 * Saving image to pdf https://stackoverflow.com/questions/17145837/c-sharp-save-bitmap-as-pdf-with-itextsharp
 * Listview items https://social.msdn.microsoft.com/Forums/vstudio/en-US/d22eceb8-b8ec-4beb-80e5-b7f9fa012291/adding-listview-groups-through-code
 */
