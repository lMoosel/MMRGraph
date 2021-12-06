using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRGraph
{
    class AI
    {
        //double[][] weights = new double[5][];
        double[] layer1weights = new double[80];
        double[] layer2weights = new double[40];
        int[] gameValues = new int[10];
        Random gen;
        int player = 0;
        bool hasGame;
        int MMR = 100;
        int gamesUp = 1;
        public AI(Random tempGen)
        {
            gen = tempGen;
            MMR = gen.Next(550, 750);
            /*
            for (int i = 0; i < 5; i++) {
                weights[i] = new double[6];
                for (int j = 0; j < 6; j++)
                {
                    weights[i][j] = gen.NextDouble()*2;
                }
            }
            */
            for (int i = 0; i < layer1weights.Length; i++)
            {
                layer1weights[i] += (gen.NextDouble()-.5) * 50;
            }
            for (int j = 0; j < layer2weights.Length; j++)
            {
                layer2weights[j] += (gen.NextDouble()-.5) * 50;
            }

        }
        public AI(double[] externalWeights1, double[] externalWeights2)
        {
            //weights = externalWeights;
            gen = new Random();
            layer1weights = externalWeights1;
            layer2weights = externalWeights2;
            player = 2;
        }

        public string getTeir()
        {
            if (MMR > 700)
            {
                return "Grandmaster";
            }
            else if (MMR > 600)
            {
                return "Master";
            }
            else if (MMR > 500)
            {
                return "Diamond";
            }
            else if (MMR > 400)
            {
                return "Platinum";
            }
            else if (MMR > 300)
            {
                return "Gold";
            }
            else if (MMR > 200)
            {
                return "Silver";
            }
            else
            {
                return "Bronze";
            }
        }


        public void changeMMR(double val)
        {
            MMR += Convert.ToInt32(val);
            if (val <= 0)
            {
                updateWeights();
                if (gamesUp > 1) { gamesUp--; }
                
            }
            else
            {
                gamesUp++;
            }
        }
        public int getMMR()
        {
            return MMR;
        }
        public void setPlayerNumber(int num)
        {
            player = num;
        }
        public int getPlayerNumber()
        {
            return player;
        }
        public void setHasGame(bool value)
        {
            hasGame = value;

        }
        public bool getHasGame()
        {
            return hasGame;
        }
        public void setPlayerValues(int[] p1Values, int[] p2Values)
        {
            if(player == 1)
            {
                p1Values.CopyTo(gameValues, 0);
                p2Values.CopyTo(gameValues, 5);
            }
            else
            {
                p2Values.CopyTo(gameValues, 5);
                p1Values.CopyTo(gameValues, 0);
            }
        }

        public int spendPoints()
        {

            
            double[] hiddenLayer = new double[8];
            double[] outputLayer = new double[5];
            double maxValue;

            for (int i = 0; i < 8; i++)
            {
                hiddenLayer[i] = 0;
                for(int j = 0; j < 10; j++)
                {
                    hiddenLayer[i] += gameValues[j] * layer1weights[i * 10 + j];
                }
            }

            for (int i = 0; i<5; i++)
            {
                outputLayer[i] = 0;
                for (int j = 0; j<8; j++)
                {
                    outputLayer[i] += hiddenLayer[j] * layer2weights[i * 8 + j]; 
                }
            }

            maxValue = outputLayer.Max();
            
            // Array weights key: 0 - red, 1 - blue, 2 - green, 3 - yellow, 4 - purple
            //double redTotal, blueTotal, greenTotal, yellowTotal, purpleTotal;
            
            /*
            redTotal = Math.Abs(myValues[0] - opponentValues[0]+1) * weights[0][0] * weights[0][5] + Math.Abs(myValues[0] - opponentValues[1]+1) * weights[0][1] * weights[0][5] + Math.Abs(myValues[0] - opponentValues[2]+1) * weights[0][2] * weights[0][5] + Math.Abs(myValues[0] - opponentValues[3]+1) * weights[0][3] * weights[0][5] + Math.Abs(myValues[0] - opponentValues[4]+1) * weights[0][4] * weights[0][5];
            blueTotal = Math.Abs(myValues[1] - opponentValues[0]+1) * weights[1][0] * weights[1][5] + Math.Abs(myValues[1] - opponentValues[1]+1) * weights[1][1] * weights[1][5] + Math.Abs(myValues[1] - opponentValues[2]+1) * weights[1][2] * weights[1][5] + Math.Abs(myValues[1] - opponentValues[3]+1) * weights[1][3] * weights[1][5] + Math.Abs(myValues[1] - opponentValues[4]+1) * weights[1][4] * weights[1][5];
            greenTotal = Math.Abs(myValues[2] - opponentValues[0]+1) * weights[2][0] * weights[2][5] + Math.Abs(myValues[2] - opponentValues[1]+1) * weights[2][1] * weights[2][5] + Math.Abs(myValues[2] - opponentValues[2]+1) * weights[2][2] * weights[2][5] + Math.Abs(myValues[2] - opponentValues[3]+1) * weights[2][3] * weights[2][5] + Math.Abs(myValues[2] - opponentValues[4]+1) * weights[2][4] * weights[2][5];
            yellowTotal = Math.Abs(myValues[3] - opponentValues[0]+1) * weights[3][0] * weights[3][5] + Math.Abs(myValues[3] - opponentValues[1]+1) * weights[3][1] * weights[3][5] + Math.Abs(myValues[3] - opponentValues[2]+1) * weights[3][2] * weights[3][5] + Math.Abs(myValues[3] - opponentValues[3]+1) * weights[3][3] * weights[3][5] + Math.Abs(myValues[3] - opponentValues[4]+1) * weights[3][4] * weights[3][5];
            purpleTotal = Math.Abs(myValues[4] - opponentValues[0]+1) * weights[4][0] * weights[4][5] + Math.Abs(myValues[4] - opponentValues[0]+1) * weights[4][1] * weights[4][5] + Math.Abs(myValues[4] - opponentValues[2]+1) * weights[4][2] * weights[4][5] + Math.Abs(myValues[4] - opponentValues[3]+1) * weights[4][3] * weights[4][5] + Math.Abs(myValues[4] - opponentValues[4]+1) * weights[4][4] * weights[4][5];
            
            maxValue = Math.Max(redTotal, Math.Max(blueTotal, Math.Max(greenTotal, Math.Max(yellowTotal, purpleTotal))));
            */

            if (maxValue == outputLayer[0])
            {
                return 0;
            }
            else if (maxValue == outputLayer[1])
            {
                return 1;
            }
            else if (maxValue == outputLayer[2])
            {
                return 2;
            }
            else if (maxValue == outputLayer[3])
            {
                return 3;
            }
            else
            {
                return 4;
            }
            

            
        }

        public void updateWeights()
        {
            for(int i =0; i < layer1weights.Length; i++)
            {
                layer1weights[i] += (gen.NextDouble() - .5)*(10/gamesUp);
            }
            for (int j = 0; j < layer2weights.Length; j++)
            {
                layer2weights[j] += (gen.NextDouble() - .5)* (10 / gamesUp);
            }
            /*
                for (int x = 0; x < weights.Length; x++)
                {
                    for (int y = 0; y < weights[x].Length; y++)
                    {
                        weights[x][y] += gen.NextDouble() - 0.5;
                    }
                }
            */
        }

        public double[] getWeights()
        {
            double[] weights = new double[120];
            layer1weights.CopyTo(weights, 0);
            layer2weights.CopyTo(weights, 80);
            return weights;
        }

        
    }
}
