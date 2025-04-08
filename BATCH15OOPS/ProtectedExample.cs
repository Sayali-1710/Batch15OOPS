using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{

    class Employee
    {
        protected int Employee_ID;
        protected string Employee_Name;
        protected int Employee_Age;
        protected String Employee_Adress;

        protected void show()
        {
            Console.WriteLine("--Employee Details--");
            Console.WriteLine($"Employee Id ; {Employee_ID}");
            Console.WriteLine($"Employee Name is : {Employee_Name}");
            Console.WriteLine($"Employee Age is : {Employee_Age}");
            Console.WriteLine($"Employee Adress is : {Employee_Adress}");


        }
    }
    class person : Employee
    {
        public person()
        {
            Employee_ID = 5658;
            Employee_Name = "SAYALI TODKAR";
            Employee_Age = 23;
            Employee_Adress = "SATARA";


        }
        public void DisplayDetails()
        {
            show();

        }

    }

    internal class ProtectedExample
    {
        static void Main()
        {
            person emp = new person();
            emp.DisplayDetails();

        }
    }

}
