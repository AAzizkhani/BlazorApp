using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.Products.Module
{
    public interface IProductAddToCart
    {
        public ProductModules? Product { get; set; }
        public int? Quantity { get; set; }
        void AddToCart();

    }
}
