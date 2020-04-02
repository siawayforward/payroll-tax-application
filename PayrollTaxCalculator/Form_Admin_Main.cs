/*
 *Program:PayRoll Tax calculator Application
 * Purpose: Main Form for admin from where admin is redirect to following form:
 * -Helpful Links and ABoutUs Frm
 * -Update contact Form
 * -Update Tax Rate Form
 * - view Feedback Form
 * and logout method redirects to login form
 * Author:srijana lawa
 * Date:2018/11/23
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
    public partial class adminHomeForm : Form
    {
        public adminHomeForm()
        {
            InitializeComponent();
        }

        private void btnSiteLinkUpdates_Click(object sender, EventArgs e)
        {
            //open updateFulLink form and hide the admin main form
            Helpful_Links_and_AboutUs_Frm updateHelpFulLink = new Helpful_Links_and_AboutUs_Frm();
            updateHelpFulLink.Show();
            this.Hide();
            Program.previousPage = this;
        }

        private void btnContactUpdate_Click(object sender, EventArgs e)
        {
            //open updateContactForm form and hide the admin main form
            updateContactForm updateContact = new updateContactForm();
            updateContact.Show();
            this.Hide();

            // set this form as previous form
            Program.previousPage = this;
        }

        private void btnTaxRateUpdate_Click(object sender, EventArgs e)
        {
            //open TaxRateUpdate form and hide the admin main form
            updateTaxRateForm updateTaxrate = new updateTaxRateForm();
            updateTaxrate.Show();
            this.Hide();

            // set this form as previous form
            Program.previousPage = this;
        }

        private void btnViewFeeback_Click(object sender, EventArgs e)
        {
            //open viewFeedback form and hide the admin main form
            viewFeedBackForm feedbackform = new viewFeedBackForm();
            this.Hide();
            feedbackform.Show();

            // set this form as previous form
            Program.previousPage = this;
          
        }

        private void adminHomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //calling formclosing method declared in Progam.cs
            Program.FormClosingMethod(sender, e);
        }

        private void btnlogOut_Click(object sender, EventArgs e)
        {
            //show mainPage
            this.Hide();
            Program.MainPage.Show();
          
        }
    }
}
