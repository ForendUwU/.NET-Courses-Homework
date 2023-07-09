using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDZ
{
    internal class GuessTheNumberGame
    {
        int number { get; set; }
        public int attempts { get; set; } = 5;
        public bool botGuessing { get; private set; } = false;

        public void StartGame() 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu\n 1. Start\n 2. Options\n 3. Exit");

                int menuChoice = 0;

                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    Console.Clear();
                    switch (menuChoice)
                    {
                        case 1:
                            Start();
                            break;
                        case 2:
                            while (true)
                            {
                                Console.WriteLine("Options\n 1. Who is guessing \n 2. Count of attempts");

                                int optionChoice = 0;

                                if (int.TryParse(Console.ReadLine(), out optionChoice))
                                {
                                    Console.Clear();
                                    switch (optionChoice)
                                    {
                                        case 1:
                                            while (true)
                                            {
                                                if (botGuessing)
                                                {
                                                    Console.WriteLine("You or bot? Now: Bot\n 1. Me\n 2. Bot");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("You or bot? Now: You\n 1. Me\n 2. Bot");
                                                }

                                                int whoIsGussingCoice = 0;
                                                if (int.TryParse(Console.ReadLine(), out whoIsGussingCoice))
                                                {
                                                    Console.Clear();
                                                    switch (whoIsGussingCoice)
                                                    {
                                                        case 1:
                                                            this.botGuessing = false;
                                                            break;
                                                        case 2:
                                                            this.botGuessing = true;
                                                            break;
                                                    }
                                                }
                                                else { Console.WriteLine("Wrong option"); }
                                                break;
                                            }
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Console.WriteLine("Enter the count of attempts. Current count is " + this.attempts);
                                            int countAttempts = 0;
                                            if (int.TryParse(Console.ReadLine(), out countAttempts))
                                            {
                                                this.attempts = countAttempts;
                                            }
                                            else { Console.WriteLine("Attempts can only be a number"); Console.ReadLine(); }
                                            break;
                                    }
                                }
                                else { Console.WriteLine("Wrong option"); }
                                break;
                            }
                            break;
                        case 3:
                            return;
                    }
                }
                else { Console.WriteLine("Wrong option"); }
            }
        }
        
        public void Start() 
        {
            if (botGuessing)
            {
                while (true)
                {
                    Console.WriteLine("Made a number");
                    int playerNum = 0;
                    
                    if (int.TryParse(Console.ReadLine(), out playerNum))
                    {
                        this.number = playerNum;
                        int tempAtt = this.attempts;

                        int min = 0;
                        int max = 100;

                        while (tempAtt > 0)
                        {
                            int guessNum = (min + max) / 2;
                            Console.WriteLine("\nI think it's " + guessNum + "\n\n 1. Bigger\n 2. Lower\n 3. Correct");
                            int botHint = 0;
                            if (int.TryParse(Console.ReadLine(), out botHint))
                            {
                                switch (botHint)
                                {
                                    case 1:
                                        tempAtt--;
                                        Console.WriteLine("My attempts " + tempAtt);
                                        min = guessNum;
                                        break;
                                    case 2:
                                        tempAtt--;
                                        Console.WriteLine("My attempts " + tempAtt);
                                        max = guessNum;
                                        break;
                                    case 3:
                                        Console.WriteLine("Yay, I'm clever bot!");
                                        Console.ReadLine();
                                        StartGame();
                                        break;
                                }
                            }
                            else { Console.WriteLine("Wrong option"); }
                            
                        }

                        Console.WriteLine("I didn't guessed((((");
                        Console.ReadLine();
                        StartGame();
                    }
                    else { Console.WriteLine("It's not a number"); }
                }
            }
            else
            {
                Random rand = new Random();
                Console.WriteLine("Bot made a number. Try to guess it! But you have only: " + this.attempts + " attempts");
                this.number = rand.Next(0, 101);
                int tempAtt = this.attempts;

                while (tempAtt > 0)
                {
                    int playerNum = 0;
                    if (int.TryParse(Console.ReadLine(), out playerNum))
                    {
                        if (playerNum > this.number)
                        {
                            tempAtt--;
                            Console.WriteLine("Number is lower\n Your attempts: " + tempAtt);
                        }
                        else if (playerNum < this.number)
                        {
                            tempAtt--;
                            Console.WriteLine("Number is bigger\n Your attempts: " + tempAtt); 
                        }
                        else
                        {
                            Console.WriteLine("YOU WIN!!!");
                            Console.ReadLine();
                            StartGame();
                        }

                    } else { Console.WriteLine("Not a number"); }
                }

                Console.WriteLine("Tou lose(((. The number was " + this.number);
                Console.ReadLine();
            }
        }

    }
}
