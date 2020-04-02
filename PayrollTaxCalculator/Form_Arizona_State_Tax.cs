/*
 *Program:PayRoll Tax calculator Application
 * section: Arizona State Tax Form
 * Purpose: Here initially state withholding tax and SUTA tax of the Arizona state will be displayed 
 * and then admin can update these taxes by entering withholding amount for particular the lowbound , highbound and the marital status .
 * Author:srijana lawa
 * Date:2018/11/18
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
    public partial class ArizonaStateTaxForm : Form
    {
        public ArizonaStateTaxForm()
        {
            InitializeComponent();
        }
        
        //constant
        const string STATE = "AZ";
        const string NULL_WITH_HOLDING = " Please enter withholding rates";
        const string NULL_SUTA = " Please enter suta rates";
        const string UPDATED = "Tax rate has been updated in table";
        string maritalStatus = "";
        string witholdingRate = "";
        double LowBraket;
        double HighBracket;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.MainPage.Show();
        }

        private void ArizonaStateTaxForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblSUTARates' table. You can move, or remove it, as needed.
            this.tblSUTARatesTableAdapter.Fill(this.taxUsersDataSet.tblSUTARates);
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblStateWH' table. You can move, or remove it, as needed.
            this.tblStateWHTableAdapter.Fill(this.taxUsersDataSet.tblStateWH);

            //setsuta rates
              txtSutaRate.Text = tblSUTARatesTableAdapter.GetSUTArate(STATE).ToString();

            //while loading the file withholding for single is shown
            rdbSingle.Checked = true;
            maritalStatus = "S";

            //calling method to set value in lowbracket value combobox 
            setLowBracket( maritalStatus);
            //selecting first item in combo box
            cmbBrckLow.SelectedIndex = 0;

            //calling method to set value in Highbracket value combobox 
            setHighBracket(maritalStatus);
            cmbBrckHigh.SelectedIndex = 0;
            // calling method to display withholding in textbox
            DisplayWitholdingTax();
        
        }

        private void setLowBracket( string maritalStatus)
        {
            //cmb is cleared
            cmbBrckLow.Items.Clear();

            
            //find row of low bound for arizona with particular marital status
            tblStateWHTableAdapter.FillBy(taxUsersDataSet.tblStateWH, STATE, maritalStatus);
            //count the rows returned
            int count = tblStateWHBindingSource.Count;

            if (count == 0)
            {
                //if no any value in bracket_low column then setting 0 in combo box
                cmbBrckLow.Items.Add("0");
            }
            else
            {
               // loop through the each row  to add each single low bracket into the combobox
                for ( int i=0; i < count; i++)
                {
                    cmbBrckLow.Items.Add(taxUsersDataSet.tblStateWH.Rows[i]["Bracket_Low"].ToString());
                }

                
            }
            
          
        }

        private void setHighBracket(string maritalStatus)
        {
            //clearing the high bracket combo box
            cmbBrckHigh.Items.Clear();
            
            //find row of low bound for arizona with particular marital status
            tblStateWHTableAdapter.FillByHighBracket(taxUsersDataSet.tblStateWH, STATE, maritalStatus);
            //count the rows returned
            int count = tblStateWHBindingSource.Count;

            if (count == 0)
            {
                // if no any value in bracket_High column then setting 0 in combo box
                cmbBrckHigh.Items.Add("0");
            }
            else
            {
                //  // loop through the each row  to add each  single High bracket into the combobox
                for (int i = 0; i < count; i++)
                {
                    cmbBrckHigh.Items.Add(taxUsersDataSet.tblStateWH.Rows[i]["Bracket_High"].ToString());
                }


            }
           
        }

        private void DisplayWitholdingTax( )
        {
            //setting lowbracket and highbracek only if item is selected
            if (cmbBrckLow.SelectedIndex > -1 && cmbBrckHigh.SelectedIndex > -1)
            {
                //get salary bounds
                LowBraket = double.Parse(cmbBrckLow.SelectedItem.ToString());
                HighBracket = double.Parse(cmbBrckHigh.SelectedItem.ToString());
            }

            // running sql query to get withholding rates
           witholdingRate = tblStateWHTableAdapter.GetWithHoldingRates("AZ", maritalStatus, (decimal)LowBraket, (decimal)HighBracket).ToString();
             // if withholding is empty set 0 as value
            if (witholdingRate == "" || witholdingRate==null)
            {
                txtWithholdingRate.Text = "0";
            }
            else
            {
                txtWithholdingRate.Text = witholdingRate;
            }
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSingle.Checked)
            {
                maritalStatus = "S";

                //calling method to set value in lowbracket value combobox  for single
                setLowBracket(maritalStatus);
                //selecting first item in combo box
                cmbBrckLow.SelectedIndex = 0;

                //calling method to set value in Highbracket value combobox for single
                setHighBracket(maritalStatus);
                cmbBrckHigh.SelectedIndex = 0;
                // calling method to display withholding in textbox

                //calling method to display withholding in textbox
                DisplayWitholdingTax();

            }

            if (rdbMarried.Checked)
            {
                maritalStatus = "M";

                //calling method to set value in lowbracket value combobox  for married
                setLowBracket(maritalStatus);
                //selecting first item in combo box
                cmbBrckLow.SelectedIndex = 0;

                //calling method to set value in Highbracket value combobox for married
                setHighBracket(maritalStatus);

                //calling method to display withholding in textbox
                DisplayWitholdingTax();
            }

         

        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            //getting low bound and upperbound
            if (cmbBrckLow.SelectedIndex > -1)
            {
                LowBraket = double.Parse(cmbBrckLow.SelectedItem.ToString());
            }
            if (cmbBrckHigh.SelectedIndex > -1)
            {
                HighBracket = double.Parse(cmbBrckHigh.SelectedItem.ToString());
            }

            // calling method to display withholding in textbox
            DisplayWitholdingTax();
        }

        private void ArizonaStateTaxForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // application exit code
            Program.FormClosingMethod(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                
                //query to update suta rate
                this.tblSUTARatesTableAdapter.UpdateSUTARate(decimal.Parse(txtSutaRate.Text), STATE);

                //query to update statewithholding rate
                this.tblStateWHTableAdapter.UpdateStateWithholdingRates(decimal.Parse(txtWithholdingRate.Text), STATE, maritalStatus, (decimal)LowBraket, (decimal)HighBracket);
                
                MessageBox.Show(UPDATED, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool IsValid()
        {
            bool isValid = false;

            if (!rdbMarried.Checked && !rdbSingle.Checked)
            {
                MessageBox.Show("Please choose your marital status", Program.APP_NAME,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (cmbBrckLow.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose Low bound Income", Program.APP_NAME,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (cmbBrckHigh.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose High bound Income", Program.APP_NAME,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtWithholdingRate.Text.Trim()=="")
            {
                MessageBox.Show("Please enter the withholding rates", Program.APP_NAME,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSutaRate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter the SUTA rates", Program.APP_NAME,
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        private void CancelKey(object sender, KeyPressEventArgs e)
        {
            //allow number
            Program.allowNumberOnlyMethod(sender, e);

        }

        private void tblStateWHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblStateWHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }

        private void SelectAll(object sender, EventArgs e)
        {
            if(sender == txtSutaRate)
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
