using Microsoft.EntityFrameworkCore;
using SmartStoreNetCore.AppData.Interfaces;
using SmartStoreNetCore.AppData.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartStoreNetCore.AppData.Repository
{
    public class ProductRepository : IAllProducts
    {
        private readonly AppDBContent appDBContent;

        public ProductRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
                }
        public IEnumerable<Product> Products => appDBContent.Product.Include(p => p.Category);

        public IEnumerable<Product> GetFavProduct => appDBContent.Product.Where(f => f.IsFavourite).Include(p => p.Category);

        public Product GetObjectProduct(int ProductId) => appDBContent.Product.FirstOrDefault(i => i.Id == ProductId);



    }
}
