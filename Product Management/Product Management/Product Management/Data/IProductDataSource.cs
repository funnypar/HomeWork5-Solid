using Product_Management.Models;

namespace Product_Management.Data
{
    public interface IProductDataSource
    {
        List<Product> GetProducts();
    }
}
