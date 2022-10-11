using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {

                Console.WriteLine("Good luck!");

                // Player turn

                string player = (Console.ReadLine());

                // AI turn
                int min = 1;
                int max = 3;

                Random random = new Random();
                int AIChoice = random.Next(min, max);

                // AI logic
                if (AIChoice == 1)
                {
                    Console.WriteLine("AI: Rock");
                }
                else if (AIChoice == 2)
                {
                    Console.WriteLine("AI: Paper");
                }
                else if (AIChoice == 3)
                {
                    Console.WriteLine("AI: Scissors");
                }


                // All scenarios
            
                if (player == "Rock" && AIChoice == 2)
                {
                    Console.WriteLine("Ai Wins!");
                }
                else if (player == "Rock" && AIChoice == 3)
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (player == "Rock" && AIChoice == 1)
                {
                        Console.WriteLine("Tie!");
                }
                else if (player == "Paper" && AIChoice == 2)
                {
                    Console.WriteLine("Tie!");
                }
                else if (player == "Paper" && AIChoice == 3)
                {
                    Console.WriteLine("Ai Wins!");
                }
                else if (player == "Paper" && AIChoice == 1)
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (player == "Scissors" && AIChoice == 2)
                {
                    Console.WriteLine("Player Wins");
                }
                else if (player == "Scissors" && AIChoice == 3)
                {
                    Console.WriteLine("Tie!");
                }
                else if (player == "Scissors" && AIChoice == 1)
                {
                        Console.WriteLine("Ai Wins!");
                }
                else if (player == "Stop")
                {
                    break;
                }
                else if (player != "Rock" || player != "Paper" || player != "Scissors")
                {
                    Console.WriteLine("Invalid choice");
                }

                Console.WriteLine("Press ENTER to restart!");
                Console.ReadLine();

            }
        }
    }
}
