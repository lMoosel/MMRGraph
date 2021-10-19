using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MMRGraph
{
    public partial class Form1 : Form
    {
        Game[] listOfGames = new Game[200];
        AI[] listOfAI = new AI[400];
        Random gen = new Random();
        int lineCount = 0;
        int spacing = 500;
        int recordings = 0;
        public Form1()
        {
            StreamWriter sw = new StreamWriter("C:\\MMRGraph\\MMRcsv.txt");
            string headers = "";
            
            for (int i =0; i < listOfAI.Length; i++)
            {
                headers = headers + ",AI" + i;
                listOfAI[i] = new AI(gen);
            }
            sw.WriteLine(headers);
            sw.Close();
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblAITiers.Text = "started";
            startGames();
        }


       private void matchmaker()
        {
            int[] player1 = {0, 0};
            int[] player2 = { 0, 0 };
            
            for(int i = 0; i < listOfGames.Length; i++) {
                for (int j = 0; j < listOfAI.Length; j++)
                {
                    if (listOfAI[j].getHasGame())
                    {
                        continue;
                    }
                    else if(listOfAI[j].getMMR() > player1[1])
                    {
                        player2[0] = player1[0];
                        player2[1] = player2[1];
                        player1[0] = j;
                        player1[1] = listOfAI[j].getMMR();
                    }
                }

                listOfGames[i] = new Game(player1[0],player2[0]);
                listOfAI[player1[0]].setHasGame(true);
                listOfAI[player2[0]].setHasGame(true);
                listOfGames[i].Activate();
                listOfAI[listOfGames[i].player1ID].setPlayerNumber(1);
                listOfAI[listOfGames[i].player2ID].setPlayerNumber(2);
            }

        }


        private void startGames() 
        {
            string outputString = "";
            StreamWriter sw;
            lineCount++;

            for (int i = 0; i < listOfAI.Length; i ++)
            {
                listOfAI[i].setHasGame(false); 
            }

            matchmaker();

            tmrTurns.Start();

            /*
             * Records data as a CSV every set interval in order to graph the data in other software
            if (lineCount == spacing)
            {
                if (recordings <= 255)
                {
                    recordings++;
                    for (int i = 0; i < listOfAI.Length; i++)
                    {
                        outputString = outputString + "," + listOfAI[i].getMMR();
                    }
                    sw = File.AppendText("C:\\MMRGraph\\MMRcsv.txt");
                    sw.WriteLine(outputString);
                    sw.Close();
                    lineCount = 0;
                }
                else
                {
                    lblAITiers.Text = "Maxed Recordings";
                }
            }
            */
           
        }
        private void playRound()
        {
            
            for (int i = 0; i < listOfGames.Length; i++)
            {
                bool oneActive = false;
                if (listOfGames[i].isActive())
                {
                    oneActive = true;
                    listOfAI[listOfGames[i].player1ID].setPlayerValues(listOfGames[i].getPlayerValues()[0], listOfGames[i].getPlayerValues()[1]);
                    listOfAI[listOfGames[i].player2ID].setPlayerValues(listOfGames[i].getPlayerValues()[0], listOfGames[i].getPlayerValues()[1]);
                    if (listOfGames[i].getPlayerScores(1) >= 10)
                    {
                        double mmrChange = Convert.ToDouble(listOfAI[listOfGames[i].player2ID].getMMR()) / (listOfAI[listOfGames[i].player1ID].getMMR() + listOfAI[listOfGames[i].player2ID].getMMR()) * 10;
                        listOfAI[listOfGames[i].player2ID].changeMMR(-mmrChange);
                        listOfAI[listOfGames[i].player1ID].changeMMR(mmrChange);
                        
                        listOfGames[i].Deactivate();
                    }
                    else if (listOfGames[i].getPlayerScores(0) >= 10)
                    {
                        double mmrChange = Convert.ToDouble(listOfAI[listOfGames[i].player1ID].getMMR()) / (listOfAI[listOfGames[i].player1ID].getMMR() + listOfAI[listOfGames[i].player2ID].getMMR()) * 10; ;
                        listOfAI[listOfGames[i].player1ID].changeMMR(-mmrChange);
                        listOfAI[listOfGames[i].player2ID].changeMMR(mmrChange);
                        
                        listOfGames[i].Deactivate();

                    }
                    else
                    {
                        if (listOfGames[i].playRound() == 3)
                        {
                            tmrTurns.Stop();
                            startGames();
                            
                        }
                        listOfGames[i].increaseValues(listOfAI[listOfGames[i].player1ID].getPlayerNumber(), listOfAI[listOfGames[i].player1ID].spendPoints());
                        listOfGames[i].increaseValues(listOfAI[listOfGames[i].player2ID].getPlayerNumber(), listOfAI[listOfGames[i].player2ID].spendPoints());
                    }
                }
                if (!oneActive)
                {
                    tmrTurns.Stop();
                    startGames();
                }
            }
        }

        private void tmrTurns_Tick(object sender, EventArgs e)
        {
            playRound();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            StreamWriter sw;
            string outputString = "";
            int bestAI = 0;
            double[][] weights;
            sw = File.AppendText("C:\\MMRGraph\\BestWeights.txt");

            for (int i = 0; i < listOfAI.Length; i++)
            {
                if (listOfAI[i].getMMR() > listOfAI[bestAI].getMMR())
                {
                    bestAI = i;
                }
            }

            weights = listOfAI[bestAI].getWeights();

            for (int i = 0; i < weights.Length; i++)
            {
                for (int j = 0; j < weights[i].Length; j++)
                {
                    outputString = outputString + weights[i][j] + ",";
                }
                outputString = outputString + ";";
            }

            sw.WriteLine(outputString);
            sw.Close();
            tmrTurns.Stop();
            lblAITiers.Text = "Ended";
            */
        }

        private void btnPlayAI_Click(object sender, EventArgs e)
        {
            Form2 playerGame = new Form2();
            playerGame.Visible = true;
        }

    }
}
