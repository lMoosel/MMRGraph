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
        public string turnString = "";
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
            /*
            for (int i = 0; i < 5; i++)
            {
                p1Values[i] = gen.Next(2);
            }
            for (int i = 0; i < 5; i++)
            {
                p2Values[i] = gen.Next(2);
            }
            */
            p1Values = new int[5] {1,1,1,1,1};
            p2Values = new int[5] { 1, 1, 1, 1, 1};
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
            bool p1Turn = true;
            int p1attacker = 0, p2attacker = 0;
            int p1roundscore = 0, p2roundscore = 0;
            int target;

            turnString = "";
            

            turns++;

            for(int i = 0; i < 5; i++)
            {
                target = gen.Next(0, 5);
                if (gen.Next(0, 2) == 1)
                {
                    p1Turn = !p1Turn;
                }
                

                if (p1Turn)
                {
                    if (p1Values[p1attacker] > p2Values[target])
                    {
                        p1roundscore++;
                    }
                    p1attacker++;
                }
                else
                {
                    if (p2Values[p2attacker] > p1Values[target])
                    {
                        p2roundscore++;
                    }
                    p2attacker++;
                }

                if (p1Turn) //Records the actions of the turn; First number is player that started, 2nd is p1 involved index, 3rd is p2 involved index
                {
                    turnString = turnString + "1" + (p1attacker-1).ToString() + target.ToString()+",";
                }
                else
                {
                    turnString = turnString + "2" + target.ToString() + (p2attacker-1).ToString()+",";
                }
            }


            if (p1roundscore > p2roundscore)
            {
                p1score++;
                return 1;
            }
            else if (p2roundscore > p1roundscore)
            {
                p2score++;
                return 2;
            }
            else if (turns == 10)
            {
                return 3;
            }
            else
            {
                return 0;
            }

            
           
        } 

        
    }
}
