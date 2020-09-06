using System;

namespace Classes_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Mark");


            var order = new Order();
            customer.Orders.Add(order);


            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}
