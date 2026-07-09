namespace Product_Management.Data
{
    public static class DataSourceFactory
    {
        public static IProductDataSource Create(string sourceType)
        {
            switch (sourceType.ToLower())
            {
                case "database":
                    return new DatabaseDataSource();

                case "api":
                    return new ApiDataSource();

                case "file":
                    return new FileDataSource();

                default:
                    throw new ArgumentException("Invalid data source.");
            }
        }
    }
}
