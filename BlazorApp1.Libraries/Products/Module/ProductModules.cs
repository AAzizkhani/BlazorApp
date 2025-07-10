using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.Products.Module
{
    public  class ProductModules
    {
        public string Sku {  get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }

        public string Slug
        {
            get
            {
                return Sku.ToLower();
            }
        }

        public string string FullUrl
        {
            get
            {
                return string.Format("/Product/{0}");
            }
        }

        public ProductModules(string sku , string name ,  int price , string imageurl)
        {
            this.Sku = sku;
            this.Name = name;
            this.Price = price;
            this.ImageUrl = imageurl;
        }
    }
}
