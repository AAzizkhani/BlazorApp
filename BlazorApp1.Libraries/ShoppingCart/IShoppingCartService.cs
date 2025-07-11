using BlazorApp1.Libraries.Products.Module;
using BlazorApp1.Libraries.ShoppingCart.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.ShoppingCart
{
    public interface IShoppingCartService
    {
        ShoppingCartModule Get();
        void AddProduct(ProductModules product, int quantity);
        void DeleteProduct(ShoppingCartItemModule item);
        int Count();
        bool HasProducts(string sku);

    }
}
