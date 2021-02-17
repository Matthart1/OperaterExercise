using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var div = a / b;
            var mod = a % b;


            Console.WriteLine($"{a}/{b} is {div} with a remaineder of {mod}");        }      
    }
}
