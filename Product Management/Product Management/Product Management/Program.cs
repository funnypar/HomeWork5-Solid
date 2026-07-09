using Microsoft.Extensions.DependencyInjection;
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

            var services = new ServiceCollection();

            switch (choice)
            {
                case "1":
                    services.AddTransient<IProductDataSource, DatabaseDataSource>();
                    break;

                case "2":
                    services.AddTransient<IProductDataSource, ApiDataSource>();
                    break;

                case "3":
                    services.AddTransient<IProductDataSource, FileDataSource>();
                    break;

                default:
                    throw new Exception("Invalid choice.");
            }

            services.AddTransient<ProductViewerService>();

            ServiceProvider provider = services.BuildServiceProvider();

            ProductViewerService viewer = provider.GetRequiredService<ProductViewerService>();

            viewer.ShowProducts();
        }
    }
}

