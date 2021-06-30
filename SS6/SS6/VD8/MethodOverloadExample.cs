using System;

namespace VD8
{
    class MethodOverloadExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine(“Square of integer value “ +Square(5));
            Console.WriteLine(“Square of float value “ +Square(2.5F));
        }
        staticint Square(intnum)
        {
            returnnum* num;
        }
        static float Square(float num)
        {
            returnnum* num;
        }
    }
}
