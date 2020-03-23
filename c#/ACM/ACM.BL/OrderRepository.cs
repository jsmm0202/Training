using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 3, 23, 7, 23, 0,
                    new TimeSpan(2, 0, 0));
            }

            return order;
        }

        public bool save()
        {
            return true;
        }
    }
}
