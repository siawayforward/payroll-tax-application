/*
 *Program:PayRoll Tax calculator Application
 * section: Add Description
 * Purpose:Here the admin will be able to write description about the things they want 
 * to show in Aboutus page. THis form is show when admin click update description button 
 * in Help Links and AboutUs frm
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
using System.IO;
using PayRollTaxCalculator;

namespace TaxPayrollPay
{
    public partial class AddDescriptionForm : Form
    {
        public AddDescriptionForm()
        {
            InitializeComponent();
        }
        string NULL_MSG = "Please add description before submission";
        string FILE_NAME = "Aboutus.txt";

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtDescp.Text.Length == 0)
            {
                MessageBox.Show(NULL_MSG, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Create StreamWriter object and addisgn to variable OutFile
                StreamWriter outfile = new StreamWriter(FILE_NAME, false); // true means to append it

                //contact details to be saved in file
                string outputString = txtDescp.Text;
                //write contact information in contact.txt file
                outfile.WriteLine(outputString);

                // Close the file
                outfile.Close();

                // on click of ok form has been redirected to previous page
               if( MessageBox.Show("Description has been updated ", Program.APP_NAME, MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Hide();
                    Program.MainPage.Show();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.MainPage.Show();
        }

        private void txtDescp_Enter(object sender, EventArgs e)
        {
            txtDescp.SelectAll();
        }

        private void AddDescriptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FormClosingMethod(sender, e);
        }

        private void AddDescriptionForm_Load(object sender, EventArgs e)
        {

            if (File.Exists(FILE_NAME))
            {

                //load contact information from file
                // Declare variables of StreamReader
                StreamReader inFile = new StreamReader(FILE_NAME);

                // Read from the file it has single line so we can get but reading one time only
                // display it in textview
                txtDescp.Text= inFile.ReadLine();

              

                // close the file
                inFile.Close();
            }
        }
    }
}
