using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercise1
{
    class Costumer: Person
    {
        public static Product product1 = new Product(1);
        public static Product product2 = new Product(2);
        public static Product product3 = new Product(3);
        public static Product product4 = new Product(4);
        public static Product product5 = new Product(5);
        public static Product product6 = new Product(6);

        private int costumerID;
        public static int ID = 1;
        private List<Product> productsList = new List<Product>();

        public int CostumerID
        {
            get
            {
                return costumerID;
            }    
            set
            {
                costumerID = value;
            }        
        }
        public List<Product> ProductsList 
        {
            get { return productsList; }
            set { productsList = value; }
        }

        public static void AddProduct(Costumer costumer, int ID, bool print)
        {
            if (costumer.ProductsList.Exists(product => product.ProductID == ID)) //checks if we already have this product or identical product
            {
                //the option to print exists in case of manual edition of products
                if (print)      {   Console.WriteLine("The costumer already has a product with {0} ID", ID);    }
            }
            else
            {
                if (ID == 1) 
                {   
                    costumer.ProductsList.Add(product1);
                }
                else if (ID == 2)
                {
                    costumer.ProductsList.Add(product2);
                }
                else if (ID == 3)
                {
                    costumer.ProductsList.Add(product3);
                }
                else if (ID == 4)
                {
                    costumer.ProductsList.Add(product4);
                }
                else if (ID == 5)
                {
                    costumer.ProductsList.Add(product5);
                }
                else if (ID == 6)
                {
                    costumer.ProductsList.Add(product6);
                }
                else
                {
                    Console.WriteLine("Invalid product.");
                }
                costumer.ProductsList = costumer.ProductsList.OrderBy(product => product.ProductID).ToList();
            }
        }

        public static void ShowProductList(Costumer costumer)
        {
            Console.Write("Costumer{0}'s products list is: ", costumer.costumerID);
            foreach(Product product in costumer.ProductsList)
            {
                Console.Write(product.ProductID + " ");
            }
            Console.WriteLine();
        }

        public Costumer(float bodyHeat, bool mask, bool isolation)
            :base(bodyHeat, mask, isolation)
        {
            this.BodyHeat = bodyHeat;
            this.Mask = mask;
            this.Isolation = isolation;
            this.costumerID = ID++;
        }
    }
}
