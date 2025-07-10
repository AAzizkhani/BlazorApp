using BlazorApp1.Libraries.Products.Module;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Libraries.Storage
{
    public interface IStorageServices
    {
        IList<ProductModules> Products { get; }

    }
}
