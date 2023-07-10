using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDZ
{
    internal class TicTacToe
    {
        public int[,] field = new int[3, 3]; 
        public void Start() 
        {
            Console.WriteLine("First cross. Select from 0 to 8");
            bool isCircle = false;

            for (int k = 0; k < 9; k++)
            {
                int tempCounter = 0;
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                if (choice >= 0 && choice <= 8)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (tempCounter == choice)
                            {
                                if (isCircle && field[i, j] == 0)
                                {
                                    field[i, j] = 1;
                                    isCircle = false;
                                }
                                else if (field[i, j] == 0)
                                {
                                    field[i, j] = 2;
                                    isCircle = true;
                                }
                                else
                                {
                                    Console.WriteLine("Wrong place");
                                    k--;
                                }

                            }
                            tempCounter++;
                        }
                    }

                    DrawField();
                }
                else { Console.WriteLine("Wrong symbol"); k--; }

                WinCheck();
            }
        }

        public void DrawField() 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j < 2)
                    {
                        if (field[i, j] == 1)
                        {
                            Console.Write("O" + "|");
                        }
                        else if (field[i, j] == 2)
                        {
                            Console.Write("X" + "|");
                        }
                        else if (field[i, j] == 0)
                        {
                            Console.Write(" " + "|");
                        }
                    }
                    else
                    {
                        if (field[i, j] == 1)
                        {
                            Console.Write("O");
                        }
                        else if (field[i, j] == 2)
                        {
                            Console.Write("X");
                        }
                        else if (field[i, j] == 0)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                if (i < 2)
                {
                    Console.WriteLine("\n-----");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        public void WinCheck() 
        {
            if (field[0, 0] == 1 && field[1, 0] == 1 && field[2, 0] == 1)
            {
                Console.WriteLine("Circle win");
            }
            else if (field[0, 1] == 1 && field[1, 1] == 1 && field[2, 1] == 1)
            {
                Console.WriteLine("Circle win");
            }
            else if (field[0, 2] == 1 && field[1, 2] == 1 && field[2, 2] == 1)
            {
                Console.WriteLine("Circle win");
            }
            else if (field[0, 0] == 1 && field[0, 1] == 1 && field[0, 2] == 1)
            {
                Console.WriteLine("Circle win");
            }
            else if (field[1, 0] == 1 && field[1, 1] == 1 && field[1, 2] == 1)
            {
                Console.WriteLine("Circle win");
            }
            else if (field[2, 0] == 1 && field[2, 1] == 1 && field[2, 2] == 1)
            {
                Console.WriteLine("Circle win");
            }
            else if (field[0, 0] == 1 && field[1, 1] == 1 && field[2, 2] == 1)
            {
                Console.WriteLine("Circle win");
            }
            else if (field[0, 2] == 1 && field[1, 1] == 1 && field[2, 0] == 1)
            {
                Console.WriteLine("Circle win");
            }
            else if (field[0, 0] == 2 && field[1, 0] == 2 && field[2, 0] == 2)
            {
                Console.WriteLine("Cross win");
            }
            else if (field[0, 1] == 2 && field[1, 1] == 2 && field[2, 1] == 2)
            {
                Console.WriteLine("Cross win");
            }
            else if (field[0, 2] == 2 && field[1, 2] == 2 && field[2, 2] == 2)
            {
                Console.WriteLine("Cross win");
            }
            else if (field[0, 0] == 2 && field[0, 1] == 2 && field[0, 2] == 2)
            {
                Console.WriteLine("Cross win");
            }
            else if (field[1, 0] == 2 && field[1, 1] == 2 && field[1, 2] == 2)
            {
                Console.WriteLine("Cross win");
            }
            else if (field[2, 0] == 2 && field[2, 1] == 2 && field[2, 2] == 2)
            {
                Console.WriteLine("Cross win");
            }
            else if (field[0, 0] == 2 && field[1, 1] == 2 && field[2, 2] == 2)
            {
                Console.WriteLine("Cross win");
            }
            else if (field[0, 2] == 2 && field[1, 1] == 2 && field[2, 0] == 2)
            {
                Console.WriteLine("Cross win");
            }
        }
    }
}
