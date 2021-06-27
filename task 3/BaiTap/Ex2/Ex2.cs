using System;

namespace Ex2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2: ");
            int number2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter number3: ");
            int number3 = Int32.Parse(Console.ReadLine());
            Console.Write("The maximum number in three number is: ");
            Console.WriteLine(Math.Max(Math.Max(number1, number2), number3));
        }
    }
}
