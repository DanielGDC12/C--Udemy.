using System;
using Enumeracao.Entities.Enums;
using Enumeracao.Entities;


namespace Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                ID = 1080,
                Moment = DateTime.Now,
                Pedido = OrderStatus.PaymentPending

            };


            Console.WriteLine(order);


            /* Exemplos de conversao da entrada de dados em string para o tipo ENUMS */

            string txt = OrderStatus.PaymentPending.ToString(); /*Converte o Tipo enums para STRING */

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); /* Enum.Parse <> , dentro de <> vai o Tipo de dado a ser convertido e em () o status deve ser instruido da mesma forma que a declaracao em Ordestatus*/

            Console.WriteLine(txt);
            Console.WriteLine(os);

        }
    }
}
