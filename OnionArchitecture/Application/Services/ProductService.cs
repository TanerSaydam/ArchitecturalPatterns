using Application.DTOs;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services;

public sealed class ProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task AddAsync(ProductDto request, CancellationToken cancellationToken = default)
    {
        //İş Kuralları
        Product product = new()
        {
            Id = request.Id,
            Name = request.Name,
            Price = request.Price
        };

        await _productRepository.AddAsync(product, cancellationToken);
    }

    public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _productRepository.GetAllAsync(cancellationToken);
    }
}