/*
 *Program:PayRoll Tax calculator Application
 * section: Federal withholding Rate form
 * Purpose: Displays the federal withholding tax rates which is same for all three state.
 * Admin can delete the certain rates by entering period and low bound and add new rates in this form
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
    public partial class Federal_Witholding_Rates_Form : Form
    {
        public Federal_Witholding_Rates_Form()
        {
            InitializeComponent();
        }

        //constant
        const string NUll_MARITAL_STATUS = "Please choose your marital status";

        String maritalStatus = "";

        private void Federal_Witholding_Rates_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application exit
            Program.FormClosingMethod(sender,e);
        }

    
        private void Federal_Witholding_Rates_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblFederalWH' table. You can move, or remove it, as needed.
            this.tblFederalWHTableAdapter.Fill(this.taxUsersDataSet.tblFederalWH);

        }

        private void txtPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allowing only A and B in period
            if (e.KeyChar != 'a' && e.KeyChar != 'b' && e.KeyChar != 'A' && e.KeyChar != 'B'
                && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            /*
            else
            {
                MessageBox.Show("Please type either A or B only  in this field", Program.APP_NAME,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */
        }

        private void CancelKey(object sender, KeyPressEventArgs e)
        {
            //allow number only
            Program.allowNumberOnlyMethod(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                string Period = txtaddPeriod.Text.Trim();
                int lowboundValue = int.Parse(txtaddLowBound.Text.Trim());

                
                //loading a row with searched period and low bound value 
                tblFederalWHTableAdapter.FillByPeriodandLowBound(taxUsersDataSet.tblFederalWH, Period, lowboundValue, int.Parse(txtHighBound.Text.Trim()));
                //count the rows returned
                int count = tblFederalWHBindingSource.Count;

                //if record consist of row with that value display record already contains that value
                if (count == 1)
                {
                   if( MessageBox.Show("The record already contents Withholding rate with period " + Period +
                        " and low bound " + lowboundValue +" and High bound " + txtHighBound.Text.Trim() + "in the database",
                        Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        //loading table with all the data again
                        tblFederalWHTableAdapter.Fill(taxUsersDataSet.tblFederalWH);

                        txtaddLowBound.Focus();
                    }
                    
                }
                else
                {
                    //call the insert query to add row in the table if database doesnot have that value
                    tblFederalWHTableAdapter.InsertFederalWithholdingRates(maritalStatus,
                      txtaddPeriod.Text.ToUpper(),
                        decimal.Parse(txtaddLowBound.Text),
                        decimal.Parse(txtHighBound.Text),
                        decimal.Parse(txtWithholding.Text),
                        decimal.Parse(txtPctWH.Text));

                    //get the updates record from the database
                    tblFederalWHTableAdapter.Fill(taxUsersDataSet.tblFederalWH);

                    txtaddLowBound.Text = "";
                    txtHighBound.Text = "";
                    txtPctWH.Text = "";
                    txtaddPeriod.Text = "";
                    rdbMarried.Checked = false;
                    rdbSingle.Checked = false;
                    txtWithholding.Text = "";

                    MessageBox.Show("Data has been added", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtPeriod.Text.Trim() == "" || txtLowbound.Text.Trim() == "" || txtdelHighBound.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Period , Low bound income and Highbound Income", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                if (txtPeriod.Text.Length > 1)
                {
                    MessageBox.Show("Please type either A or B only  in Period", Program.APP_NAME,
                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    
                    string Period = txtPeriod.Text.Trim();
                    int lowboundValue = int.Parse(txtLowbound.Text.Trim());

                    //find the withholding rate with searched period and low bound value
                    tblFederalWHTableAdapter.FillByPeriodandLowBound(taxUsersDataSet.tblFederalWH, Period, lowboundValue, int.Parse(txtdelHighBound.Text.Trim()));
                    //count the rows returned
                    int count = tblFederalWHBindingSource.Count;


                    //if record is empty then display record doesnot contain that value
                    if (count == 0)
                    {
                        MessageBox.Show("The record  does not content Withholding rate with period " + Period +
                            " and low bound " + lowboundValue + " and High bound " + txtdelHighBound.Text.Trim() + "in the database",
                            Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //filling the table again
                        tblFederalWHTableAdapter.Fill(taxUsersDataSet.tblFederalWH);

                        //setFocus on textbox
                        txtPeriod.Focus();
                    }

                    else
                    {
                        if (MessageBox.Show("Delete the Federal withholding whose period is " + txtPeriod.Text.ToUpper() + " and Low bound income is " +
                        txtLowbound.Text + "?",
                        Program.APP_NAME,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                        {

                            //call the delete query to  remove the record 
                            tblFederalWHTableAdapter.DeleteFederalRates(txtPeriod.Text.ToUpper(), decimal.Parse(txtLowbound.Text), decimal.Parse(txtdelHighBound.Text));

                            //get the updates record from the database
                            tblFederalWHTableAdapter.Fill(taxUsersDataSet.tblFederalWH);

                            //clear the textbox
                            txtLowbound.Text = "";
                            txtPeriod.Text = "";
                            txtdelHighBound.Text = "";


                        }
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // this this form and show previous page
            this.Hide();
            Program.MainPage.Show();
        }

        private bool isValid()
        {
            bool isValid = false;

            if (!rdbMarried.Checked && !rdbSingle.Checked)
            {
                MessageBox.Show(NUll_MARITAL_STATUS, Program.APP_NAME,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtaddPeriod.Text.Trim()=="")
            {
                MessageBox.Show("Please enter your Period", Program.APP_NAME,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtaddLowBound.Text.Length == 0) {
                MessageBox.Show("Please enter Low bound income", Program.APP_NAME,
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (txtHighBound.Text.Length == 0)
            {
                MessageBox.Show("Please enter High bound income", Program.APP_NAME,
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(txtaddLowBound.Text)> int.Parse(txtHighBound.Text))
            {
                MessageBox.Show("High bound value should be greater than low bound Value", Program.APP_NAME,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtaddPeriod.Text.Length > 1)
            {
                MessageBox.Show("Please type either A or B only  in Period", Program.APP_NAME,
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          else if (txtWithholding.Text.Length == 0)
            {
                MessageBox.Show("Please enter withholding amount", Program.APP_NAME,
                                                         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (txtPctWH.Text.Length == 0)
            {
                MessageBox.Show("Please enter Additional PctWH amount", Program.APP_NAME,
                                                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                isValid = true;
            }

            return isValid;

        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMarried.Checked)
            {
                maritalStatus = "M";
            }
            if (rdbSingle.Checked)
            {
                maritalStatus = "S";
            }
        }

        private void tblFederalWHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFederalWHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }
    }
}
