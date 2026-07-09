using Product_Management.Models;

namespace Product_Management.Data
{
    public class FileDataSource : IProductDataSource
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
        {
            new Product("Keyboard", 70),
            new Product("Monitor", 300)
        };
        }
    }
}
