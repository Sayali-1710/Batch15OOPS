namespace Batch15OOPS
{
    internal class Enumexamples
    {

        //syntax of enum

        enum Year
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            Septmber,
            October,
            November,
            December

        }
        static void Main()
        {
            Console.WriteLine("Enter the month : January");

            Year month = Year.January;

            switch (month)
            {
                case Year.January:
                    Console.WriteLine("Starting month of the year");
                    break;
                case Year.February:
                    Console.WriteLine(" Month is February");
                    break;
                case Year.March:
                    Console.WriteLine(" Month is March");
                    break;
                case Year.April:
                    Console.WriteLine(" Month is April");
                    break;
                case Year.May:
                    Console.WriteLine(" Month is May");
                    break;
                case Year.June:
                    Console.WriteLine(" Month is June");
                    break;
                case Year.July:
                    Console.WriteLine(" Month is July");
                    break;
                case Year.August:
                    Console.WriteLine(" Month is August");
                    break;
                case Year.Septmber:
                    Console.WriteLine(" Month is September");
                    break;
                case Year.October:
                    Console.WriteLine(" Month is October");
                    break;
                case Year.November:
                    Console.WriteLine(" Month is November");
                    break;
                case Year.December:
                    Console.WriteLine(" Ending Month of the Year");
                    break;
                default:
                    Console.WriteLine(" Invalid Month of the year");
                    break;


            }

            if (month == Year.January)
            {
                Console.WriteLine("Starting month of the year");
            }
            else if (month == Year.December)
            {
                Console.WriteLine("Ending month of the year");
            }
            else
            {
                Console.WriteLine($"Month : {month}");
            }

        }


    }
}























