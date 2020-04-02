/*
 *Program:PayRoll Tax calculator Application
 * Purpose: It is the form shown as dialog on click of each rate in federal tax rate. 
 * Here admin will be able to update the tax rate based on type
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
    public partial class Update_Federal_Tax_Dialog_frm : Form
    {
        //constant for federal tax Type
        const string TYPE_FICA_SS = "FICA_SS";
        const string TYPE_FICA_MEDICARE = "FICA_Medicare";
        const string TYPE_FUTA = "FUTA";
        string taxType = "";
        string taxRate = "";

        public Update_Federal_Tax_Dialog_frm(string federalTaxType, string Rate)
        {
            InitializeComponent();
            taxType = federalTaxType;
            taxRate = Rate;
        }
     

        private void Update_Federal_Tax_Dialog_frm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblFederalRates' table. You can move, or remove it, as needed.
            this.tblFederalRatesTableAdapter.Fill(this.taxUsersDataSet.tblFederalRates);

            //setting title on the basis of type clicked
            if (taxType.Equals(TYPE_FICA_SS))
            {
                lblTitle.Text = ("FICA_SS  Rate Update ");
            }
            if (taxType.Equals(TYPE_FICA_MEDICARE))
            {
                lblTitle.Text = ("FICA_Medicare Rate Update");
            }
            if (taxType.Equals(TYPE_FUTA))
            {
                lblTitle.Text = ("FUTA Rate Update");
            }

            //displaying tax rate
            txtRate.Text = taxRate;

        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            //call method to allownumberonly which is defined in program.cs
            //it allows user to enter number only
            Program.allowNumberOnlyMethod(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        
            // checking for empty textbox
            if (txtRate.Text.Trim() == "")
            {
                MessageBox.Show("Please enter rate", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //converting string into decimal as rate is in decimal in table
                decimal updatedTax = decimal.Parse(txtRate.Text);
                // asking if admin want to change the rate
                if (MessageBox.Show("Do you want to change the rate of " + taxType + " ?",
                    Program.APP_NAME,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //updating federal Tax rates on the basis of type
                    //calling update sql query
                    if (taxType.Equals(TYPE_FICA_SS))
                    {
                      tblFederalRatesTableAdapter.UpdateFederalTaxRate(updatedTax, TYPE_FICA_SS);
                    }
                    if (taxType.Equals(TYPE_FICA_MEDICARE))
                    {
                     tblFederalRatesTableAdapter.UpdateFederalTaxRate(updatedTax, TYPE_FICA_MEDICARE);
                    }
                    if (taxType.Equals(TYPE_FUTA))
                    {
                     tblFederalRatesTableAdapter.UpdateFederalTaxRate(updatedTax, TYPE_FUTA);
                    }

                    //to fill table with latest data
                  this.tblFederalRatesTableAdapter.Fill(this.taxUsersDataSet.tblFederalRates);

                    //hiding this page after update
                    this.Hide();
                }



            }
        }

          
        private void txtRate_Enter(object sender, EventArgs e)
        {
            //to select all the value in txtRate textbox
            txtRate.SelectAll();
        }

        private void tblFederalRatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFederalRatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }
    }
}
