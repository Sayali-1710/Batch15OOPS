using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPSAssign
{

    public class person
    {
        public int age { get; set; }
        public string name { get; set; }
        public void show()
        {
            Console.WriteLine($"The person name is : {name} , The person age is : { age}");
        }
    }
    public class student : person
    {
        public void study()
        {
            Console.WriteLine($" {name} is Student ");
        }

    }
    public class Teacher : student
    {
        public void teach()
        {
            Console.WriteLine($" {name} is Teaching ");
        }


    }
    public class subject : Teacher
    {
        public void display()
        {
            Console.WriteLine($"{name} is Teaching a Science subject.");
        }

    }

    class InheritanceExample
    {
        public static void Main()
        {
            //single inheritance
            student student = new student();
            student.name = "samartha";
            student.age = 12;
            student.show();
            student.study();



            //multiple inheritance
            subject subject = new subject();
            subject.name = "Mane sir";
            subject.age = 28;
            subject.show();
            subject.teach();
            subject.display();


        }


    }
}
