using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class Stringbuilders
    {
        static void Main()
        {
            Console.WriteLine("----------------------------------");
            // Task 1: Initialize and Append

            StringBuilder SB = new StringBuilder();

            SB.Append("My dream destination");
            SB.Append(" is Kashmir,");
            SB.Append("especially Gulmarg.");

            Console.WriteLine(SB.ToString());

            // Task 2: Replace a substring

            SB.Replace("Kashmir", "Paradise on Earth");
            SB.Replace("Gulmarg", "Pahalgam");

            Console.WriteLine(SB.ToString());

            // Task 3: Remove  a portion

            SB.Remove(21, 22);

            Console.WriteLine(SB.ToString());








            // Assignment 2  find maximum and minimum:

            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Find maximum and minimum ");
                int[] numbers = { 50, 30, 80, 10, 40 };
                int max = numbers[0];
                int min = numbers[0];

                foreach (int num in numbers)
                {
                    if (num > max) max = num;
                    if (num < min) min = num;
                }

                Console.WriteLine("Maximum Value : " + max);
                Console.WriteLine("Minimum Value :" + min);

            }



            // Assignment 3 
            {
                Console.WriteLine("----------------------------------");
                String[] Names = { "Alice", "Bob", "Charlie", "David", "Emily" };
                Console.WriteLine("Names in the list : Alice,Bob,Charlie,David,Emily");

                int names = 5;
                switch (names)

                {

                    case 1:
                        Console.WriteLine("Alice");
                        break;
                    case 2:
                        Console.WriteLine("Bob");
                        break;
                    case 3:
                        Console.WriteLine("Charlie");
                        break;
                    case 4:
                        Console.WriteLine("David");
                        break;
                    case 5:
                        Console.WriteLine("Emily");
                        break;
                    default:
                        Console.WriteLine("Eva");
                        break;




                }









            }
        }
    }



    
}
