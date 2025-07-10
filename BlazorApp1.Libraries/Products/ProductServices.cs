using BlazorApp1.Libraries.Products.Module;
using BlazorApp1.Libraries.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.Products
{
    public class ProductServices : IProductServices
    {
        private readonly IStorageServices _storageServices;
        public ProductServices(IStorageServices storageServices)
        {
            this._storageServices = storageServices;
        }

        public IStorageServices StorageServices { get; }

        public IList<ProductModules> GetAll()
        {
            return _storageServices.Products.ToList();
        }

        public ProductModules? GetProduct(string sku)
        {
            return _storageServices.Products.FirstOrDefault(p => p.Sku == sku);
        }

        public ProductModules? GetProductBySlug(string slug)
        {
            return _storageServices.Products.FirstOrDefault(p => p.Slug == slug);
        }
    }
}
