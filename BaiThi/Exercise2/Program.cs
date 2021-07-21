using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            Console.WriteLine();
            Lion lion = new Lion();

            tiger.Show();
            lion.Show();
        }
    }
}
