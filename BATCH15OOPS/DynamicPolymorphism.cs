using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPSAssign
{

    class Vehicle
    {
        public virtual void startengine()
        {
            Console.WriteLine("=====Vehicle Engine Started=====");
        }
    }

    class car : Vehicle
    {
        public override void startengine()
        {
            Console.WriteLine("car Engine Started");
        }
    }
    class Truck : Vehicle
    {
        public override void startengine()
        {
            Console.WriteLine("Truck Engine Started");
        }
    }

    class Bike : Vehicle
    {
        public override void startengine()
        {
            Console.WriteLine("Bike Engine started");
        }
    }
    class Bus : Vehicle
    {
        public override void startengine()
        {
            Console.WriteLine("Bus Engine started");
        }

    }
    class Tractor : Vehicle
    {

        public override void startengine()
        {
            Console.WriteLine("Tractor Engine started");
        }

    }
    class Aerialtramway : Vehicle
    {
        public override void startengine()
        {
            Console.WriteLine("Aerialtramway Engine started");
        }
    }

    class DynamicPolymorphism
    {
        static void Main()
        {
            Vehicle Vehicle1 = new Vehicle();
            Vehicle vehicle2 = new car();
            Vehicle vehicle3 = new Truck();
            Vehicle vehicle4 = new Bike();
            Vehicle vehicle5 = new Bus();
            Vehicle vehicle6 = new Tractor();
            Vehicle vehicle7 = new Aerialtramway();

            Vehicle1.startengine();
            vehicle2.startengine();
            vehicle3.startengine();
            vehicle4.startengine();
            vehicle5.startengine();
            vehicle6.startengine();
            vehicle7.startengine();




        }




    }
}
