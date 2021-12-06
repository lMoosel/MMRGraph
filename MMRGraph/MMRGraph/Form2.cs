using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MMRGraph
{
    public partial class Form2 : Form
    {
        Game playerGame = new Game(0, 0);
        AI opponent;
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            updateLabels();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {

            opponent.setPlayerValues(playerGame.getPlayerValues()[0], playerGame.getPlayerValues()[1]);
            playerGame.increaseValues(2, opponent.spendPoints());
            updateLabels();
            if (playerGame.getPlayerScores(1) >= 10)
            {
                lblGameResult.Text = "Player Wins";
            }
            else if (playerGame.getPlayerScores(2) >= 10)
            {
                lblGameResult.Text = "AI Wins";
            }
            else
            {
                int winningPlayer = playerGame.playRound();
                if (winningPlayer == 3)
                {
                    lblGameResult.Text = "Tied game";
                    btnEndTurn.Enabled = false;
                }
                else if(winningPlayer == 2)
                {
                    lblRoundResult.Text = "AI wins";
                }
                else if(winningPlayer == 0)
                {
                    lblRoundResult.Text = "Round tied";
                }
                else
                {
                    lblRoundResult.Text = "Player wins";
                }
            }

            btnRed.Enabled = true;
            btnBlue.Enabled = true;
            btnGreen.Enabled = true;
            btnYellow.Enabled = true;
            btnPurple.Enabled = true;
            lblTurnString.Text = playerGame.turnString;
            
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            playerGame.increaseValues(1,0);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnGreen.Enabled = false;
            btnYellow.Enabled = false;
            btnPurple.Enabled = false;
            updateLabels();
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            playerGame.increaseValues(1, 3);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnGreen.Enabled = false;
            btnYellow.Enabled = false;
            btnPurple.Enabled = false;
            updateLabels();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            playerGame.increaseValues(1, 2);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnGreen.Enabled = false;
            btnYellow.Enabled = false;
            btnPurple.Enabled = false;
            updateLabels();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            playerGame.increaseValues(1, 1);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnGreen.Enabled = false;
            btnYellow.Enabled = false;
            btnPurple.Enabled = false;
            updateLabels();
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            playerGame.increaseValues(1, 4);
            btnRed.Enabled = false;
            btnBlue.Enabled = false;
            btnGreen.Enabled = false;
            btnYellow.Enabled = false;
            btnPurple.Enabled = false;
            updateLabels();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {

            double[] weights1 = new double[80];
            double[] weights2 = new double[40];


            string[] temp = txtWeights.Text.Split(';');

            string[] temp2 = temp[0].Split(',');
            for(int i = 0; i < weights1.Length; i++)
            {
                weights1[i] = Convert.ToDouble(temp2[i]);
            }
            temp2 = temp[1].Split(',');

            for (int i = 0; i < weights2.Length-1; i++)
            {
                weights2[i] = Convert.ToDouble(temp2[i]);
            }

            opponent = new AI(weights1, weights2);
        }

        private void updateLabels()
        {
            int[] playerValues = playerGame.getPlayerValues()[0];
            int[] opponentValues = playerGame.getPlayerValues()[1];

            lblPlayerRed.Text = playerValues[0].ToString();
            lblPlayerBlue.Text = playerValues[1].ToString();
            lblPlayerGreen.Text = playerValues[2].ToString();
            lblPlayerYellow.Text = playerValues[3].ToString();
            lblPlayerPurple.Text = playerValues[4].ToString();
            
            lblAIRed.Text = opponentValues[0].ToString();
            lblAIBlue.Text = opponentValues[1].ToString();
            lblAIGreen.Text = opponentValues[2].ToString();
            lblAIYellow.Text = opponentValues[3].ToString();
            lblAIPurple.Text = opponentValues[4].ToString();

        }

        private void txtWeights_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
