using Microsoft.EntityFrameworkCore;
using SmartStoreNetCore.AppData.Interfaces;
using SmartStoreNetCore.AppData.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartStoreNetCore.AppData.Repository
{
    public class CategoryRepository : IProductCategories
    {

        private readonly AppDBContent appDBContent;

        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
