using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Which management system would you like to use?");
                Console.WriteLine("1 ~ Queue management");
                Console.WriteLine("2 ~ Register management");
                Console.WriteLine("3 ~ Workers management");
                Console.WriteLine("4 ~ exit");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    QueueManagement.queueManagement();
                }
                else if (choice == 2)
                {
                    RegisterManagement.registerManagement();
                }
                else if (choice == 3)
                {
                    WorkersManagement.workersManagement();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incompatible answer. Please pick a number between 1 and 4");
                }
            }
            
            /*Product product1 = new Product(1);
            Product product2 = new Product(2);
            Product product3 = new Product(3);
            Product product4 = new Product(4);
            Product product5 = new Product(5);
            Product product6 = new Product(6);
            Costumer costumer1 = new Costumer(37, true, false);
            Costumer.AddProduct(costumer1, 1);
            Costumer.AddProduct(costumer1, 4);
            Costumer.AddProduct(costumer1, 2);
            Costumer costumer2 = new Costumer(37, true, false);
            Costumer.AddProduct(costumer2, 1);
            Costumer.AddProduct(costumer2, 3);
            var allProducts = costumer1.ProductsList.Union(costumer2.ProductsList).ToList();
            allProducts = allProducts.OrderBy(product => product.ProductID).ToList();
            Console.WriteLine("The amount of products in the list is: " + costumer1.ProductsList.Count);
            Costumer.ShowProductList(costumer1);
            Costumer.ShowProductList(costumer2);
            Console.WriteLine("And the products are:");
            foreach (var product in allProducts)
            {
                Console.WriteLine(product.ProductID);
            }
            Register register = new Register();
            Register.AddCostumer(register, costumer1);
            Register.AddCostumer(register, costumer2);
            Register.ShowCostumerList(register);
            Register.ShowProductList(register);*/
            //Console.WriteLine(register.RegisterID);

        }
    }
}
