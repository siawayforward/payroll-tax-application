/*
 *Program:PayRoll Tax calculator Application
 * Purpose: Displays the list of feedback  from feedbacktbl submitted by user form contact us form and 
 * Admin can delete the feedback
 * Author:srijana lawa
 * Date:2018/11/24
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
    public partial class viewFeedBackForm : Form
    {
        public viewFeedBackForm()
        {
            InitializeComponent();
        }


        private void viewFeedBackForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblFeedback' table. You can move, or remove it, as needed.
            this.tblFeedbackTableAdapter.Fill(this.taxUsersDataSet.tblFeedback);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // hidding this form
            this.Hide();

            // calling backmethod declared in  Program.cs  to go back to the previous page
            Program.BackMethod(sender,e);

        }

        private void viewFeedBackForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //calling fromclosingMethod declared in Program.cs to exit the application
            Program.FormClosingMethod(sender,e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtDeleteID.Text.Trim() == "")
            {
                MessageBox.Show("Please enter ID", Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {  
                //find the feedback with searched Id
                tblFeedbackTableAdapter.FillByID(taxUsersDataSet.tblFeedback, int.Parse(txtDeleteID.Text.Trim()));
                //count the rows returned
                int count = tblFeedbackBindingSource.Count;


                //if record is empty then display record doesnot contain that feedback
                if (count == 0)
                {
                    MessageBox.Show("The record  does not consist Feedback with Id " + txtDeleteID.Text.Trim() + " in the database",
                        Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //filling the table again
                    tblFeedbackTableAdapter.Fill(taxUsersDataSet.tblFeedback);

                    //setFocus on textbox
                    txtDeleteID.Focus();
                }
                else
                {
                    if (MessageBox.Show("Delete the feedback whose ID is " + txtDeleteID.Text.Trim() + "?",
                    Program.APP_NAME,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int ID = int.Parse(txtDeleteID.Text.Trim());
                        //call the deletequery to  remove the record
                        tblFeedbackTableAdapter.DeleteFeedBackQuery(ID);

                        //get the updates record from the database
                        tblFeedbackTableAdapter.Fill(taxUsersDataSet.tblFeedback);

                        //clear the textbox
                        txtDeleteID.Text = "";
                    }
                }
          
           
            }
            }

        private void tblFeedbackBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFeedbackBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }

        private void tblFeedbackBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblFeedbackBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }
    }
}
