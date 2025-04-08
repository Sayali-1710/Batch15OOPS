using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class AccessModifiersDemo
    {
        public class person
        {
            public string firstname = "SAYALI";
            public string lastname = "TODKAR";

        }
        public void displayfullname(person person)
        {
            Console.WriteLine("FullName is:" + person.firstname + "  " + person.lastname);

        }


        public static void Main(string[] args)
        {
            AccessModifiersDemo demo = new AccessModifiersDemo();
            person person = new person();
            demo.displayfullname(person);

        }
    }
}
