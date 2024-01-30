using System;

namespace TechPraktZavdanna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.Write($"Suma = {sum}");
        }
    }
}
