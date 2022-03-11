using System;

namespace classwork
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();  //Akanksha...
            if (Name.Length < 3)
            {
                Console.WriteLine("Invalid User Entry");
            }
            else
            {
                Console.WriteLine(" Hello " + Name + " How are you....! ");

            }
        }
    }
}
