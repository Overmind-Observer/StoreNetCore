using System;
using System.Collections.Generic;
using SmartStoreNetCore.AppData.Interfaces;
using SmartStoreNetCore.AppData.Models;

namespace SmartStoreNetCore.AppData.Mocks
{
    public class MockCategory : IProductCategories
    {
        public IEnumerable<Category> AllCategories => throw new NotImplementedException();
    }
}
