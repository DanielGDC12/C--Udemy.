using ExercicioClasses.Entities.Enums;
using ExercicioClasses.Entities;
using System.Globalization;

namespace ExercicioClasses.Order
{
    class OrderItem
    {

        public double Price { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price,Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }


        public override string ToString()
        {
            return Product.ProductName
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
