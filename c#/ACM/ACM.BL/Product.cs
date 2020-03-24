namespace ACM.BL
{
    using Acme.Common;

    public class Product : EntityBase, ILoggable
    {
        private string _productName;

        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }

            set
            {
                _productName = value;
            }
        }

        public string ProductDescription { get; set; }

        public decimal? CurrentPrice { get; set; }

        public string Log() =>
                 $"{ProductId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName))
            {
                isValid = false;
            }

            if (CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
