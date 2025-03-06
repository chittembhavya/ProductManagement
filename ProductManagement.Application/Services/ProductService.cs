using System.Collections.Generic;
using ProductManagement.Application.Interfaces;
using ProductManagement.Domain.Models;
using ProductManagement.Infrastructure.Repositories;

namespace ProductManagement.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _productRepository.GetAllProducts();
    }

    public Product GetProductById(int productId)
    {
        return _productRepository.GetProductById(productId);
    }

    public void AddProduct(Product product)
    {
        _productRepository.AddProduct(product);
    }

    public void UpdateProduct(Product product)
    {
        _productRepository.UpdateProduct(product);
    }

    public void DeleteProduct(int productId)
    {
        _productRepository.DeleteProduct(productId);
    }
}