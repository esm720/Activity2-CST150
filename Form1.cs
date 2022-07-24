namespace Activity_2_W1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            String userInput = ftInput.Text;
        // Here we are going to use the "try" technique to verify that we can properly parse the input - Activity 6
            try
            {
                double feetInput = double.Parse(userInput);
        //Here we are rounding and printing to exactly three places behind the decimal. -Activty 6
                double metersConvert = Math.Round(feetInput * 0.3048, 3);
                metersOutput.Text = metersConvert.ToString();
            }
            /* Exception handling below, we didn't include ex because we are not -Activity 6
             * doing anything with the variable, as long as it is not a number, 
             * then we are going to catch the exception and tell the user to
             * correct their input.*/
            catch (Exception) 
            {
                MessageBox.Show("Incorrect input, enter a number.");
            }

          
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


/*
 * Enrique Sanchezmurillo
 * Activty-6 CST-150
 * 24 JUL 2022 
*/
