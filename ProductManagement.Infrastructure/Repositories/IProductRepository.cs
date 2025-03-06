using System.Collections.Generic;
using ProductManagement.Domain.Models;

namespace ProductManagement.Infrastructure.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(int productId);
    void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int productId);
}