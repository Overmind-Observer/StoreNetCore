using Microsoft.AspNetCore.Mvc;
using SmartStoreNetCore.AppData.Interfaces;
using SmartStoreNetCore.ViewModels;

namespace SmartStoreNetCore.Controllers
{
    public class ProductController : Controller
    {
        private readonly IAllProducts _allProducts;
        private readonly IProductCategories _allCategories;

        public ProductController(IAllProducts iAllProducts, IProductCategories iProductCategories)
        {
            _allProducts = iAllProducts;
            _allCategories = iProductCategories;
        }

        public object ProductListViewController { get; private set; }

        public ViewResult List()
        {
            ViewBag.Title = "Product page";
            ProductListViewModel obj = new ProductListViewModel();
            obj.allProducts = _allProducts.Products;
            obj.productCategory = "computers";
            return View(obj);
        }
    }
}
