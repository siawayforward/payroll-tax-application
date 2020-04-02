/* Project: Employee Payroll Tax Solution
 * Purpose: to calculate payroll tax fro employees working in the Nevada-Arizona-Utah tristate area
 * Programers: Siangicha Mbatia, Srijana Lawa, Alireza Javid, Ying Zhao 
 * Date: 12/04/2018
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
using SignUp_Form;
using Payroll_Tax_Application; // we were merging from different project so to access the form we had in different project we had to define namespace 
using TaxPayrollPay;
using System.Diagnostics;


namespace PayRollTaxCalculator
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }


       // constants for file name
        const string PROJECT_FILE_NAME = "PayrollTax.txt";  // text file for project data
        const string ABOUT_FILE_NAME = "Aboutus.txt";  // text file for Aboutus
        const string LINKS_FILE_NAME = "HelpfulLinks.txt";  // text file for links data
        const string CONTACT_FILE_NAME = "Contact.txt";  // text file for Contact data

        // constants for error messages
        const string MSG_NULL_NAME = "Please enter your name.";
        const string MSG_NULL_PASSWORD = "Please enter your password.";
        const string MSG_NULL_EMAIL = "Please enter your email address.";
        const string MSG_NULL_FEEDBACK = "Please enter your feedback.";
        const string MSG_THANK_YOU = "Thank you for your feedback! Our team will follow up with you within two business days.";
        const string NULL_VALUE_MSG = "Please enter both username and password";
        const string WRONG_DATA = "Please check your username and/or password.";
        const string INCORRECT_LOGIN_INFO = "Either your username or Password is incorrect . Please enter again";
        const string LOGIN_SUCCESS = "Login Successfull";

       

        List<String> helpLinks = new List<string>();
        List<String> newLinks = new List<string>();
        List<String> IRSLinks = new List<string>();


        // global varaible
        string[] linksData;

        private string[] readData(string fileName, int row)
        { // create a method to read the data from a txt file and store it 

            // output variable: a array to store the data
            string[] data = new string[row];
            int rowCount = 1;

            // declare StreamReade Variable
            StreamReader inFile = new StreamReader(fileName);

            //   declare a variable for a line in the file
            string currentLine = "";

            // string variable to store the items in a line 
            string[] rowItems;

            // declare a variable as counter of the row


            // read the file content until the end
            while (inFile.EndOfStream == false)
            {
                // read each line, split it, and store in the array
                currentLine = inFile.ReadLine();
                rowItems = currentLine.Split(';');

                // move to the next row
                rowCount++;
            }

            // close the file
            inFile.Close();

            //return the result
            return data;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.taxUsersDataSet.tblUsers);
            // TODO: This line of code loads data into the 'taxUsersDataSet.tblFeedback' table. You can move, or remove it, as needed.
            this.tblFeedbackTableAdapter.Fill(this.taxUsersDataSet.tblFeedback);

            // read content of About Us from file and show in the label

            //add header and note about the application
            lblHeader.Text = "US Payroll Tax Application";

            // declare StreamReade Variable
            StreamReader about = new StreamReader(ABOUT_FILE_NAME);
            //  declare a variable for a line in the file
            string aboutLine = "";
            // declare a variable for row count
            int aboutRow = 1;
            // declare string variable to store the items in a line
            // read the file content until the end
            while (about.EndOfStream == false)
            {
                // read each line, split it, and store in the array
                aboutLine = about.ReadLine();
                //add string to the label
                lblAbout.Text += aboutLine + "\n";
                // move to the next row
                aboutRow++;
            }
            // close the file
            about.Close();

            // read content of Links from file and show in ListView Box 
            StreamReader links = new StreamReader(LINKS_FILE_NAME);
            int rowCount = 1;
            while (links.EndOfStream == false)
            {
                //read and split lines
                linksData = links.ReadLine().Split(';');
                if (linksData[0] == "IRS Instructions")
                {
                    //Add IRS links
                    lvwIRS.Items.Add(linksData[1]);
                    lvwIRS.HotTracking = true;
                    IRSLinks.Add(linksData[2]);

                }
                else if (linksData[0] == "Helpful Info")
                {
                    //Add helpful links
                    lvwHelp.Items.Add(linksData[1]);
                    lvwHelp.HotTracking = true;
                    helpLinks.Add(linksData[2]);
                }
                else if (linksData[0] == "News")
                {
                    //Add news 
                    lvwNews.Items.Add(linksData[1]);
                    lvwNews.HotTracking = true;
                    newLinks.Add(linksData[2]);

                }
                rowCount++;
            }
            //close the file
            links.Close();

            // read content of Contact Us from file and show in the labels
            // declare StreamReader Variable
            StreamReader contact = new StreamReader(CONTACT_FILE_NAME);
            //  declare a variable for a line in the file
            string contactLine = "";
            // declare an array variable to store the items 
            string[] contactItems;
            // read the line, split it and store in the array
            contactLine = contact.ReadLine();
            contactItems = contactLine.Split(';');

            // close the file
            contact.Close();
            // display the context for the labels
            lblEmail.Text = contactItems[0].PadLeft(10, ' ');
            lblPhone.Text = contactItems[1].PadLeft(10, ' ');
            lblAddress.Text = contactItems[2].PadLeft(10, ' ');

            Program.MainPage = this;


            //setting acceptbutton
            //set accept button on basis of selected tab
            if (tabMain.SelectedTab== tabHome)
            {
                this.AcceptButton = btnAccount;
            }
            if (tabMain.SelectedTab == tabHelp)
            {
                this.AcceptButton = btnContinue;
            }
            if (tabMain.SelectedTab == tabContact)
            {
                this.AcceptButton = btnSend;
            }
            if (tabMain.SelectedTab == tabAccount)
            {
                this.AcceptButton = btnLogin;
                txtUserName.Focus();
            }

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // show the second tab
            tabMain.SelectedIndex = 1;
        }

        private void btnContact_Click(object sender, EventArgs e) // ???
        {
            // show the third tab
            tabMain.SelectedIndex = 2;
        }

     

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            // direct user to my account page for sign up or login in
            tabMain.SelectedIndex = 3;
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            // check null values
            if (txtName.Text.Trim() == "")
                MessageBox.Show(MSG_NULL_NAME, "Send a Feedback",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtEmail.Text.Trim().Length == 0)
                MessageBox.Show(MSG_NULL_EMAIL, "Send a Feedback",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtComments.Text.Trim().Length == 0)
                MessageBox.Show(MSG_NULL_FEEDBACK, "Send a Feedback",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {   // get user input
                string name = txtName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string feedback = txtComments.Text.Trim();

                // get feedback date by system
                DateTime date = DateTime.Now;

                //use the InsertQuery to insert the content
               tblFeedbackTableAdapter.InsertQuery(name, email, feedback, date.ToString());

                //notify user
                MessageBox.Show(MSG_THANK_YOU, Program.APP_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

                // clear the textboxes
                txtName.Text = "";
                txtEmail.Text = "";
                txtComments.Text = "";
            }
            //go back to home page
            tabMain.SelectedIndex = 0;
        }



        private void lnkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabMain.SelectedIndex = 1; //go to help tab
        }

        private void btnGoToAccount_Click(object sender, EventArgs e)
        {
            //go to account log in/entry tab
            tabMain.SelectedIndex = 3;
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
        private void btnLogIn_Click(object sender, EventArgs e)
        {   //defining a variable for Password
            string password;

            //checking for empty text
            if (txtUserName.Text == "" || txtPassword.Text == "")
            {// if so, show error message
                MessageBox.Show(NULL_VALUE_MSG, Program.APP_NAME,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
            }
            else
            {
                password = tblUsersTableAdapter.LoginQuery(txtUserName.Text);

                //check to see if username and password match our records in the database
                if (txtPassword.Text != password)           // HOW ABOUT FOR USERNAME????
                {// if not, show relevant error message
                    MessageBox.Show(INCORRECT_LOGIN_INFO, Program.APP_NAME,
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                // if everything looks good, then
                else
                {
                    // cheking usertype to redirect different form on the basis of type
                    int UserType = (int)tblUsersTableAdapter.GetUserType(txtUserName.Text, password);

                    if (UserType == 1)
                    {
                        //create instance of profile form
                        Form_ConfirmProfile frmConfirmProfile = new Form_ConfirmProfile(txtUserName.Text);
                        //display new form
                        frmConfirmProfile.Show();

                        //hide current form
                        this.Hide();
                    }
                    else if (UserType == 0)
                    {
                        // open admin amin Page
                        adminHomeForm adminHomeForm = new adminHomeForm();
                        //display new form
                        adminHomeForm.Show();
                        // hide the current page
                        this.Hide();



                    }

                    //clearing the textbox
                    txtUserName.Text = "";
                    txtPassword.Text = "";


                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        { 
            // Hides the login form and shows the sign up form to user
            this.Hide();
            Form_SignUp Frmsignup = new Form_SignUp();
            Frmsignup.Show();
            Program.previousPage = this;
        }

        private void btnLoginAsGuest_Click(object sender, EventArgs e)
        {
            //create instance of profile form
            Form_ConfirmProfile frmConfirmProfile = new Form_ConfirmProfile(txtUserName.Text);
            //display new form
            frmConfirmProfile.Show();

            //hide current form
            this.Hide();
        }

        private void Main_Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.FormClosingMethod(sender, e);
        }


        private void lvwHelp_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < lvwHelp.Items.Count; i++)
            {
                // if the the item is checked 
                if (lvwHelp.Items[i].Checked)
                {
                    ProcessStartInfo sInfo = new ProcessStartInfo(new Uri(helpLinks[i].ToString()).AbsoluteUri);
                    Process.Start(sInfo);

                    lvwHelp.Items[i].Checked = false;
                    break;
                }

            }
        }

        private void lvwIRS_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < lvwIRS.Items.Count; i++)
            {
                // if the the item is checked 
                if (lvwIRS.Items[i].Checked)
                {
                    ProcessStartInfo sInfo2 = new ProcessStartInfo(new Uri(IRSLinks[i].ToString()).AbsoluteUri);
                    Process.Start(sInfo2);

                    lvwIRS.Items[i].Checked = false;
                    break;
                }

            }
        }

        private void lvwNews_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            for (int i = 0; i < lvwNews.Items.Count; i++)
            {
                // if the the item is checked 
                if (lvwNews.Items[i].Checked)
                {
                    ProcessStartInfo sInfo1 = new ProcessStartInfo(new Uri(newLinks[i].ToString()).AbsoluteUri);
                    Process.Start(sInfo1);

                    lvwNews.Items[i].Checked = false;
                    break;
                }

            }
        }
    }
}
