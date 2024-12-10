using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hermes.Pages
{
    public partial class frmRockPaperScissors : Form
    {

        string playerChoice;
        string computerChoice;
        string[] Options = { "R", "P", "S", "P", "S", "R" };
        Random random = new Random();
        int computerScore;
        int playerScore;
        string draw;

        public frmRockPaperScissors()
        {
            InitializeComponent();
        }

        private void MakeChoiceEvent(object sender, EventArgs e)   
        {
            Button tempButton = sender as Button;
            playerChoice = (string)tempButton.Tag;
            
            int i = random.Next(0, Options.Length); //Generates random numbers between 0 and 6
            computerChoice = Options[i];
            
            lblPlayerchoice.Text = "Player is: " + UpdateTextandImage(playerChoice, PLAYER_PIC);
            lblCPUchoice.Text = "Computer is: " + UpdateTextandImage(computerChoice, CPU_PIC);
            CheckGame();
        }
        private string UpdateTextandImage(string text, PictureBox pic)
        {
            string word = null;
            switch (text)
            {
                case "R":
                    word = "Rock";
                    pic.Image = Properties.Resources.ROCK;
                    break;
                case "P":
                    word = "Paper";
                    pic.Image = Properties.Resources.PAPER;
                    break;
                case "S":
                    word = "Scissors";
                    pic.Image = Properties.Resources.SCISSORS;
                    break;
            }
            return word;
        }
        private void CheckGame()   
        {
            if (computerChoice == playerChoice)
            {
                draw = " Draw!";
            }
            else if (playerChoice == "R" && computerChoice == "P" || playerChoice == "S" && computerChoice == "R" || playerChoice == "P" && computerChoice == "S")
            {
                computerScore++;
                draw = null;
            }
            else
            {
                playerScore++;
                draw = null;
            }
            lblCPUresult.Text = "Computer Score: " + computerScore + Environment.NewLine + draw;
            lblPlayerresult.Text = "Player Score: " + playerScore + Environment.NewLine + draw;
        }
    }
}


