using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int entries = int.Parse(Console.ReadLine());

            List<Products> products = new List<Products>();

            for (int i = 0; i < entries; i++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string productName = tokens[0];
                decimal price = decimal.Parse(tokens[1]);

                Products product = products.FirstOrDefault(p => p.Product == productName);

                if (product == null)
                {
                    Products newProduct = new Products(productName, price);
                    products.Add(newProduct);
                }
                else
                {
                    product.Price = price;
                }
            }

            List<Customer> customers = new List<Customer>();

            string input;
            while ((input = Console.ReadLine())!= "end of clients")
            {
                string[] tokens = input.Split("-,".ToCharArray());
                string customerName = tokens[0];
                string productName = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (!products.Any(p => p.Product == productName))
                {
                    continue;
                }

                Customer customer = new Customer(customerName);

                if (!customers.Any(c => c.Name == customerName))
                {

                    customer.OrderedProducts.Add(productName, quantity);
                    customers.Add(customer);
                }
                else
                {
                    Customer currentCustomer = customers.First(c => c.Name == customerName);

                    if (!currentCustomer.OrderedProducts.ContainsKey(productName))
                    {
                        currentCustomer.OrderedProducts.Add(productName, quantity);
                    }
                    else
                    {
                        currentCustomer.OrderedProducts[productName] += quantity;
                    }
                }
            }

            decimal totalBill = 0;

            foreach (Customer customer in customers.OrderBy(c => c.Name))
            {
                decimal bill = 0;
                Console.WriteLine(customer.Name);

                foreach (var orderedProduct in customer.OrderedProducts)
                {
                    string productName = orderedProduct.Key;
                    int qantity = orderedProduct.Value;
                    decimal price = products.First(p => p.Product == productName).Price;
                    bill += qantity * price;

                    Console.WriteLine($"-- {productName} - {qantity}");
                }

                totalBill += bill;

                Console.WriteLine($"Bill: {bill:f2}");
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> OrderedProducts { get; set; }

        public Customer(string name)
        {
            this.Name = name;
            this.OrderedProducts = new Dictionary<string, int>();
        }
    }
    class Products
    {
        public string Product { get; set; }
        public decimal Price { get; set; }

        public Products(string product, decimal price)
        {
            this.Product = product;
            this.Price = price;
        }
    }
}
