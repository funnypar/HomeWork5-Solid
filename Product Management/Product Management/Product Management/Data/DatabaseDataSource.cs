using Product_Management.Models;

namespace Product_Management.Data
{
    public class DatabaseDataSource : IProductDataSource
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
        {
            new Product("Laptop", 1500),
            new Product("Mouse", 30)
        };
        }
    }
}
