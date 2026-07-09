using Product_Management.Data;
using Product_Management.Services;

namespace Product_Management
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose data source:");
            Console.WriteLine("1- Database");
            Console.WriteLine("2- API");
            Console.WriteLine("3- File");

            string? choice = Console.ReadLine();

            string source = choice switch
            {
                "1" => "database",
                "2" => "api",
                "3" => "file",
                _ => throw new Exception("Invalid choice.")
            };

            IProductDataSource dataSource = DataSourceFactory.Create(source);

            ProductViewerService viewer = new ProductViewerService(dataSource);

            viewer.ShowProducts();
        }
    }
}

