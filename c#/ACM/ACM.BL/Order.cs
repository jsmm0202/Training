using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if(OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }

        public Order Retrieve(int productId)
        {
            return new Order();
        }

        public bool save()
        {
            return true;
        }
    }
}
