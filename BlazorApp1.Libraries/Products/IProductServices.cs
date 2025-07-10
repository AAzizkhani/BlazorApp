using BlazorApp1.Libraries.Products.Module;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.Products
{
    public interface IProductServices
    {
        ProductModules? GetProduct(string sku);
        ProductModules? GetProductBySlug(string slug);
        IList<ProductModules> GetAll();
    }
}
