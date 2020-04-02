/*
 *Program:PayRoll Tax calculator Application
 * section :UpdateTaxRate Form
 * Purpose: Admin can update general federal taxes which is same for all three state. 
 * From this form Admin will be redirected to different state tax rate from on the basis of button they click
 * LoadIRS button will redirect user to Federal withholding Rates Form 
 * Author:srijana lawa
 * Date:2018/11/25
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
using PayRollTaxCalculator;

namespace TaxPayrollPay
{
    public partial class updateTaxRateForm : Form
    {
        public updateTaxRateForm()
        {
            InitializeComponent();
        }

        private void updateTaxRateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //constant for federal tax Type
        const string TYPE_FICA_SS = "FICA_SS";
        const string TYPE_FICA_MEDICARE = "FICA_Medicare";
        const string TYPE_FUTA = "FUTA";

        // all the rates have been declared as string instead of int because these data are used for display only
        string FICA_ss_rate = "0";
        string FICA_medicare_rate = "0";
        string FUTA_rate = "0";

        private void updateTaxRateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblFederalRates' table. You can move, or remove it, as needed.
            this.tblFederalRatesTableAdapter.Fill(this.taxUsersDataSet.tblFederalRates);

            //call a method to load taxes while form is opened
            DisplayRates();
        }

        private void btnArizonastateTax_Click(object sender, EventArgs e)
        {
            //creating the instance
            ArizonaStateTaxForm frmArizona = new ArizonaStateTaxForm();

            frmArizona.Show();
            this.Hide();

            Program.MainPage = this;
        }

        private void btnUpdateStateTax_Click(object sender, EventArgs e)
        {
            //creating the instance
            UtahStateTaxForm frmUtah = new UtahStateTaxForm();

            //showing Utahstatetax from and hiding this form
            frmUtah.Show();
            this.Hide();
    
            Program.MainPage = this;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.BackMethod(sender, e);
        }

        private void lblFICARate_Click(object sender, EventArgs e)
        {
            //show dialog to change rate
            Update_Federal_Tax_Dialog_frm updateTaxDialog = new Update_Federal_Tax_Dialog_frm(TYPE_FICA_SS,FICA_ss_rate);
            updateTaxDialog.ShowDialog();
        }

        private void lblFUTARate_Click(object sender, EventArgs e)
        {
            //show dialog to change rate
            Update_Federal_Tax_Dialog_frm updateTaxDialog = new Update_Federal_Tax_Dialog_frm(TYPE_FUTA, FUTA_rate);
            updateTaxDialog.ShowDialog();
        }

        private void lblMedicareRate_Click(object sender, EventArgs e)
        {
            //show dialog to change rate
            Update_Federal_Tax_Dialog_frm updateTaxDialog = new Update_Federal_Tax_Dialog_frm(TYPE_FICA_MEDICARE, FICA_medicare_rate);
            updateTaxDialog.ShowDialog();
        }

        private void btnLoadIRS_Click(object sender, EventArgs e)
        {
            //show federalwithholding form
            Federal_Witholding_Rates_Form federalWithholdingfrm = new Federal_Witholding_Rates_Form();
            federalWithholdingfrm.Show();

            this.Hide();
            Program.MainPage = this;
        
        }

        private void btnNevedastateTax_Click(object sender, EventArgs e)
        {
            //creating the instance
            NevadaStateTax frmNevada = new NevadaStateTax();

            //showing nevadastate tax form and hiding this form and setting this page as previous page
            frmNevada.Show();
            this.Hide();

            Program.MainPage = this;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // to get the latest data updated in dailog
            DisplayRates();
        }

        private void DisplayRates()
        {
           
            //calling method to get the rate on the basis of rate type
            FICA_ss_rate = tblFederalRatesTableAdapter.GetFederalRate(TYPE_FICA_SS).ToString();
            FICA_medicare_rate = tblFederalRatesTableAdapter.GetFederalRate(TYPE_FICA_MEDICARE).ToString();
            FUTA_rate = tblFederalRatesTableAdapter.GetFederalRate(TYPE_FUTA).ToString();

   
            // displaying rates in respective label
            lblFICARate.Text = FICA_ss_rate;
            lblMedicareRate.Text = FICA_medicare_rate;
            lblFUTARate.Text = FUTA_rate;
        }

        private void tblFederalRatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFederalRatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }
    }
}
