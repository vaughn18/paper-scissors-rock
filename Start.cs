using System;

namespace RockPaperScissors
{
    class Start
    {
        private string[] choices = { "Rock", "Paper", "Scissors" };
        private string message;
        public string Robot()
        {
            Random CompGuess = new Random();

            int RndComputerChoice = CompGuess.Next(0, 3);

            return choices[RndComputerChoice];
        }

        public string User(string input)
        {
            if (input == "Rock")
            {
                return input;
            }
            else if (input == "Paper")
            {
                return input;
            }
            else if (input == "Scissors")
            {
                return input;
            }

            return null;
        }

        public string Battle(string human, string robot)
        {
            string[] win = { "ScissorsPaper", "RockScissors", "PaperRock" };
            string[] tie = { "ScissorsScissors", "RockRock", "PaperPaper" };
            string[] lose = { "PaperScissors", "RockPaper", "ScissorsRock" };

            string fighters = human + robot;

            for (int i = 0; i < 3; i++)
            {
                if (win[i] == fighters)
                {
                    message = "You win";
                    return message;
                }
                else if (tie[i] == fighters)
                {
                    message = "Its a tie";
                    return message;
                }
                else if (lose[i] == fighters)
                {
                    message = "You Loss";
                    return message;
                }
            }
            return null;
        }

        public string Score(string score)
        {
            int finalScore = Int16.Parse(score);

            finalScore++;

            return finalScore.ToString();
        }
    }
}
