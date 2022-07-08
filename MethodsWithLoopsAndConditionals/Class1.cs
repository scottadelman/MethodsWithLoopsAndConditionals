using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithLoopsAndConditionals
{
    internal class Class1
    {
        public static void Method1()
        {
            for (int i = -1000; i >= -999 && i <= 1000; i++)
            {
                Console.WriteLine($"{i}");
            }

            int x = 1000;
            while (x >= -1000)
            {
                Console.WriteLine(x);
                x--;
            }

        }
        public static void Method2()
        {
            for (int i = 0; i <= 999; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Method3() //guess my favorite color
        {
            Console.WriteLine("Guess my favorite color");
            string myFavColor = "purple";
            bool didYouGuessIt;

            while (didYouGuessIt = true)
            {
                if (Console.ReadLine() != myFavColor)
                {
                    Console.WriteLine("Nope, guess again");
                    didYouGuessIt = false;
                }
                else
                {
                    Console.WriteLine("You got it!");
                    break;
                }
            }
        }
        public static void Method4()
        {
            Console.WriteLine("Let's check if your number is even!");
            bool isItEven;

            while(isItEven = true || false)
            {
                int x = int.Parse(Console.ReadLine());
                
                if (x % 2 == 0)
                {
                    Console.WriteLine("This is an even number!");
                }
                else
                {
                    Console.WriteLine("This is an odd number!");
                }
            }

        }
    }
}
