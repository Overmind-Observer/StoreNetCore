using System.Collections.Generic;
using SmartStoreNetCore.AppData.Models;


namespace SmartStoreNetCore.AppData.Interfaces
{
    public interface IProductCategories
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
