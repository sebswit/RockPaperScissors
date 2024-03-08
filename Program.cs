using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            while (playAgain)
            {
                Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();

                Console.WriteLine(player);


            }




            Console.ReadKey();
        }
    }
}