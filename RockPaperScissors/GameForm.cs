using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class GameForm : Form
    {
        public int userScore = 0;
        public int comScore = 0;
        public GameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comScore = 0;
            userScore = 0;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rockPaperScissors(1);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            rockPaperScissors(2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            rockPaperScissors(3);
        }
        private void rockPaperScissors(int userChoise)
        {
            Random rand = new Random();
            int computerChoise = rand.Next(1, 4);
            setComputerChoiseImg(computerChoise);
            checkResult(userChoise,computerChoise);

        }
        private void checkResult(int userChoise, int computerChoise)
        {
            if((userChoise == 1 && computerChoise == 1) || (userChoise == 2 && computerChoise == 2) || (userChoise == 3 && computerChoise == 3))
            {
                result.Text = "Drow!";
            }

            else if ((userChoise == 1 && computerChoise == 2) || (userChoise == 2 && computerChoise == 3) || (userChoise == 3 && computerChoise == 1))
            {
                comScore++;
                result.Text = "Computer Wins!";
                lblComputerScore.Text = comScore.ToString();
            }
            else
            {
                userScore++;
                result.Text = "You Win! :)";
                lblUserScore.Text = userScore.ToString();
            }

        }
        private void setComputerChoiseImg(int computerChoise)
        {
            Bitmap imageName;
            switch(computerChoise)
            {
                case 1:
                    imageName = Properties.Resources.icons8_hand_rock_48;
                    break;
                case 2:
                    imageName = Properties.Resources.icons8_hand_48;
                    break;
                default:
                    imageName = Properties.Resources.icons8_hand_scissors_48;
                    break;
            }
            pictureBox1.Image = imageName;
        }
    }
}
