using System;
using System.Collections.Generic;
using System.Text;

namespace EnumeracoesEComposicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Product Price { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, Product price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal(int quantity, int price)
        {
            return quantity * price;
        }
    }
}
