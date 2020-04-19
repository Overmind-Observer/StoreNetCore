using System.Collections.Generic;
using SmartStoreNetCore.AppData.Models;

namespace SmartStoreNetCore.AppData.Interfaces
{
    public interface IAllProducts
    {
        IEnumerable<Product> Products { get; }
        IEnumerable<Product> GetFavProduct { get;}
        Product GetObjectProduct(int ProductId);
    }
}
