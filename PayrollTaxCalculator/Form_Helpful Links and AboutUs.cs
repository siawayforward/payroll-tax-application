/*
 *Program:PayRoll Tax calculator Application
 * Purpose: Admin can update about us information and will be able to upload helful links on 
 * the of category on helpfullink.txt file
 * Author:srijana lawa
 * Date:2018/11/28
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
    public partial class Helpful_Links_and_AboutUs_Frm : Form
    {
        public Helpful_Links_and_AboutUs_Frm()
        {
            InitializeComponent();
        }

        // array for category
        string[] Category = { "Helpful Info", "IRS Instructions", "News" };
        // constant for file name
        const string FILE_NAME = "HelpfulLinks.txt";
        const string DATA_UPLOADED= "Helpful link has been uploaded";
        const string NULL_LINK = "Please add links for this category";
        const string NULL_TITLE = "Please enter title to be shown";

        private void btnAddDesp_Click(object sender, EventArgs e)
        {
            //opening add description form  and hiding this form 
            AddDescriptionForm descriptionFrm = new AddDescriptionForm();
            descriptionFrm.Show();

            this.Hide();
            Program.MainPage = this;
        }

        private void Helpful_Links_and_AboutUs_Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //calling formClosingMethod to exist application
            Program.FormClosingMethod(sender,e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // calling backmethod go to previous form
            Program.BackMethod(sender, e);
            this.Hide();
        }

        private void Helpful_Links_and_AboutUs_Frm_Load(object sender, EventArgs e)
        {
            //loading type in combo box
            foreach (string type in Category)
                cmbType.Items.Add(type);
                cmbType.SelectedIndex = 0;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

            if (txtLinks.Text.Length == 0) {
                // check for no link
                MessageBox.Show(NULL_LINK, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (txtTitle.Text.Length == 0) {
                // check for no title
                MessageBox.Show(NULL_TITLE, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                //opening a file and writing in it
                StreamWriter outFile = new StreamWriter(FILE_NAME, true); // i have used true to append the file data
                string outputString = cmbType.SelectedItem + ";" + txtTitle.Text + ";" + txtLinks.Text + "\n";
                outFile.WriteLine(outputString);
                //closing the  file after writing
                outFile.Close();

                MessageBox.Show(DATA_UPLOADED, Program.APP_NAME);

                //clear the link textbox after upload
                txtLinks.Text = "";
                txtTitle.Text = "";
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the link  and title textbox on change of category
            txtLinks.Text = "";
            txtTitle.Text = "";
   
        }

        private void selectAllMethod(object sender, EventArgs e)
        {
            //calling select all method on the basis of clicked texbox
            if (sender == txtTitle)
            {
                txtTitle.SelectAll();
            }
            if (sender == txtLinks)
            {
                txtLinks.SelectAll();
            }
        }
    }
}
