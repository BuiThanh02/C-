using System;

namespace VD1
{
    class Animal
    {
        protected string Food;
        protected string Activity;
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }
        public void DoSomething()
        {
            Console.WriteLine("Every animal does something.");
        }
    }
    class Mammal : Animal
    {
        public void Feature()
        {
            Console.WriteLine("Mammals give birth to young ones.");
        }
    }
    class Dog : Mammal
    {
        public void Noise()
        {
            Console.WriteLine("Dog Barks.");
        }
        static void Main(string[] args)
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
        }
    }
    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat loves to eat the mouse");
        }
        static void Main(String[] args)
        {
            Cat objCat = new Cat();
            objCat.Eat();
            objCat.DoSomething();
            objCat.Food = "Mouse";
            objCat.Activity = "laze around";
            Console.WriteLine("The Cat loves to eat " + objCat.Food + ".");
            Console.WriteLine("The Cat loves to " + objCat.Activity + ".");
        }
    }
}
