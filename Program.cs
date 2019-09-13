using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args) 
        {
            string name;
            int age;

            Console.Write("your name: ");
            name =Console.ReadLine();
            Console.Write("Your age: ");
            age = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine( $"Your name {name}. You were born at {2019 - age}.");
    }
  }
}