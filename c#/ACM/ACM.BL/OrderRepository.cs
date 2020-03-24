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

            if(orderId == 10)//indent
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 3, 23, 7, 23, 0,
                    new TimeSpan(2, 0, 0)); //indent
            }

            return order;
        }

        public bool save(Order order)
        {
            var success = true;

            if (order.HasChanges) // simplify
            {
                if (order.IsValid)
                {
                    if (order.IsNew)
                    {
                        //Call an insert procedure
                    }
                    else
                    {
                        //Call an update procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
