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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            
            var parakeet = new Bird();
            parakeet.Name = "Parakeet";
            parakeet.Color = "Blue";
            parakeet.Lifespan = "15 years";
            parakeet.WingSpan = 3;

            Console.WriteLine($"I am a {parakeet.Name} and my wingspan is {parakeet.WingSpan}");
            Console.WriteLine($"I am a beautiful {parakeet.Color}");
            Console.WriteLine($"I am will live about {parakeet.Lifespan}");
            

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */

            var snake = new Reptile();
            snake.Color = "tan";
            snake.Lifespan = "10 years";
            snake.Habitat = "sand";
            snake.Diet = "carnivore";
            snake.Name = "Snake";
            
            Console.WriteLine("");
            Console.WriteLine($"I am a {snake.Name} and my habitat is {snake.Habitat}");
            Console.WriteLine($"I am a {snake.Color} {snake.Diet}");
            Console.WriteLine($"And i will live about {snake.Lifespan}");


        }
    }
}
