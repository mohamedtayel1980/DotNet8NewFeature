namespace PrimaryConstructor.IdealFor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("✅ Ideal Use Cases for Primary Constructors\n");

            // 1. Simple Data-Holder Example
            var product = new Product("Laptop", 1500.99m);
            Console.WriteLine(product.GetInfo());

            // 2. Immutable Configuration Example
            var config = new AppConfig("https://mydb.com", 100);
            config.DisplayConfig();

            // 3. DTO Example
            var user = new UserDto("Mohamed", "mohamed@example.com");
            user.PrintDetails();

            // 4. Lightweight Class Example
            var location = new Coordinate(40.7128, -74.0060);
            Console.WriteLine(location.GetLocation());
        }
    }
}
