using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Product
    {
        //public static int ID = 1;
        public int ProductID { get; set; }

        public Product(int ID)
        {
            //ProductID = ID++;
            ProductID = ID;
        }
    }
}
