using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Zero_to_Hero.Chapter19._9
{
    class Animal  // Base class (parent) 
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void  AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class MethodOverriding
    {
        //public static void Main(string[] args)
        //{
        //    //Pig myPig = new Pig();  // Create a Pig object
        //    //Dog myDog = new Dog();  // Create a Dog object
        //    //myPig.AnimalSound();  // Call the method on the Pig object
        //    //myDog.AnimalSound();  // Call the method on the Dog object


        //    Animal mypig1 = new Pig();  // Create a Pig object
        //    mypig1.AnimalSound();  // Call the method on the Pig object
        //    Animal mydog1 = new Dog();  // Create a Dog object
        //    mydog1.AnimalSound();
        //    Console.ReadKey();

        //}
    }

}
