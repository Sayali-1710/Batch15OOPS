using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPSAssign
{
    class GenericCollections
    {

        //dictionary

        static void Main()
        {

            Dictionary<int, string> fruitdict = new Dictionary<int, string>()

            {
                {1, "Mango" },
                {2, "Orange" },
               {3, "Lemon" },
               {4, "Apple" },
              {5, "Pineapple" },
               {6, "Anjir" },
               {7, "Gauva" },
               {8, "Banana" },
                {9, "Cherry" },
               {10, "Pomogranate" }

            };
            

            Console.WriteLine("======All Elements added in dictionary======");

            foreach (var kvp in fruitdict)
            {
                Console.WriteLine($"key:{kvp.Key},value:{kvp.Value}");
            }

            //modify dictionary
            fruitdict[9] = "Anjir";

            Console.WriteLine("After modifying key 9:");

            Console.WriteLine($"key:9,: Value:{fruitdict[9]}");


            //remove element in dictionary

            fruitdict.Remove(5);

            Console.WriteLine("======After removing key 5:======");

            foreach (var kvp in fruitdict)
            {
                Console.WriteLine($"key:{kvp.Key},value:{kvp.Value}");
            }

            //find element in dictionary

            if (fruitdict.ContainsKey(10))
            {
                Console.WriteLine("=*=*=*=*Found in Dictionary=*=*=*=*");
            }
            else
            {
                Console.WriteLine("=*=*=*=*Not found in Dictionary=*=*=*=*");
            }




        }







    }
}
