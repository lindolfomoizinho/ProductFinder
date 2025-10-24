using ProductFinder.Model.Domain;

namespace ProductFinder.Model.Interfaces;

public interface IProductRepository
{
    Task<List<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(string id);
    Task CreateAsync(Product produto);
    Task UpdateAsync(string id, Product produto);
    Task DeleteAsync(string id);
}