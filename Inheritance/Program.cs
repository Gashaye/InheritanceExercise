using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class


            var myBird = new Bird();
            myBird.animalName = "Eagle";
            myBird.animalAge = 5;
            myBird.animalType = "Bird";
            myBird.color = "Black and White";

            Console.WriteLine("----- Bird Information -----");
            Console.WriteLine($"Animal Name: {myBird.animalName}");
            Console.WriteLine($"Type: {myBird.animalType}");
            Console.WriteLine($"Age: {myBird.animalAge}");
            Console.WriteLine($"Color: {myBird.color}");

            var myReptile = new Reptile();
            myReptile.animalType = "Cold Blood";
            myReptile.animalAge = 7;
            myReptile.animalName = "Reptile";
            myReptile.color = "Different colors";
            Console.WriteLine();

            Console.WriteLine("----- Reptile Information -----");
            Console.WriteLine($"Animal Type: {myReptile.animalName}");
            Console.WriteLine($"Type: {myReptile.animalType}");
            Console.WriteLine($"Age: {myReptile.animalAge}");
            Console.WriteLine($"Color: {myReptile.color}");




            /*Create an object of your Bird class
             *
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
