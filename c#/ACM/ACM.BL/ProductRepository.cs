using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "blabla";
                product.CurrentPrice = 15.96M;
            }

            return product;
        }

        public bool save(Product product)
        {
            var success = true;

            if(product.HasChanges)
            {
                if(product.IsValid)
                {
                    if(product.IsNew)
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
