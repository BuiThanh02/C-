using System;
using System.Collections;
using System.Collections.Generic;

namespace Starbucks
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Star { get; set; }

        public Customer(string id, string name, int star)
        {
            Id = id;
            Name = name;
            Star = star;
        }
    }

    public class Drinks
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }

        public Drinks (string id, string name, string size, double price)
        {
            Id = id;
            Name = name;
            Size = size;
            Price = price;
        }
    }

    public class Bill
    {
        public string Id_Bill { get; set; }
        public string Customer_Name { get; set; }
        public double Total { get; set; }
        public int Star { get; set; }

        public Bill (string id_Bill, string customer_Name, double total, int star)
        {
            Id_Bill = id_Bill;
            Customer_Name = customer_Name;
            Total = total;
            Star = star;
        }
    }

    public class QueueCustomer
    {
        Queue<Customer> customersList = new Queue<Customer>();
        public void AddList(Customer p)
        {
            customersList.Enqueue(p);
        }
    }

    class Starbucks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome to StarBucks !!!");

            int a;
            int b;
            int c;
            Queue<Customer> customersQueue = new Queue<Customer>();
            ArrayList customerList = new ArrayList();
            do
            {
                do
                {
                    Console.WriteLine("Are you a staff or a customer: ");
                    Console.WriteLine("1. Staff.");
                    Console.WriteLine("2. Customer.");
                    a = Console.Read();
                    Console.ReadLine();
                    switch (a)
                    {
                        case '1':
                            customersQueue.Dequeue();
                            ListDrink();
                            Console.WriteLine("Please choose your drinks.");

                            break;
                        case '2':
                            Console.WriteLine("Enter your information: ");
                            Console.WriteLine("Enter your Id (optional): ");
                            string Id = Console.ReadLine();
                            Console.WriteLine("Enter your name: ");
                            string Name = Console.ReadLine();
                            int Star = 0;
                            Customer NewCustomer = new Customer(Id, Name, Star);
                            customersQueue.Enqueue(NewCustomer);
                            customerList.Add(NewCustomer);
                            break;
                    }
                } while (a != '3');
                Console.WriteLine("Coutinue ???");
                c = Console.Read();
            } while (c == '1');
            Console.WriteLine("Thanks you for using our service.");
        }

        static void ListDrink()
        {
            List<Drinks> DrinkList = new List<Drinks>();
            foreach(Drinks p in DrinkList)
            {
                Console.WriteLine(p);
            }
        }
        static void Choose()
        {
            int a;
            do
            {
                Console.WriteLine("Enter drink id: ");

                Console.WriteLine("Continue?");
                a = Console.Read();

            } while (a == '1');
        }
    }
}
