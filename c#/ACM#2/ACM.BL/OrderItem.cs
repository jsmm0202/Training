namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {
        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal? Price { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (Price == null)
            {
                isValid = false;
            }

            if (Quantity <= 0)
            {
                isValid = false;
            }

            if (ProductId <= 0)
            {
                isValid = false;
            }

            return isValid;
        }

        public OrderItem Retrieve(int productId) => new OrderItem();

        public bool Save() => true;
    }
}
