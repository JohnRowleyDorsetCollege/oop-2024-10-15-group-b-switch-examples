using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_15_group_b_switch_examples.models
{

    // static - means I do not have to create an instance
    public static class Driver
    {
        // error - you cannot declare instances within a static class
        // resolve by using a constant

        public static void Run()
        {
            // $ means interpolate the variables within a string which are inside {}
            Console.WriteLine($"{AppConstants.APP_NAME}"); // makes sure constants is public with public constants
        }

        public static void SwitchStatementDemo()
        {
            // $ means interpolate the variables within a string which are inside {}
            Console.WriteLine($"SwitchStatementDemo"); // makes sure constants is public with public constants

            int number = 2;
            // switch statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("Switch: One");
                    break;
                case 2:
                    Console.WriteLine("Switch: Two");
                    break;

                case 3:
                    Console.WriteLine("Switch: Three");
                    break;

                case 4:
                    Console.WriteLine("Switch: Four");
                    break;

                default:
                    Console.WriteLine($"{number} Not handled");
                    break;
            }

            // NOt a very efficient way
            // once you see lots of if statements you should consider a switch statement
            //if (number == 1) Console.WriteLine("One");
            //if (number == 2) Console.WriteLine("Two");
            //if (number == 3) Console.WriteLine("Three");
            //if (number == 4) Console.WriteLine("Four");

        }

        public static void SwitchExpressionDemo()
        {
            Console.WriteLine("Switch Expression Demo");

            int number = 5;

            string result = number switch
            {

                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                _ => "Not a valid number"

            }; // unlike switch statement, expression needs a ; at end

            Console.WriteLine($"Switch Expression Result: {result}");
        }
    }
}
