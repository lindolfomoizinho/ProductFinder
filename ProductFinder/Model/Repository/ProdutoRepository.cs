using MongoFramework.Linq;
using ProductFinder.Model.Data;
using ProductFinder.Model.Domain;
using ProductFinder.Model.Interfaces;

namespace ProductFinder.Model.Repository;

public class ProductRepository : IProductRepository
{
    private readonly ProductFinderContext _context;
    
    public ProductRepository(ProductFinderContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> GetByIdAsync(string id)
    {
        return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task CreateAsync(Product produto)
    {
        _context.Products.Add(produto);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(string id, Product product)
    {
        product.Id = id;
        _context.Products.Update(product);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(string id)
    {
        var produto = await GetByIdAsync(id);
        if (produto != null)
        {
            _context.Products.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}