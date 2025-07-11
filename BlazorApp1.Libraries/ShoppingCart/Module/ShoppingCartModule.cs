using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.ShoppingCart.Module
{
    public  class ShoppingCartModule
    {
        public IList<ShoppingCartItemModule> Items { get;}
        public ShoppingCartModule() 
        {
            Items = new List<ShoppingCartItemModule>();
        }
    }
}
