using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPSAssign
{
    class calculator
    {
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }

        public double Add(double x, double y, int z)
        {
            return x + y + z;
        }

        public int subst(int x, int y)
        {
            return x - y;
        }
        public double subst(double x, double y)
        {
            return x - y;

        }
        public int multi(int x, int y)
        {
            return x * y;

        }
        public double multi(double x, double y)
        {
            return x * y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }

        public double div(double x, double y)
        {
            return x / y;
        }
    }

    class StaticPolymorphism
    {
        static void Main()
        {
            calculator c = new calculator();

            int sum = c.Add(23, 56, 52);
            double doublesum = c.Add(24.2, 12.6, 4);
            int subst = c.subst(26, 29);
            double doublesubst = c.subst(96.2, 16.9);
            int multi = c.multi(101, 126);
            double doublemulti = c.multi(46.23, 23.8);
            int Div = c.Div(48, 24);
            double doubleDiv = c.Div(186, 2);



            Console.WriteLine($"Sum of integer value:  {sum}");
            Console.WriteLine($"Sum of Decimal value:  {doublesum}");
            Console.WriteLine($"Substract of integer value:  {subst}");
            Console.WriteLine($"Substract of Decimal value:  {doublesubst}");
            Console.WriteLine($"Multiplication of integer value:  {multi}");
            Console.WriteLine($"Multiplication of Decimal value:  {doublemulti}");
            Console.WriteLine($"Division of integer value:  {Div}");
            Console.WriteLine($"Division of integer value:  {doubleDiv}");



        }







    }
}
