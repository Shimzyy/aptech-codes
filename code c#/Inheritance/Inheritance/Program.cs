// See https://aka.ms/new-console-template for more information
using System;

namespace Animal
{
    class Animal
    {
        public string name = "Animal";
        public void sound()
        {
            Console.WriteLine("All animals make sound");
        }

    }
   class Dog : Animal
    {
        public void legs ()
        {
            Console.WriteLine("All Dogs have four legs");

        }
        static void main(string[] args)
        {
            Console.WriteLine("Hello world");

            Dog objDog = new Dog();
           objDog.sound();
            Console.WriteLine(objDog.name);
            objDog.legs();
        }
    }
        }


