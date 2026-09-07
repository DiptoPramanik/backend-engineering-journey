using System;

namespace AbstractionAndInterfaceDemo
{
    // === ১. ABSTRACTION (Abstract Class) ===
    abstract class Animal 
    {
        // Abstract method (এর কোনো বডি বা ডিটেইলস থাকবে না)
        public abstract void AnimalSound();

        // Regular method (সাধারণ মেথড)
        public void Sleep() 
        {
            Console.WriteLine("Zzz...");
        }
    }

    // Derived class (যা Animal ক্লাসকে ইনহেরিট করবে)
    class Pig : Animal 
    {
        public override void AnimalSound() 
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }


    // === ২. INTERFACE ===
    interface IVehicle 
    {
        void Drive(); // ইন্টারফেসের মেথডেরও কোনো বডি থাকে না
    }

    // ক্লাস যা ইন্টারফেসটি ইমপ্লিমেন্ট করছে
    class Car : IVehicle 
    {
        public void Drive() 
        {
            Console.WriteLine("The car is driving fast!");
        }
    }


    // === ৩. MAIN PROGRAM ===
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("--- Testing Abstraction ---");
            Pig myPig = new Pig();
            myPig.AnimalSound();
            myPig.Sleep();

            Console.WriteLine("\n--- Testing Interface ---");
            Car myCar = new Car();
            myCar.Drive();
        }
    }
}
