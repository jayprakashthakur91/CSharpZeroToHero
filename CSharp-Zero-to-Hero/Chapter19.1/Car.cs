using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter19._1
{ 
    class MarutiSuzukiCar
    {
        // Fields (Data / State)
        public string ModelName;
        public string Color;
        public string FuelType;
        public int Speed;

        // Behaviors (Methods)
        public void Start()
        {
            Console.WriteLine("Car started "+ModelName);
        }

        public void Accelerate()
        {
            Speed += 10;
            Console.WriteLine("Speed increased to " + Speed);
        }

        public void Brake()
        {
            Speed -= 10;
            Console.WriteLine("Speed decreased to " + Speed);
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine("Car stopped");
        }
    }
    class MainClass
    {
        //static void Main(string[] args)
        //{
        //    // Creating an object of MarutiSuzukiCar
        //    MarutiSuzukiCar myCar = new MarutiSuzukiCar();
        //    // Setting properties
        //    myCar.ModelName = "Swift";
        //    myCar.Color = "Red";
        //    myCar.FuelType = "Petrol";
        //    myCar.Speed = 0;
        //    // Using methods
        //    myCar.Start();
        //    myCar.Accelerate();
        //    myCar.Accelerate();
        //    myCar.Brake();
        //    myCar.Stop();

        //    //Create your car object here and test all the methods
        //    MarutiSuzukiCar anotherCar = new MarutiSuzukiCar();
        //    anotherCar.ModelName = "Dzire";
        //    anotherCar.Color = "Blue";
        //    anotherCar.FuelType = "Diesel";
        //    anotherCar.Speed = 0;
        //    anotherCar.Start();
        //    anotherCar.Accelerate();
        //    anotherCar.Brake();
        //    anotherCar.Stop();

        //}
    }
}
