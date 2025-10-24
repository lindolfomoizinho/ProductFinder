using MongoFramework;
using ProductFinder.Model.Domain;

namespace ProductFinder.Model.Data;

public class ProductFinderContext : MongoDbContext
{
    public MongoDbSet<Product> Products { get; set; }
    
    public ProductFinderContext(IMongoDbConnection connection) : base(connection)
    {
    }
    
}