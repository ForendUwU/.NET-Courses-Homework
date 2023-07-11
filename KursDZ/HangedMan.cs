using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDZ
{
    internal class HangedMan
    {
        public string word { get; set; }
        public HangedMan(string word)
        {
            this.word = word;
        }

        public void Start() 
        {
            char[] fullWord = word.ToArray();
            char[] solvedWord = new char[fullWord.Length];

            Console.WriteLine("Your word is:");
            for (int i = 0; i < solvedWord.Length; i++)
            {
                Console.Write("_");
                solvedWord[i] = '_';
            }
            Console.Write($"\nTry to guess the letter{word}\n");

            for (int i = 6; i >= 0; i--)
            {
                Console.WriteLine($"You have {i} attempts");

                char letter = Console.ReadLine().ToCharArray()[0];

                for (int j = 0; j < solvedWord.Length; j++)
                {
                    if (fullWord[j] == letter)
                    {
                        solvedWord[j] = letter;
                    }

                    Console.Write(solvedWord[j]); 
                }

                Console.WriteLine();

                int counter = solvedWord.Length;
                for (int j = 0; j < solvedWord.Length; j++)
                {
                    if (solvedWord[j] == fullWord[j])
                    {
                        counter--;
                    }
                }

                if (counter == 0)
                {
                    Console.WriteLine("You win");
                }

            }
        }

        
    }
}
