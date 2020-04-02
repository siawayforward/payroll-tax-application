/* Project: PayRoll Tax calculator Application
 * Purpose: to calculate payroll tax fro employees working in the Nevada-Arizona-Utah tristate area
 * Programers: Siangicha Mbatia, Srijana Lawa, Alireza Javid, Ying Zhao 
 * Date: 11/20/2018
*/

using System;
using System.Windows.Forms;




namespace PayRollTaxCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }

        //create a static variable to keep track of the last form
        public static Form previousPage;

        // //create a static variable to keep track of the last form after showing dialog
        public static Form MainPage;

        //Global Application name
        public const String APP_NAME = "Payroll Tax Calculator Application";


        //creating static method for back button
        public static void BackMethod(object sender, EventArgs e)
        {
            Program.previousPage.Show();
        }


        //creating static method for formclosing
        public static void FormClosingMethod(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //method to allow number only on key press
        public static void allowNumberOnlyMethod(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.')
                e.Handled = true;

        }

        //method to allow Letter only on key press
        public static void allowLetterOnlyMethod(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //method to allow number and digit only on key press
        public static void cancelKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != '.')
                e.Handled = true;

        }

    
}
}
