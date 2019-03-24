using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuesser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            answerOutput.Text = "Think of a number! [1 - 100]";
        }

        private void startPress_Click(object sender, EventArgs e)
        {
            MainGuess.StartGame();
            answerOutput.Text = MainGuess.CurrentValue.ToString();
        }

        private void answerOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void correctGuess_Click(object sender, EventArgs e)
        {
            MainGuess.CorrectGuess();
            answerOutput.Text = "Think of a number! [1 - 100]";
        }

        private void highGuess_Click(object sender, EventArgs e)
        {
            MainGuess.HighGuess();
            answerOutput.Text = MainGuess.CurrentValue.ToString();
        }

        private void tooLow_Click(object sender, EventArgs e)
        {
            MainGuess.LowGuess();
            answerOutput.Text = MainGuess.CurrentValue.ToString();
        }
    }
}
