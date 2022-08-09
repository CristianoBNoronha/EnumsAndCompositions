using System;
using System.Collections.Generic;
using System.Text;
using EnumeracoesEComposicao.Entities.Enums;

namespace EnumeracoesEComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public OrderItem OrderItem { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, OrderItem orderItem)
        {
            Moment = moment;
            Status = status;
            OrderItem = orderItem;
        }

        public void AddOrder(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }
        public void RemoveOrder(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }
        public double Total(double subtotal)
        {
            double sum = 0;
            foreach (OrderItem orderItem in Items)
            {
                
                sum = sum + OrderItem.Price;
            }


        }
    }
}
