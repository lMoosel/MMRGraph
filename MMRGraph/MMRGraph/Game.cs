using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMRGraph
{
    
    class Game
    {
        Random gen = new Random();
        int[] p1Values = new int[5];
        int[] p2Values = new int[5];
        int p1score, p2score;
        public int player1ID, player2ID;
        int turns;
        bool gameActive;
        public Game(int p1, int p2)
        {
            player1ID = p1;
            player2ID = p2;
            resetValues();
        }

        private void resetValues() //Testing function
        {
            for (int i = 0; i < 5; i++)
            {
                p1Values[i] = gen.Next(2);
            }
            for (int i = 0; i < 5; i++)
            {
                p2Values[i] = gen.Next(2);
            }
        }
        public int[][] getPlayerValues()
        {
            int[][] returnValue = { p1Values, p2Values };
            return returnValue;
        }

        public void Activate()
        {
            gameActive = true;
        }
        public void Deactivate()
        {
            gameActive = false;
        }
        public bool isActive()
        {
            return gameActive;
        }
        public int getPlayerScores(int playerID)
        {
            if (playerID == 1)
            {
                return p1score;
            }
            else
            {
                return p2score;
            }
        }
        public void increaseValues(int player, int value)
        {
            if (player == 1)
            {
                p1Values[value] += 1;
            }
            else
            {
                p2Values[value] += 1;
            }
            
        }

        public int playRound()
        {
            int p1RoundScore = 0, p2RoundScore = 0;
            int winningPlayer;

            for(int i = 0; i<p1Values.Length; i++)
            {
               if(p1Values[i] > p2Values[i])
                {
                    p1RoundScore++;
                }
               else if (p1Values[i] < p2Values[i])
                {
                    p2RoundScore++;
                }

                if (p1Values[i] > p2Values[(i+2)%5]*2)
                {
                    p1RoundScore++;
                }
                else if (p1Values[i] < p2Values[(i + 2) % 5]*2)
                {
                    p2RoundScore++;
                }

                if (p1Values[i]*2 > p2Values[(i + 3) % 5])
                {
                    p1RoundScore++;
                }
                else if (p1Values[i]*2 < p2Values[(i + 3) % 5])
                {
                    p2RoundScore++;
                }
            }

            if (p1RoundScore > p2RoundScore)
            {
                p1score++;
                winningPlayer = 1;
            }
            else if (p2RoundScore > p1RoundScore)
            {
                p2score++;
                winningPlayer = 2;
            }
            else
            {
                winningPlayer = 0;
            }

            if(turns >= 25)
            {
                winningPlayer = 3;
            }

            turns += 1;
            return winningPlayer;
        } 

        
    }
}
