namespace Batch15OOPS
{
    class Arrays
    {

        static void Main()
        {

            // 1]Declare the arrays

            Console.WriteLine("------Sum values of an array------");

            {
                int[] Numbers = new int[8];

                Numbers[0] = 12;
                Numbers[1] = 24;
                Numbers[2] = 36;
                Numbers[3] = 48;
                Numbers[4] = 60;
                Numbers[5] = 72;
                Numbers[6] = 84;
                Numbers[7] = 96;

                int sum = 0;
                for (int s = 0; s < Numbers.Length; s++)
                {

                    sum += Numbers[s];


                }
                Console.WriteLine("The sum value :" + sum);



            }

            // 2]Average values
            {

                Console.WriteLine("-------Average values of an array-------");

                {
                    int[] numbers = { 20, 40, 60, 80, 100 };

                    int sum = 0;
                    foreach (int num in numbers)
                    {
                        sum += num;
                    }
                    double average = (double)sum / numbers.Length;
                    Console.WriteLine("Average value of array elements: " + average);







                }


            }


            // 3]Even and Odd integers in a given array of integers

            {
                int[] number = { 4, 16, 19, 23, 26, 30, 36, 40, 41, 45, 56, 57, 59, 75, 95 };

                Console.WriteLine("Even numbers in a given array using for loop");

                for (int x = 0; x < number.Length; x++)
                {
                    if (number[x] % 2 == 0)
                        x++;

                }


                Console.WriteLine("Even numbers in a given array using foreach loop");

                foreach (int x in number)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine(x);
                    }



                }


                Console.WriteLine("Odd numbers in a given array-");
                foreach (int x in number)
                {
                    if (x % 2 != 0)
                    {
                        Console.WriteLine(x);
                    }
                }





            }




            // 4] prime number in given array

            {
                int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };

                Console.WriteLine("-----Prime Number in given array-----");
                foreach (int num in number)
                {
                    if (IsPrime(num))
                    {
                        Console.WriteLine(num + "  ");

                    }

                }
            }

            static Boolean IsPrime(int num)
            {
                if (num < 2)
                { return false; }
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }

                }
                return true;



            }


            //Basics of array

            Console.WriteLine("========****========****========");
            {
                int[] number = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

                Console.WriteLine(" The Alternate elements in the array are:  ");
                for (int x = 0; x < number.Length; x += 2)
                {
                    Console.WriteLine(number[x]);
                }


            }

            Console.WriteLine("========****========****========");
            {

                int[] number = { 4, 16, 18, 20, 24, 26, 30, 59, 60, 80 };

                Console.WriteLine(" The Number of element in the array are:  " + number.Length);

            }

            Console.WriteLine("========****========****========");
            {
                int[] number = { 6, 7, 8, 10, 2, 12, 3 };

                int smallest = number[0];
                for (int p = 1; p < number.Length; p++)
                {
                    if (number[p] < smallest)
                    {
                        smallest = number[p];
                    }
                }
                Console.WriteLine(" The Smallest number in the array is:  " + smallest);

            }


            Console.WriteLine("========****========****========");
            {
                int[] number = { 1, 5, 8, 10, 64, 24, 28, 96, 89 };
                int largest = number[0];
                for (int q = 1; q < number.Length; q++)
                {
                    if (number[q] > largest)
                    {
                        largest = number[q];
                    }
                }
                Console.WriteLine(" The largest number in the array is;  " + largest);

            }

































        }
    }
}


