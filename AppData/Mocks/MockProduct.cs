using SmartStoreNetCore.AppData.Interfaces;
using SmartStoreNetCore.AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartStoreNetCore.AppData.Mocks
{
    public class MockProduct : IAllProducts
    {
        private readonly IProductCategories _categoryProduct = new MockCategory();

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product> {
                new Product 
                {
                      Name = "Tesla 3",
                      ShortDesc = "",
                      LongDesc = "",
                      Img = "",
                      Price = 45000,
                      IsFavourite = true,
                      Available = true,
                      Category = _categoryProduct.AllCategories.First(),
                },
                new Product
                {
                      Name = "Tesla 3",
                      ShortDesc = "",
                      LongDesc = "",
                      Img = "",
                      Price = 45000,
                      IsFavourite = true,
                      Available = true,
                      Category = _categoryProduct.AllCategories.First(),
                },
                  new Product
                  {
                      Name = "Tesla 3",
                      ShortDesc = "",
                      LongDesc = "",
                      Img = "",
                      Price = 45000,
                      IsFavourite = true,
                      Available = true,
                      Category = _categoryProduct.AllCategories.First(),

                  }
                };
            }
        }

        public IEnumerable<Product> GetFavProduct { get; set; }

        public IEnumerable<Product> Product => throw new NotImplementedException();

        public Product GetObjectProduct(int ProductId)
        {
            throw new NotImplementedException();
        }
    }


}
