using System;

namespace VD11
{
    class Multiplication
    {
        staticint _valueOne = 10;
        staticint _product;
        static Multiplication()
        {
            Console.WriteLine(“Static Constructor initialized”);
            _product = _valueOne * _valueOne;
        }
        public static void Method()
        {
            Console.WriteLine(“Value of product = “ +_product);
        }
        static void Main(string[] args)
        {
            Multiplication.Method();
        }
    }
}
