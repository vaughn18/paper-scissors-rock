using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        private Start battle = new Start();
        private string choice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            User();
            Robot();
            lblResult.Text = battle.Battle(lblYou.Text, lblRobot.Text);
            Score();
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton tempRB = (RadioButton)sender;

            choice = tempRB.Text;
        }

        public void User()
        {
            lblYou.Text = battle.User(choice);

            if (choice == "Rock")
            {
                pbxUserWeap.Image = Properties.Resources.Rock;
            }
            else if (choice == "Paper")
            {
                pbxUserWeap.Image = Properties.Resources.Paper;
            }
            else if (choice == "Scissors")
            {
                pbxUserWeap.Image = Properties.Resources.Scissors;
            }
        }

        public void Robot()
        {
            lblRobot.Text = battle.Robot();

            if (lblRobot.Text == "Rock")
            {
                pbxRobotWeap.Image = Properties.Resources.Rock;
            }
            else if (lblRobot.Text == "Paper")
            {
                pbxRobotWeap.Image = Properties.Resources.Paper;
            }
            else if (lblRobot.Text == "Scissors")
            {
                pbxRobotWeap.Image = Properties.Resources.Scissors;
            }
        }

        public void Score()
        {
            if (lblResult.Text == "You win")
            {
                lblWins.Text = battle.Score(lblWins.Text);
            }
            else if (lblResult.Text == "Its a tie")
            {
                lblTies.Text = battle.Score(lblTies.Text);
            }
            else if (lblResult.Text == "You Loss")
            {
                lblLoss.Text = battle.Score(lblLoss.Text);
            }
        }
    }
}
