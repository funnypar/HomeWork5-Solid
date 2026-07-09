using Product_Management.Data;

namespace Product_Management.Services
{
    public class ProductViewerService
    {
        private readonly IProductDataSource _dataSource;

        public ProductViewerServie(IProductDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void ShowProducts()
        {
            var products = _dataSource.GetProducts();

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - ${product.Price}");
            }
        }
    }
}
