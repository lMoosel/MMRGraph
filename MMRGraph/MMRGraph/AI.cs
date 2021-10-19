using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRGraph
{
    class AI
    {
        double[][] weights = new double[5][];
        int[] myValues;
        int[] opponentValues;
        Random gen = new Random();
        int player = 0;
        bool hasGame;
        int MMR = 100;
        public AI(Random gen)
        {
            MMR = gen.Next(300, 300);
            for (int i = 0; i < 5; i++) {
                weights[i] = new double[6];
                for (int j = 0; j < 6; j++)
                {
                    weights[i][j] = gen.NextDouble()*20;
                }
            }
        }
        public AI(double[][] externalWeights)
        {
            weights = externalWeights;
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
            if (val < 0)
            {
                updateWeights();
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
                myValues = p1Values;
                opponentValues = p2Values;
            }
            else
            {
                myValues = p2Values;
                opponentValues = p1Values;
            }
        }

        public int spendPoints()
        {
            // Array weights key: 0 - red, 1 - blue, 2 - green, 3 - yellow, 4 - purple
            double redTotal, blueTotal, greenTotal, yellowTotal, purpleTotal;
            double maxValue;

            redTotal = Math.Abs(myValues[0] - opponentValues[0]+1) * weights[0][0] * weights[0][5] + Math.Abs(myValues[0] - opponentValues[1]+1) * weights[0][1] * weights[0][5] + Math.Abs(myValues[0] - opponentValues[2]+1) * weights[0][2] * weights[0][5] + Math.Abs(myValues[0] - opponentValues[3]+1) * weights[0][3] * weights[0][5] + Math.Abs(myValues[0] - opponentValues[4]+1) * weights[0][4] * weights[0][5];
            blueTotal = Math.Abs(myValues[1] - opponentValues[0]+1) * weights[1][0] * weights[1][5] + Math.Abs(myValues[1] - opponentValues[1]+1) * weights[1][1] * weights[1][5] + Math.Abs(myValues[1] - opponentValues[2]+1) * weights[1][2] * weights[1][5] + Math.Abs(myValues[1] - opponentValues[3]+1) * weights[1][3] * weights[1][5] + Math.Abs(myValues[1] - opponentValues[4]+1) * weights[1][4] * weights[1][5];
            greenTotal = Math.Abs(myValues[2] - opponentValues[0]+1) * weights[2][0] * weights[2][5] + Math.Abs(myValues[2] - opponentValues[1]+1) * weights[2][1] * weights[2][5] + Math.Abs(myValues[2] - opponentValues[2]+1) * weights[2][2] * weights[2][5] + Math.Abs(myValues[2] - opponentValues[3]+1) * weights[2][3] * weights[2][5] + Math.Abs(myValues[2] - opponentValues[4]+1) * weights[2][4] * weights[2][5];
            yellowTotal = Math.Abs(myValues[3] - opponentValues[0]+1) * weights[3][0] * weights[3][5] + Math.Abs(myValues[3] - opponentValues[1]+1) * weights[3][1] * weights[3][5] + Math.Abs(myValues[3] - opponentValues[2]+1) * weights[3][2] * weights[3][5] + Math.Abs(myValues[3] - opponentValues[3]+1) * weights[3][3] * weights[3][5] + Math.Abs(myValues[3] - opponentValues[4]+1) * weights[3][4] * weights[3][5];
            purpleTotal = Math.Abs(myValues[4] - opponentValues[0]+1) * weights[4][0] * weights[4][5] + Math.Abs(myValues[4] - opponentValues[0]+1) * weights[4][1] * weights[4][5] + Math.Abs(myValues[4] - opponentValues[2]+1) * weights[4][2] * weights[4][5] + Math.Abs(myValues[4] - opponentValues[3]+1) * weights[4][3] * weights[4][5] + Math.Abs(myValues[4] - opponentValues[4]+1) * weights[4][4] * weights[4][5];

            maxValue = Math.Max(redTotal, Math.Max(blueTotal, Math.Max(greenTotal, Math.Max(yellowTotal, purpleTotal))));
            
            if (maxValue == redTotal)
            {
                return 0;
            }
            else if (maxValue == blueTotal)
            {
                return 1;
            }
            else if (maxValue == greenTotal)
            {
                return 2;
            }
            else if (maxValue == yellowTotal)
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
            
                for (int x = 0; x < weights.Length; x++)
                {
                    for (int y = 0; y < weights[x].Length; y++)
                    {
                        weights[x][y] += gen.NextDouble() * 10 - 5;
                    }
                }
            
        }

        public double[][] getWeights()
        {
            return weights;
        }

        
    }
}
