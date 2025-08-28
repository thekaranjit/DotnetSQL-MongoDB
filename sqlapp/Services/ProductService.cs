
using sqlapp.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace sqlapp.Services
{

    // This service will interact with our Product data in the SQL database
    public class ProductService
    {
        private readonly IMongoCollection<Product> _productsCollection;

        public ProductService(IConfiguration configuration)
        {
            var mongoConnectionString = configuration["MongoDB:ConnectionString"];
            var mongoDatabase = configuration["MongoDB:Database"];
            var mongoCollection = configuration["MongoDB:Collection"];

            var client = new MongoClient(mongoConnectionString);
            var database = client.GetDatabase(mongoDatabase);
            _productsCollection = database.GetCollection<Product>(mongoCollection);
        }

        public List<Product> GetProducts()
        {
            return _productsCollection.Find(_ => true).ToList();
        }

    }
}

