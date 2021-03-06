using System;
using ExercicioClasses.Entities.Enums;
using ExercicioClasses.Entities;
using System.Text;
using System.Collections.Generic;

namespace ExercicioClasses.Order
{
    class Order
    {

        public DateTime Moment { get; set; }
        public Client Client { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items = new List<OrderItem>();

        public Order( )
        {

        }

        public Order(DateTime moment , OrderStatus status, Client client)
        {
            Client = client;
            Moment = moment;
            Status = status;

        }


        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;

            foreach(OrderItem item in Items){
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY");
            sb.AppendLine("Order Moment:"+ Moment.ToString("dd/MM/yyy HH:mm:ss"));
            sb.AppendLine("Status : " + Status);
            sb.AppendLine("Client:" + Client);
            sb.AppendLine("Order Items: ");
            foreach(OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();


        }
    }
}
