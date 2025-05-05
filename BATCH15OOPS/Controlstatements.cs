using System.Net;

namespace Batch15OOPS
{
    internal class Controlstatements

    {
        static void Main()
        {


            Console.WriteLine("----------Basic number Identify ---------");
            //  Console.WriteLine("Enter the number ");
            int c = 5; //Convert.ToInt32(Console.ReadLine());

            if (c > 0)
            {
                Console.WriteLine("The number is positive.");

            }

            else if (c < 0)
            {
                Console.WriteLine("The number is negative.");
            }

            else if (c == 0)
            {
                Console.WriteLine("The number is zero.");
            }


            //Grade calculate
            {

                Console.WriteLine("------Grade calculator-------");
                // Console.WriteLine("Enter your marks");
                int marks = 85; //Convert.ToInt32(Console.ReadLine());
                if (marks >= 95)
                {
                    Console.WriteLine("Excellent,congrats!!! You got a grade A+");
                }
                else if (marks >= 80 && marks < 95)
                {
                    Console.WriteLine("Very Good !! You got a grade A");
                }
                else if (marks >= 60 && marks < 80)
                {
                    Console.WriteLine("Good !  You got a grade B");
                }
                else if (marks >= 50 && marks < 60)
                {
                    Console.WriteLine("Above average ! You got a grade C");
                }
                else if (marks >= 40 && marks < 50)
                {
                    Console.WriteLine("Basic average ! You got a grade D");
                }
                else if (marks >= 40 && marks >= 0)
                {
                    Console.WriteLine("Yuppp!!! FFFail You got a grade E");
                }
                else
                {
                    Console.WriteLine("You Entered invalid marks");
                }

            }


            //Switch

            {

                Console.WriteLine("--------Magic Burger point Menu--------");
                Console.WriteLine("1. Cheese Burger - Rs 99.00");
                Console.WriteLine("2. Paneer Pizza - Rs 180.00");
                Console.WriteLine("3. Delicious Salad - Rs 69.00");
                Console.WriteLine("4. Satisfiy--Exist");

                int Menu = 2;
                switch (Menu)
                {
                    case 1:
                        Console.WriteLine("You choose Cheese Burger at Rs 99.00 ");
                        break;
                    case 2:
                        Console.WriteLine("You choose Paneer Pizza at RS 180.00 ");
                        break;
                    case 3:
                        Console.WriteLine("You choose Delicious Salad at Rs 69.00");
                        break;
                    case 4:
                        Console.WriteLine("Exist...Very Satisfy Thnkyuhhhh...Meet Agains");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.please choose Another Options");
                        break;



                }
            }
            //Loop Statement

            Console.WriteLine("Using For Loop");
            for (int s = 1; s < 10; s++)

            {
                Console.WriteLine($" Student {s} is checked ");
            }


            Console.WriteLine("Using While Loop");
            int p = 1;
            while (p <= 10)
            {
                Console.WriteLine($" Student {p} is checked ");
                p++;
            }

            Console.WriteLine("Using Do While Loop");
            int q = 1;
            do
            {
                Console.WriteLine($" Student {q} is checked ");
                q++;

            } while (q <= 10);



            //for Each loop



            {

                Console.WriteLine("------for each statement------");
                {


                    Console.WriteLine("--*** Display 10 mobile Brand list ***--");

                    String[] mobileBrands = { "Vivo", "Apple", "Realme", "Oppo", "Xiaomi", "Samsung", "Poco", "Oneplus", "Nokia", "Honor" };
                    foreach (String mobileBrand in mobileBrands)
                    {
                        Console.WriteLine("The Mobile Brand Name is: " + mobileBrand);
                    }

                }


            }

            //for break statement

            {

                Console.WriteLine("------for break statement------");

                int sum = 0;
                while (true)
                {
                    Console.WriteLine("Enter a number   :  ");

                    int number = Convert.ToInt32(Console.ReadLine());
                    {
                        if (number < 0)
                            break;
                    }

                    sum += number;

                }

                Console.WriteLine("Total Sum is : " + sum);



            }


            //for continue statement

            {
                Console.WriteLine("------for Continue Statement------");
                Console.WriteLine(" Enter a number: 20");
                for (int s = 1; s <= 20; s++)
                {
                    if (s % 3 == 0)
                    {
                        continue;
                    }

                    Console.WriteLine(s);
                }





            }


            //for Goto statement
            {
                Console.WriteLine("-----for Goto statement------");


                {
                        

                    int age;
                startloop:
                    Console.WriteLine("Enter a valid age between(0-120): ");
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age < 0 || age > 120)
                    {
                        Console.WriteLine(" The invalid age ");
                        goto startloop;

                    }
                    Console.WriteLine($" valid age entered: {age} ");



                }




            }


















        }


    }


}


