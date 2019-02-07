using System;

namespace HelloWorld2
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Please enter your name: ");
            string name = Console.Readline(); 
            Console.Write("Hello ", name);           
            Console.ReadLine(); 
        }
    }
}
