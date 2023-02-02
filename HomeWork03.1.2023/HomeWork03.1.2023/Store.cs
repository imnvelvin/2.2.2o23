using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork03._1._2023
{
    internal class Store
    {
        public  string   Products;

        Store[] Products = new Store[0];
        public void AddProduct(Product pr  )
        {
            if (!HasProductByNo(pr.ProductNumber))
            {
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = pr;
            }
            else
            {
                throw new Exception();
            }
        }
        public bool HasProductByNo(string no)
        {
            foreach (Product pr in Products)
            {
                if (pr.ProductNumber == no)
                    return true;
            }
            return false;
        }

    }
}
