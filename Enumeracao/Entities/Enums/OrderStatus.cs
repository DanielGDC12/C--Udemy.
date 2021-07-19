using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeracao.Entities.Enums
{
   enum  OrderStatus : int  /* derivacao de ORDERSTATUS QUE E DO TIPO INT */
    {
        PaymentPending = 0,
        Processing =1,
        Shipped = 2 ,
        Delivered = 3
    }
}
