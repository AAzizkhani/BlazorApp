using BlazorApp1.Libraries.Products.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.ShoppingCart.Module
{
    public class ShoppingCartItemModule
    {
        public ProductModules Product { get;}
        public int Price { get; protected set; }
        public int Quantity { get; protected set; }

        public int TotalPrice
        {
            get 
            {
                return Price * Quantity;
            }
        }

        public ShoppingCartItemModule(ProductModules product, int quantity)
        {
            this.Product = product;
            this.Price = product.Price;
            this.Quantity = quantity;
        }

        public void UpdateQuantity(ProductModules product , int quantity)
        {
            this.Price = product.Price;
            this.Quantity = quantity;
        }

    }
}


