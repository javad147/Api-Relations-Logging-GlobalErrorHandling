// Program.cs
using Homework.Controllers;
using Homework.Models;
using Homework.Services;
using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductService();

            // Add sample data
            var category1 = new Category { Id = 1, Name = "Electronics", CreatedDate = DateTime.Now };
            var category2 = new Category { Id = 2, Name = "Books", CreatedDate = DateTime.Now };

            productService.AddCategory(category1);
            productService.AddCategory(category2);

            productService.AddProduct(new Product { Id = 1, Name = "Laptop", Price = 1000, CreatedDate = DateTime.Now.AddDays(-10), Category = category1 });
            productService.AddProduct(new Product { Id = 2, Name = "Smartphone", Price = 500, CreatedDate = DateTime.Now.AddDays(-5), Category = category1 });
            productService.AddProduct(new Product { Id = 3, Name = "Novel", Price = 20, CreatedDate = DateTime.Now.AddDays(-15), Category = category2 });

            var productController = new ProductController(productService);

            // Call methods to test functionality
            productController.ShowAllProducts();
            productController.ShowProductCount();
            productController.FindProductByName();
            productController.ShowAveragePrice();
            productController.ReorderProductsByDate();
            productController.ShowProductsByCategoryName();
            productController.ShowAllCategories();
            productController.ShowProductsByCategoryId();

            Console.ReadKey();
        }
    }
}
