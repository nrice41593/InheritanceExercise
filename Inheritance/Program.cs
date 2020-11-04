using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - DONE
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird - DONE
            // Set this class to inherit from your Animal Class - DONE

            // Create a class Reptile - DONE
            // give this class 4 members that are specific to Reptile - DONE
            // Set this class to inherit from your Animal Class - DONE



            var bird1 = new Bird();
            
            bird1.Name = "Puffin";
            bird1.Fly = false;
            bird1.Breathe = true;

            Console.WriteLine($"Your bird is a {bird1.Name}, can it fly? {bird1.Fly}, can it breathe? {bird1.Breathe}");

            /*Create an object of your Bird class - DONE
             *  give values to your members using the object of your Bird class - DONE
             *  
             * Creatively display the class member values - DONE
             */

            var reptile1 = new Reptile();

            reptile1.ColdBlooded = true;
            reptile1.Legs = 4;
            reptile1.Breathe = true;

            Console.WriteLine($"How many legs does your reptile have? {reptile1.Legs}, do reptiles breathe? {reptile1.Breathe}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
