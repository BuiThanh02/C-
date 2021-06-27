using System;

namespace Ex4
{
    class Ex4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 1;i <= 9; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}");
            }
        }
    }
}
