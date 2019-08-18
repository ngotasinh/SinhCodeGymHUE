using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3.list
{
    class LisProduct
    {
        public Product[] ProductList { get; set; }
        public Product this[int index]
        {
            get { return ProductList[index]; }
            set { ProductList[index] = value; }
        }
        public Product this[string name]
        {
            get
            {
                for (int i = 0; i < ProductList.Length; i++)
                {
                    if (ProductList[i].PName.ToUpper().Equals(name.ToUpper()))
                    {
                        return ProductList[i];
                    } 
                }
                return null;
            }
        }
    }
}
