using System;

namespace waterGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Snake WATER GAME");
            char c = '\0';
            var rand = new Random();
            var str = "swg";
            var randIndex = rand.Next(str.Length);
            c = str[randIndex];

            Console.Write("Enter the char line s/w/g to play with computer :");
            string input = Console.ReadLine();

            // Validate input to avoid null reference issues
            if (input != null && input.Length > 0)
            {
                char your = input[0];

                Console.WriteLine($"You chose {your} and computer chose {c} to play together");

                if (your == 's' && c == 's')
                {
                    Console.WriteLine("Match draw");
                }
                else if (your == 'w' && c == 'w')
                {
                    Console.WriteLine("Match draw");
                }
                else if (your == 'g' && c == 'g')
                {
                    Console.WriteLine("Match draw");
                }
                else if (your == 's' && c == 'w')
                {
                    Console.WriteLine("Snake wins");
                }
                else if (your == 's' && c == 'g')
                {
                    Console.WriteLine("Gun wins!");
                }
                else if (your == 'w' && c == 'g')
                {
                    Console.WriteLine("Gun wins!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid character (s/w/g).");
            }
        }
    }
}
