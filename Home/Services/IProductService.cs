// Services/IProductService.cs
using Homework.Models;
using System.Collections.Generic;

namespace Homework.Services
{
    public interface IProductService
    {
        int GetProductCount();
        Product FindProductByName(string name);
        List<Product> GetAllProducts();
        decimal GetAveragePrice();
        void ReorderProductsByDate();
        List<Product> GetProductsByCategoryName(string categoryName);
        List<Category> GetAllCategories();
        List<Product> GetProductsByCategoryId(int categoryId);
        void AddProduct(Product product);
        void AddCategory(Category category);
    }
}
