using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {
        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }


        public bool Validate()
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

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public bool save()
        {
            return true;
        }
    }
}
