using BlazorApp1.Libraries.Products.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.Storage
{
    public class StorageServices : IStorageServices
    {
        public IList<ProductModules> Products {  get; private set; }
        public StorageServices() 
        {
            Products = new List<ProductModules>();

            AddProduct(new ProductModules("BUBBLES-GUMBALL-APRON", "A Gumball for Your Thoughts Apron", 24, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModules("REX-MICROCONTROLLERS-APRON", "Great Microcontrollers Think Alike Apron", 24, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModules("DOLORES-COMPUTE-BASEBALLHAT", "I Compute, Therefore I Am Baseball Hat", 29, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModules("BUBBLES-GUMBALL-BASEBALLHAT", "A Gumball for Your Thoughts Baseball Hat", 29, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModules("REX-MICROCONTROLLERS-BASEBALLHAT", "Great Microcontrollers Think Alike Baseball Hat", 29, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModules("DOLORES-COMPUTE-MUG", "I Compute, Therefore I Am Mug", 16, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModules("DOLORES-COMPUTE-TSHIRT", "I Compute, Therefore I Am T-shirt", 26, "bubbles-gumball-apron-black.jpg"));
            AddProduct(new ProductModules("REX-MICROCONTROLLERS-TSHIRT", "Great Microcontrollers Think Alike T-shirt", 26, "bubbles-gumball-apron-black.jpg"));
        }
        private void AddProduct(ProductModules product)
        {
            if (!Products.Any(p => p.Sku == product.Sku))
            {
                Products.Add(product);
            }

        }
    }
}
