using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Type
{
    class Program
    {
        static void Main1(String[] args)
        {
            var stock = new { Name = "Michgan Enterprises", Code = 1310, Price = 35056.75 };
            Console.WriteLine("Stock Name: " + stock.Name);
            Console.WriteLine("Stock Code: " + stock.Code);
            Console.WriteLine("Stock Price: " + stock.Price);
            Console.Read();
        }

        public static void Main(String[] args)
        {
            Employee david = new Employee();
            Employee david2 = new Employee();
            david.DisplayDetails(new { FirstName = "David", LastName = "Blake", Age = 30 });
            david.DisplayDetails(new { LastName = "Blake", Age = 30})
            Console.Read();
        }
    }
}
