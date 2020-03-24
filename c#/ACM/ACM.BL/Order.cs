using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0) //remove and use default value assmption
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        public string Log() =>
            $"{OrderId}: Date: {OrderDate.Value.Date} Status: {EntityState.ToString()}";

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        public override bool Validate()
        {
            var isValid = true;

            if(OrderDate == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
