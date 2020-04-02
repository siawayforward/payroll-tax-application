/*
 *Program:PayRoll Tax calculator Application
 * Purpose:If contact.txt file exits then it displays the email, physical address and email after loading the form
 * Admin can edit the information after clicking the edit button and 
 * save the changes in file by clicking the save button
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
    public partial class updateContactForm : Form
    {
        public updateContactForm()
        {
            InitializeComponent();
        }

        //declaring constant string
        const string NULL_PHONE = "Please enter your phone number";
        const string NULL_EMAIL = "Please enter your email address";
        const string NULL_ADDRESS = " Please enter your address";

        //declaring file name
        const string FILE_NAME = "contact.txt";

        private void updateContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Calling the formClosingMethod declared in Progam.cs to exit the application
            Program.FormClosingMethod(sender, e);
        }

        private void updateContactForm_Load(object sender, EventArgs e)
        {
            //check if file exist
            if (File.Exists(FILE_NAME))
            {

                //load contact information from file
                // Declare variables of StreamReader
                StreamReader inFile = new StreamReader(FILE_NAME);

                // Read from the file it has single line so we can get by reading oneline
                String contactDetail = inFile.ReadLine();

                //array to store the address and other information
                string[] fields = new string[3];
                //";" has been used to separate the each value in the row
                fields = contactDetail.Split(';');

                //display value in text file
                txtEmail.Text = fields[0];
                txtPhysicalAddress.Text = fields[1];
                txtPhone.Text = fields[2];

                // close the file
                inFile.Close();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //hide this form and display the previous page by calling backMethod declared in Program.cs
            this.Hide();
            Program.BackMethod(sender, e);
        }

        
        public bool IsValid()
        {
            // define boolen to return validity value
            bool isValid = false;

            // check for empty value
            if (txtEmail.Text.Length == 0)
            {
                MessageBox.Show(NULL_EMAIL, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (txtPhysicalAddress.Text.Length == 0)
            {
                MessageBox.Show(NULL_ADDRESS, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (txtPhone.Text.Length == 0)
            {
                MessageBox.Show(NULL_PHONE, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                // set is valid true when all the field are filled
                isValid = true;
            }
           
            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValid())
            {
                 // Create StreamWriter object and addisgn to variable OutFile
                StreamWriter outfile = new StreamWriter(FILE_NAME, false); // true means to append it

                //contact details to be saved in file
                string outputString = txtEmail.Text + ";" + txtPhysicalAddress.Text + ";" + 
                    txtPhone.Text;

                //write contact information in contact.txt file
                outfile.WriteLine(outputString);

                // Close the file
                outfile.Close();


              if(  MessageBox.Show("Your contact information has been updated ",Program.APP_NAME,
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    //hide this form and display the previous page by calling backMethod declared in Program.cs after user click ok
                    this.Hide();
                    Program.BackMethod(sender, e);
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             // textfile are made clickable
                txtEmail.Enabled = true;
                txtPhone.Enabled = true;
            txtPhysicalAddress.Enabled = true;

                // button save is made visible
                btnSave.Visible = true;
           
        }

        private void CancelKey(object sender, KeyPressEventArgs e)
        {
            if (sender == txtPhone)
            {
                // allow number and backspace and "-" sign
                if (!char.IsNumber(e.KeyChar) &
                    !char.IsControl(e.KeyChar)&
                    e.KeyChar!='-')

                    e.Handled = true;
            }
        }

        private void selectAllMethod(object sender, EventArgs e)
        {
            // call select all method on the basis of  selected textbox
            if (sender == txtEmail)
            {
                txtEmail.SelectAll();
            }else if(sender== txtPhysicalAddress){
                txtPhysicalAddress.SelectAll();
            }else if(sender == txtPhone)
            {
                txtPhone.SelectAll();
            }
        }

      
    }
}
