/*
 *Program:PayRoll Tax calculator Application
 * Purpose: This form will show the state withholding and SUTA rate for Utah. 
 * Admin Can update both of these rate clicking update button
 * Author:srijana lawa
 * Date:2018/11/29
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
   
    public partial class UtahStateTaxForm : Form
    {
        public UtahStateTaxForm()
        {
            InitializeComponent();
        }
        //constant
        const string STATE = "UT";
        const string NULL_WITH_HOLDING = " Please enter withholding rates";
        const string NULL_SUTA = " Please enter suta rates";
        const string UPDATED = "Tax rate has been updated in table";
        string maritalStatus = "";

        //Upper Upperbound is 100000 because we have limited our application to calculate the payroll whose income is less or equal to $100000
        //Utah federal rate doesnot depend on lowbound and high bound so we have used const
         const double LOW_BOUND = 0;
         const double UPPER_BOUND = 100000;



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.MainPage.Show();

        }


   
        private void UtahStateTaxForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblStateWH' table. You can move, or remove it, as needed.
            this.tblStateWHTableAdapter.Fill(this.taxUsersDataSet.tblStateWH);
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblSUTARates' table. You can move, or remove it, as needed.
            this.tblSUTARatesTableAdapter.Fill(this.taxUsersDataSet.tblSUTARates);

            //displaying suta rate
             txtSutaRate.Text = tblSUTARatesTableAdapter.GetSUTArate(STATE).ToString();

            // intially single radio button has been checked so maritalstatus is made single
            maritalStatus = "S";

            //displaying withholding rate 
         txtWithholdingRate.Text = tblStateWHTableAdapter.GetWithHoldingRates(STATE, maritalStatus,(decimal) LOW_BOUND, (decimal)UPPER_BOUND).ToString();          
        }


        
        private void CheckedChanged(object sender, EventArgs e)
        {
            if ( rdbMarried.Checked)
            {
                maritalStatus = "M";
            }
            if (rdbSingle.Checked)
            {
                maritalStatus = "S";
            }

            //displaying withholding rate 
          txtWithholdingRate.Text = tblStateWHTableAdapter.GetWithHoldingRates(STATE, maritalStatus, (decimal)LOW_BOUND, (decimal)UPPER_BOUND).ToString();
        }
        

        private bool isValid(string withholdingrate, string sutarate)
        {
            bool isValid = false;
            // checking empty text box
            if (withholdingrate.Length == 0)
            {
                MessageBox.Show(NULL_WITH_HOLDING, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (sutarate.Length == 0)
            {
                MessageBox.Show(NULL_SUTA, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isValid = true;
            }

            return isValid;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isValid(txtWithholdingRate.Text, txtSutaRate.Text))
            {
                //query to update suta rate
             this.tblSUTARatesTableAdapter.UpdateSUTARate(decimal.Parse(txtSutaRate.Text), STATE);

                //query to update statewithholding rate
              this.tblStateWHTableAdapter.UpdateStateWithholdingRates(decimal.Parse(txtWithholdingRate.Text), STATE, maritalStatus, (decimal)LOW_BOUND,(decimal) UPPER_BOUND);

                MessageBox.Show(UPDATED, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UtahStateTaxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //application exit
            Program.FormClosingMethod(sender, e);
        }

        private void tblSUTARatesBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblSUTARatesBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }

        private void cancelKey(object sender, KeyPressEventArgs e)
        {
            //allow numberOnly
            Program.allowNumberOnlyMethod(sender, e);
        }

        private void SelectAllMethod(object sender, EventArgs e)
        {
            //calling select all method onthe basis of selected textbox
            if (sender == txtSutaRate)
            {
                txtSutaRate.SelectAll();
            }

            if (sender == txtWithholdingRate)
            {
                txtWithholdingRate.SelectAll();
            }
        }
    }
}
