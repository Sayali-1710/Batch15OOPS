using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    internal class PrivateExamples
    {
        class person1
        {
            private string first_name;
            private string last_name;

            public person1(string firstname, string lastname)
            {
                first_name = firstname;
                last_name = lastname;

            }
            public void displayfullname()
            {
                Console.WriteLine($"Full Name is : {first_name}{last_name}");


            }
        }
            static void Main(string[] args)
            {
                person1 p = new person1("SAYALI", "TODKAR");
                p.displayfullname();

            }

        

    }
}

   