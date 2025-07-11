using BlazorApp1.Libraries.Products.Module;
using BlazorApp1.Libraries.ShoppingCart.Module;
using BlazorApp1.Libraries.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.ShoppingCart
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IStorageServices  _storageServices;
        public ShoppingCartService(IStorageServices storageServices)
        {
            this._storageServices = storageServices;
        }

        public void AddProduct(ProductModules product, int quantity)
        {
            var items = Get().Items;
            if (HasProducts(product.Sku))
            {
                var item = items.First(i=>i.Product.Sku == product.Sku);
                item.UpdateQuantity(product, quantity);
            }
            else
            {
                items.Add(new ShoppingCartItemModule(product, quantity)); 
            }
        }

        public int Count()
        {
            return Get().Items.Count(); 
        }

        public void DeleteProduct(ShoppingCartItemModule item)
        {
            var items = Get().Items;
            if (HasProducts(item.Product.Sku))
            {
                items.Remove(items.First(i=>i.Product.Sku == item.Product.Sku));

            }
        }

        public ShoppingCartModule Get()
        {
            return _storageServices.ShoppingCart;
        }

        public bool HasProducts(string sku)
        {
            var shoppingCart = Get();
            return shoppingCart.Items.Any(i=>i.Product.Sku == sku);
        }
    }
}
