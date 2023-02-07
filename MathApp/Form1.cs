namespace MathApp
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer to generate random numbers
        Random randomizer = new Random();

        // These integer variables store the numbers 
        // for the addition problem. 
        int add1;
        int add2;

        int rem1;
        int rem2;


        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            add1 = randomizer.Next(51);
            add2 = randomizer.Next(51);

            rem1 = randomizer.Next(51, 100);
            rem2 = randomizer.Next(51);

            plusLeftLabel.Text = add1.ToString();
            plusRightLabel.Text = add2.ToString();


            minusLeftLabel.Text = rem1.ToString();
            minusRightLabel.Text = rem2.ToString();

            equalsNum1.Enabled = true;
            equalsNum2.Enabled = true;

            equalsNum1.Value = 0;
            equalsNum2.Value = 0;
        }

        private void equalsNum1_Click(object sender, EventArgs e)
        {
            this.Text = "";
        }
    }
}