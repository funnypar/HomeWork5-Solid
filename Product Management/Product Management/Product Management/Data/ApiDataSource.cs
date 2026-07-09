using Product_Management.Models;

namespace Product_Management.Data
{
    public class ApiDataSource : IProductDataSource
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
        {
            new Product("Phone", 900),
            new Product("Headphone", 120)
        };
        }
    }
}
