using SmartStoreNetCore.AppData.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartStoreNetCore.AppData
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            // Check if category already exist
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Product.Any())
            {
                content.AddRange(
                new Product
                {
                    Name = "Tesla 3",
                    ShortDesc = "",
                    LongDesc = "",
                    Img = "",
                    Price = 45000,
                    IsFavourite = true,
                    Available = true,
                    Category = Categories["Laptop"]
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
                    Category = Categories["Laptop"]
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
                    Category = Categories["Desctop"]
                }
                );
            }
            content.SaveChanges();
        }
        // add into a DB categories
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null) 
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Laptop", desc = "Portable laptop"},
                        new Category {categoryName = "Desctop", desc = "Personal computers etc."}
                    };

                    category = new Dictionary<string, Category>();

                    foreach (Category element in list) category.Add(element.categoryName, element);
                }
                return category;
            }
        }
    }
}
