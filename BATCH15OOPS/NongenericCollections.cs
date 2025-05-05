using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPSAssign
{
    class NongenericCollections
    {

        static void Main()
        {

            Console.WriteLine("Assignment 1 Array List");

            //creating object in array list

            ArrayList list = new ArrayList();

            //Adding the elements in arraylist

            list.Add("Aaranya");
            list.Add("Vanya");
            list.Add("Kashvi");
            list.Add("Chandni");
            list.Add("Urvi");
            list.Add("Ishya");
            list.Add("Nisarga");
            list.Add("Eira");
            list.Add("Harini");
            list.Add("Prakriti");

            //accessing element in the array list

            Console.WriteLine("------ The Arraylist element ------");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //Removing element in the array list
            Console.WriteLine(" ------The Arraylist element after the remove operations ------ ");
            list.Remove("Eira");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //remove element
            Console.WriteLine("------ remove element in the array list ------");
            list.RemoveAt(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }






            //create a hashtable

            Console.WriteLine(" Assignment 2 Hashtable");

            Hashtable myht = new Hashtable();

            Console.WriteLine("------- The Hashtable element ------");


            myht.Add("Name", "SaiShwari");
            myht.Add("class", "F.Y Btech");
            myht.Add("subject", "Eng math");
            myht.Add("Department", "CSE");
            myht.Add("Attendence calling", "56");

            foreach (DictionaryEntry entry in myht)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }


            Console.WriteLine("------Modify Value------");
            myht["Attendence calling"] = "94";

            foreach (DictionaryEntry entry in myht)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }


            Console.WriteLine("------Remove Element-------");
            myht.Remove("subject");

            foreach (DictionaryEntry entry in myht)
            {
                Console.WriteLine($"{entry.Key}:{entry.Value}");
            }








        }










    }
}
