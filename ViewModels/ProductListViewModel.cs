using SmartStoreNetCore.AppData.Models;
using System.Collections.Generic;

namespace SmartStoreNetCore.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> allProducts { get; set; }
        public string productCategory { get; set; }
    }
}
