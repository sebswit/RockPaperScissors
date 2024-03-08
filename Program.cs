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
            String answer;


            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                switch(random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;


                }

                Console.WriteLine("Player: "+player);
                Console.WriteLine("Computer: "+computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You win");
                        }
                        else
                        {
                            Console.WriteLine("You Loose");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You win");
                        }
                        else
                        {
                            Console.WriteLine("You Loose");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("Draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win");
                        }
                        else
                        {
                            Console.WriteLine("You Loose");
                        }
                        break;
                }

                Console.WriteLine("Play again (Y/N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                 if (answer == "Y")
                {
                    playAgain = true;
                }
                 else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing");


            Console.ReadKey();
        }
    }
}