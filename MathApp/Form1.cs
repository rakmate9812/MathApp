using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MathApp
{
    public partial class Form1 : Form
    {
        // The tutorial of this project:
        // https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-windows-forms-math-quiz-create-project-add-controls?view=vs-2022

        // Create a Random object called randomizer to generate random numbers
        Random randomizer = new Random();

        // These integer variables store the numbers 
        int add1;
        int add2;

        int sub1;
        int sub2;

        int timeleft;

        public Form1()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startTheQuiz();
        }

        private void startTheQuiz()
        {

            startBtn.Enabled = false;

            // randomizing numbers, adding them to the form
            add1 = randomizer.Next(51);
            add2 = randomizer.Next(51);

            sub1 = randomizer.Next(51, 100);
            sub2 = randomizer.Next(51);

            plusLeftLabel.Text = add1.ToString();
            plusRightLabel.Text = add2.ToString();


            minusLeftLabel.Text = sub1.ToString();
            minusRightLabel.Text = sub2.ToString();

            // result inputs
            equalsNum1.Enabled = true;
            equalsNum2.Enabled = true;
            equalsNum1.Value = 0;
            equalsNum2.Value = 0;
            equalsNum1.Focus();

            // setting timeleft
            timeleft = 15;
            timeLabel.Text = "15 seconds";
            timer1.Start();
        }

        private bool checkAnswer()
        {
            return (add1 + add2 == equalsNum1.Value && sub1 - sub2 == equalsNum2.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // if checkAnswer returns true
            if (checkAnswer())
            {
                Debug.WriteLine("success");
                timer1.Stop();
                MessageBox.Show("You got all the answers right!",
                                "Congratulations!");
                equalsNum1.Enabled = false;
                equalsNum2.Enabled = false;
                startBtn.Enabled = true;
            }
            else if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                timeLabel.Text = timeleft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                equalsNum1.Value = add1 + add2;
                equalsNum2.Value = sub1 - sub2;
                equalsNum1.Enabled = false;
                equalsNum2.Enabled = false;
                startBtn.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
    }
}