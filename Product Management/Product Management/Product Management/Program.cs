using Product_Management.Data;
using Product_Management.Services;

namespace Product_Management
{
    internal class Program
    {
        static void Main()
        {
            // انتخاب منبع داده

            IProductDataSource dataSource = new DatabaseDataSource();

            // IProductDataSource dataSource = new ApiDataSource();

            // IProductDataSource dataSource = new FileDataSource();

            ProductViewerService viewer = new ProductViewerService(dataSource);

            viewer.ShowProducts();
        }
    }
}
