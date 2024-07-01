using Homework.Models;
using Homework.Services;
using System;
using System.Collections.Generic;

namespace Homework.Controllers
{
    public class ProductController
    {
        private IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public void ShowAllProducts()
        {
            var products = productService.GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Category: {product.Category?.Name}");
            }
        }

        public void ShowProductCount()
        {
            Console.WriteLine($"Total Products: {productService.GetProductCount()}");
        }

        public void FindProductByName()
        {
            Console.Write("Enter product name to search: ");
            string name = Console.ReadLine();
            var product = productService.FindProductByName(name);
            if (product != null)
            {
                Console.WriteLine($"Found Product: {product.Name}, Price: {product.Price}, Category: {product.Category?.Name}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        public void ShowAveragePrice()
        {
            Console.WriteLine($"Average Price: {productService.GetAveragePrice()}");
        }

        public void ReorderProductsByDate()
        {
            productService.ReorderProductsByDate();
            Console.WriteLine("Products reordered by creation date.");
        }

        public void ShowProductsByCategoryName()
        {
            Console.Write("Enter category name: ");
            string categoryName = Console.ReadLine();
            var products = productService.GetProductsByCategoryName(categoryName);
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Category: {product.Category?.Name}");
            }
        }

        public void ShowAllCategories()
        {
            var categories = productService.GetAllCategories();
            foreach (var category in categories)
            {
                Console.WriteLine($"Category: {category.Name}");
            }
        }

        public void ShowProductsByCategoryId()
        {
            Console.Write("Enter category ID: ");
            if (int.TryParse(Console.ReadLine(), out int categoryId))
            {
                var products = productService.GetProductsByCategoryId(categoryId);
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}, Category: {product.Category?.Name}");
                }
            }
            else
            {
                Console.WriteLine("Invalid category ID.");
            }
        }
    }
}
