using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string userName = "", userContinue = "";
            bool check, runAgain = true;

            Console.Write("What should I call you? ");
            userName = Console.ReadLine();
           
            while (runAgain)
            {
                Console.Clear();
                Console.WriteLine($"Hey, {userName}! Let me explain a little bit about this program.\n" +
               "This program accepts an integer between 1-100 and\n" +
               "displays an associated result based on the integer range entered.\n");

                check = false;
                while (!check)
                {
                    Console.Write($"{userName}, please enter an integer between 1-100: ");                    
                    if (!(check = int.TryParse(Console.ReadLine(), out num)) || num < 1 || num > 100)
                    {
                        Console.WriteLine($"Sorry {userName}, but there was a problem with your input.");
                        check = false;
                    }
                }

                if (num % 2 == 1)
                {
                    Console.WriteLine($"Output: {num} and odd.");
                }
                else if (num < 25)
                {
                    Console.WriteLine("Output: Even and less than 25.");
                }
                else if (num <= 60)
                {
                    Console.WriteLine("Output: Even.");
                }
                else
                {
                    Console.WriteLine($"Output: {num} and even.");
                }

                Console.Write("Continue? (y/n)");
                userContinue = Console.ReadLine().ToUpper();
                if(userContinue[0] == 'Y')
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }

            }
            Console.WriteLine($"\nThanks for using this program, {userName}.");
            Console.WriteLine("Goodbye!\n");
            
        }
    }
}
