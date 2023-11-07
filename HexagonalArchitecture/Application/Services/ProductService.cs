using Application.Models;
using Application.Ports;
using Domain.Entities;

namespace Application.Services;

public sealed class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task Add(ProductModel request, CancellationToken cancellationToken = default)
    {
        Product product = new()
        {
            Price = request.Price,
            Id = request.Id,
            Name = request.Name
        };
        //iş kuralları
        await _productRepository.AddAsync(product, cancellationToken);
    }

    public async Task<List<Product>> GetAll(CancellationToken cancellationToken = default)
    {
        return await _productRepository.GetAllAsync(cancellationToken);
    }
}