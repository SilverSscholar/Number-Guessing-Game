using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();

            var winno = ran.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number between 0, and 100");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if(i>winno)
                {
                    Console.WriteLine("Your answer was too high! Please guess lower...");
                }
                else if(i<winno)
                {
                    Console.WriteLine("Your answer was to low, please guess higher...");
                }

                else if(i==winno)
                {
                    Console.WriteLine("Congragulations you guessed the correct answer!");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}
