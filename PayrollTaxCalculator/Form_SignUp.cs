/*
  Program Name: PayRoll Tax Calculation/ Signup Form
  Purpose: To get the user's sign up information and save the data in our database. In case of any empty fields or errors, show them relevant error messages.
  Programmer: Alireza Javid
  Date: 12/02/2018
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using PayRollTaxCalculator;
using System.Windows.Forms;



 

namespace SignUp_Form
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }

        // defining global variable
        string Arizona="0";
        string Nevada="0";
        string Utah="0";
        string MaritalStatus;

        // defining constants
        const string NULL_VALUE_MSG = "All the information are required to be filled." +
            " Please fill all the information in the form";
        const string MARITAL_STATUS_MSG = "Please select your marital status";
        const string STATE_ERROR_MSG = "Please select at least one state where you worked in.";
        const string PASSWORD_LENGHT_MSG = "Password should be at least 8 characters long. Please enter a new password.";
        const string PASSWORDS_DONT_MATCH_MSG = "Passwords do not match. Please enter the correct password.";
        const string SIGNUP_SUCCESS_MSG = "You successfully signed up.";

        private void btnSignUp_Click(object sender, EventArgs e)
        {// check for null values
          
            if (txtName.Text == "" || 
                txtEmail.Text == "" ||
                txtUserName.Text == "" ||
                txtPassword.Text == "" ||
                txtConfirm.Text == "" )
            {// if any null values, show error message
                MessageBox.Show(NULL_VALUE_MSG, Program.APP_NAME, MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            // if password lenght is not long enough
            else if (txtPassword.Text.Length < 8)
            {// show error message
                MessageBox.Show(PASSWORD_LENGHT_MSG, Program.APP_NAME,
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
            // if password and confirmed password are not the same
            else if (txtPassword.Text != txtConfirm.Text)
            {// show error message
                MessageBox.Show(PASSWORDS_DONT_MATCH_MSG, Program.APP_NAME,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirm.Focus();
            }
            // if marital status radiobuttons are not checked
            else if (!rdbSingle.Checked && !rdbMarried.Checked)
            {// show the error message
                MessageBox.Show(MARITAL_STATUS_MSG, Program.APP_NAME, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
            }
            // if state chechboxes are not checked
            else if (!chkArizona.Checked && !chkNevada.Checked && !chkUtah.Checked)
            {// show the relevant error message
                MessageBox.Show(STATE_ERROR_MSG, Program.APP_NAME, MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
            }
        else
            {

                if (NoName(txtUserName.Text))
                {
                    //calling insert method. Here 1 in the query means user is member not a guest
                    tblUsersTableAdapter.InsertUserQuery(1, txtUserName.Text, txtPassword.Text, txtName.Text, Arizona, Nevada, Utah, MaritalStatus, txtEmail.Text);

                    // show sign up success message to user.
                    MessageBox.Show(SIGNUP_SUCCESS_MSG, Program.APP_NAME, MessageBoxButtons.OK);

                    //clearing all the fields after sucessfull sign Up
                    txtEmail.Text = "";
                    txtConfirm.Text = "";
                    txtName.Text = "";
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    rdbMarried.Checked = false;
                    rdbSingle.Checked = false;
                    chkArizona.Checked = false;
                    chkNevada.Checked = false;
                    chkUtah.Checked = false;

                    this.Hide();
                    Program.previousPage.Show();
                }
                else
                {
                    // show sign up success message to user.
                    MessageBox.Show("This User name has already been registered. Please use other name", Program.APP_NAME, MessageBoxButtons.OK);

                }

            }
           

        }

        //checking if same name is present or not
        private bool NoName(string name)
        {
            bool isAbsent = true;        
            //find row of name
            tblUsersTableAdapter.FillByName(taxUsersDataSet.tblUsers);
            //count the rows returned
            int count = tblUsersBindingSource.Count;
           
                //  compare every name
                for (int i = 0; i < count; i++)
                {
                    if( name == taxUsersDataSet.tblUsers.Rows[i]["Username"].ToString())
                {
                    isAbsent = false;
                }
                  
                }

            return isAbsent;
        }
        private void chkArizona_CheckedChanged(object sender, EventArgs e)
        {
            // setting value in the states. Here 1 represents the user are working in those state
            if (chkArizona.Checked)
            {
                Arizona = "1";
            }
            if (chkNevada.Checked)
            {
                Nevada = "1";
            }
            if (chkUtah.Checked)
            {
                Utah = "1";
            }
        }
        private void maritalStateChangedTask(object sender, EventArgs e)
        {
            //setting MaritalStatus. Here S means single and M  means married
            if (rdbSingle.Checked)
            {
                MaritalStatus = "S";
            }
            if (rdbMarried.Checked)
            {
                MaritalStatus = "M";
            }
        }

        private void tblUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {// information gets saved into the database
            this.Validate();
            this.tblUsersBindingSource.EndEdit();
          

        }

        private void Form_SignUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.taxUsersDataSet.tblUsers);


        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {// it only accepts letter, space, and backspace
            if (!char.IsLetter(e.KeyChar) &&
               !char.IsControl(e.KeyChar) &&
               (e.KeyChar != ' '))
                e.Handled = true;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {// it does not allow space in email address
            if (e.KeyChar == ' ')
                e.Handled = true;
        }

        private void tblUsersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tblUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.taxUsersDataSet);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.BackMethod(sender, e); 
        }

        private void Form_SignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FormClosingMethod(sender, e);
        }
    }
}
