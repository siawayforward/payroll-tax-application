/* Name: Payroll Tax Calculator
 *       Section: Profile Confirmation (profile users) & employee information entry (guest users)
 * Purpose: This portion of the application allows users to either confirm their profile information if they have made
 *          an account. The data would be pulled from the database table for user data and the user can review and
 *          change this information if needed before any tax calculations take place. For guest users, this page will
 *          be blank when they "continue as guest" from the previous page. Here, they can enter all the needed data for
 *          calculation. If they forget to enter some items, they will be prompted to do so before they can continue to
 *          the application page for salary information.
 * Programmer: Sia Mbatia
 * Date: November 18, 2018
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

namespace Payroll_Tax_Application
{
    public partial class Form_ConfirmProfile : Form
    {
        //define variable for username for compatibility check
        string username;

        public Form_ConfirmProfile(string user) //from log in form
        {
            InitializeComponent();

            //get username 
            username = user;
        }

        private void Form_ConfirmProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            //close the application
            Application.Exit();
        }

        //defining UI messages and display texts
        const string GUEST_NAME = "Guest User";
        const string GUEST_USERNAME = "guestUser";
        const string STATES_ERR = "Please select the U.S. state(s) in which you worked during the tax year";
        const string MARITAL_ERR = "Please select your marital status";
        const string ACCOUNT_USER = "Please confirm your profile information";
        const string GUEST_USER = "Please enter the required information below";
        const string REVIEW_QUESTION = "Proceed to application page?";

        //define array that will be used to store values
        string[] userData = { "", "", "", "", "", "", "" };

        private void frmConfirmProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.taxUsersDataSet.tblUsers);
            if (username != "") //if user has an account
            {
                //display appropriate note
                lblConfirmProfile.Text = ACCOUNT_USER;

                //display user values
                userData[0] = Convert.ToString(this.tblUsersTableAdapter.GetUsername(username));
                userData[1] = Convert.ToString(this.tblUsersTableAdapter.GetEmployeeName(username));
                userData[2] = Convert.ToString(this.tblUsersTableAdapter.GetState_AZIdentifier(username));
                userData[3] = Convert.ToString(this.tblUsersTableAdapter.GetState_NVIdentifier(username));
                userData[4] = Convert.ToString(this.tblUsersTableAdapter.GetState_UTIdentifier(username));
                userData[5] = Convert.ToString(this.tblUsersTableAdapter.GetMaritalStatus(username));

                //Load data
                txtName.Text = userData[1];
                if (userData[2] == 1.ToString())
                    chkArizona.CheckState = CheckState.Checked;
                if (userData[3] == 1.ToString())
                    chkNevada.CheckState = CheckState.Checked;
                if (userData[4] == 1.ToString())
                    chkUtah.CheckState = CheckState.Checked;
                if (userData[5] == "M")
                    rdbMarried.Checked = true;
                else
                    rdbSingle.Checked = true;


            }

            else //if user is a guest
            {
                //display appropriate note and fill name
                lblConfirmProfile.Text = GUEST_USER;
                txtName.Text = GUEST_NAME;

            
    }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //check that all information is entered
            //state(s) of employment
            if (!chkArizona.Checked && !chkNevada.Checked && !chkUtah.Checked)
                //notify the user
                MessageBox.Show(STATES_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //marital status
            else if (!rdbSingle.Checked && !rdbMarried.Checked)
                //notify the user
                MessageBox.Show(MARITAL_ERR, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //continue to the application
            else
            {
                //define variables for application method (if the user is a guest)
                if (username == "")
                {
                    //username and name
                    userData[0] = GUEST_USERNAME;
                    userData[1] = txtName.Text;

                    //states
                    if (chkArizona.Checked)
                        userData[2] = 1.ToString();
                    if (chkNevada.Checked)
                        userData[3] = 1.ToString();
                    if (chkUtah.Checked)
                        userData[4] = 1.ToString();

                    //marital status
                    if (rdbSingle.Checked)
                        userData[5] = "S";
                    else userData[5] = "M";
                }
                
                //ask user to review before they proceed
                if (MessageBox.Show(REVIEW_QUESTION, Program.APP_NAME, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                      
                    //create an instance for the application form
                    Form_Application frmApplication = new Form_Application(userData);
                    //show the instance
                    frmApplication.Show();

                    //hide current form
                    this.Hide();

                    //identify this as a previous form (placeholder)
                    Program.previousPage = this;

    
                }
            }
        }

        private void input_SelectionChanged(object sender, EventArgs e)
        {
            //update values as changes are made
            //states
            if (chkArizona.Checked)
                userData[2] = 1.ToString();
            else
                userData[2] = 0.ToString();
            if (chkNevada.Checked)
                userData[3] = 1.ToString();
            else
                userData[3] = 0.ToString();
            if (chkUtah.Checked)
                userData[4] = 1.ToString();
            else
                userData[4] = 0.ToString();

            //marital status
            if (rdbSingle.Checked)
                userData[5] = "S";
            if (rdbMarried.Checked)
                userData[5] = "M";
        }

        private void tblUsersBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }
    }
}
