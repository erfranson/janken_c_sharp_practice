using System;

namespace jajanken
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GameLogic();
        }

        public static string StartGame()
        {
            string isPlaying;

            Console.WriteLine("Would you like to play Rock Paper Scissors? YES or NO");

            isPlaying = Console.ReadLine().ToUpper();

            return isPlaying;

        }

        public static int RandomNumber()
        {
            Random rnd = new Random();

            int comp = rnd.Next(1, 4);

            return comp;
        }
        public static void GameLogic()
        {
            
            var playing = true;
            
            while(playing)
            {
                String isPlaying = StartGame();

                int player;
                string playerChoice = null;


                int comp = RandomNumber();


                string compChoice = null;

                if(comp == 1)
                {
                    compChoice = "rock";
                }
                else if (comp == 2)
                {
                    compChoice = "scissors";
                }
                else if(comp == 3)
                {
                    compChoice = "paper";
                }
                

                if(isPlaying == "YES" )
                {
                    Console.WriteLine("What would you like to choose");
                    Console.WriteLine("1) for rock");
                    Console.WriteLine("2) for scissors");
                    Console.WriteLine("3) for paper");
                    Console.WriteLine("4) to Exit");

                    player = Convert.ToInt32(Console.ReadLine());

                    if (player == 1)
                    {
                        playerChoice = "rock";
                    }
                    else if (player == 2)
                    {
                        playerChoice = "scissors";
                    }
                    else if (player == 3)
                    {
                        playerChoice = "paper";
                    }
                    else if(player == 4)
                    {
                        playerChoice = "Exit";
                    }

                    if(playerChoice == compChoice)
                    {
                        Console.WriteLine("Computer chose: {0}", compChoice);
                        Console.WriteLine(@"It's a tie");
                    }
                    else if(playerChoice == "rock")
                    {
                        if(compChoice == "scissors")
                        {
                            Console.WriteLine("Computer chose: {0}", compChoice);
                            Console.WriteLine("You Win!");
                        }
                        else if(compChoice == "paper")
                        {
                            Console.WriteLine("Computer chose: {0}", compChoice);
                            Console.WriteLine("You lose");
                        }
                    }
                    else if(playerChoice == "scissors")
                    {
                        if(compChoice == "paper")
                        {
                            Console.WriteLine("Computer chose: {0}", compChoice);
                            Console.WriteLine("You Win!");
                        }
                        else if(compChoice == "rock")
                        {
                            Console.WriteLine("Computer chose: {0}", compChoice);
                            Console.WriteLine("You lose");
                        }
                    }
                    else if(playerChoice == "paper")
                    {
                        if(compChoice == "rock")
                        {
                            Console.WriteLine("Computer chose: {0}", compChoice);
                            Console.WriteLine("You Win!");
                        }
                        else if(compChoice == "scissors")
                        {
                            Console.WriteLine("Computer chose: {0}", compChoice);
                            Console.WriteLine("You lose");
                        }
                    }
                    else if(playerChoice == "Exit")
                    {
                        Console.WriteLine("Thanks for playing");
                        playing = false;
                    }
                }
                else if(isPlaying == "NO")
                {
                    playing = false;
                }

            }
            
        }
    }
}
