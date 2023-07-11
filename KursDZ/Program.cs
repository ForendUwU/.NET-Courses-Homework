using System.Threading.Channels;

namespace KursDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allWords = File.ReadAllLines("Dictionary/Dictionary.txt");
            Random rand = new Random();

            HangedMan game = new HangedMan(allWords[rand.Next(0, 11650)]);
            game.Start();

            Console.ReadLine();

        }

        static void TicTacToe()
        {
            TicTacToe game = new TicTacToe();
            game.Start();
        }
        static void GuessTheNumberGame()
        {
            GuessTheNumberGame game = new GuessTheNumberGame();
            game.StartGame();
        }
        static void complexDZ() 
        {
            Complex c1 = new Complex(1, 1);
            Complex c2 = new Complex(1, 2);

            Complex result = c1.Plus(c2);
            Console.WriteLine(result.realNum + " " + result.imaginaryNum);

            result = c1.Minus(c2);
            Console.WriteLine(result.realNum + " " + result.imaginaryNum);

            Console.ReadLine();
        }
    }
}