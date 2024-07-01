// Services/ProductService.cs
using Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>();
        private List<Category> categories = new List<Category>();

        public int GetProductCount()
        {
            return products.Count;
        }

        public Product FindProductByName(string name)
        {
            return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public decimal GetAveragePrice()
        {
            if (products.Count == 0) return 0;
            return products.Average(p => p.Price);
        }

        public void ReorderProductsByDate()
        {
            products = products.OrderBy(p => p.CreatedDate).ToList();
        }

        public List<Product> GetProductsByCategoryName(string categoryName)
        {
            return products.Where(p => p.Category != null && p.Category.Name.Equals(categoryName, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Category> GetAllCategories()
        {
            return categories;
        }

        public List<Product> GetProductsByCategoryId(int categoryId)
        {
            return products.Where(p => p.Category != null && p.Category.Id == categoryId).ToList();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void AddCategory(Category category)
        {
            categories.Add(category);
        }
    }
}
