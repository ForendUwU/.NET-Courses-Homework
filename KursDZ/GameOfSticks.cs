using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDZ
{
    internal class GameOfSticks
    {
        public int Sticks { get; set; } = 10;
        private bool botTurn = false;

        public void Start() 
        {
            while (Sticks >= 0)
            {
                Console.WriteLine($"Amount of sticks = {Sticks}"); ;
                if (!botTurn)
                {
                    Console.WriteLine("Choose amount of sticks between 1 and 3");
                    int chosenSticks = int.Parse(Console.ReadLine());
                    if (winCheck(chosenSticks))
                    {
                        return;
                    } 
                    botTurn = true;
                }
                else
                {
                    Random rand = new Random();
                    int botChose = rand.Next(1, 3);
                    Console.WriteLine($"I chose {botChose} sticks\n");
                    if (winCheck(botChose))
                    {
                        return;
                    }
                    botTurn = false;
                }
            }
        }

        public bool winCheck(int chosenSticks) 
        {
            Sticks -= chosenSticks;
            if (!botTurn && Sticks <= 0)
            {
                Console.WriteLine("Bot win");
                return true;
            }
            else if (botTurn && Sticks <= 0) 
            {
                Console.WriteLine("You win");
                return true;
            }
            return false;
        }
    }
}
