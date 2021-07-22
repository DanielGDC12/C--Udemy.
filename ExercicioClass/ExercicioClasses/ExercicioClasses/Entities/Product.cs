using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasses.Entities
{
    class Product
    {

        public double ProductPrice { get; set; }
        public string ProductName { get; set; }


        public Product()
        {

        }

        public Product(double productPrice, string productName)
        {
            ProductPrice = productPrice;
            ProductName = productName;
        }
    }
}
