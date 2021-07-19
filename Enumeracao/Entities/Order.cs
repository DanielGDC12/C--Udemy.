using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumeracao.Entities.Enums;

namespace Enumeracao.Entities
{
    class Order
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Pedido{ get; set; }


        public override string ToString()
        {
            return ID + ", " + Moment + " , " + Pedido;
        }
    }
}
