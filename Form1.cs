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
            double feetInput = double.Parse(userInput);
            double metersConvert = Math.Round(feetInput * 0.3048,2);

            metersOutput.Text = metersConvert.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}