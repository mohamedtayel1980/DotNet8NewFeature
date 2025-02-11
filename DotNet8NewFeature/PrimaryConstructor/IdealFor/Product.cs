using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.IdealFor
{
    //  1. Simple Data-Holder Class
    public class Product(string Name, decimal Price)
    {
        public string GetInfo() => $"Product: {Name}, Price: {Price:C}";
    }

    //  2. Immutable Configuration Model
    public class AppConfig(string DatabaseUrl, int MaxConnections)
    {
        public void DisplayConfig() =>
            Console.WriteLine($"DB: {DatabaseUrl}, Max Connections: {MaxConnections}");
    }

    // 3. DTO (Data Transfer Object)
    public class UserDto(string Name, string Email)
    {
        public void PrintDetails() => Console.WriteLine($"User: {Name}, Email: {Email}");
    }

    //  4. Lightweight Class with Minimal Properties
    public class Coordinate(double Latitude, double Longitude)
    {
        public string GetLocation() => $"Lat: {Latitude}, Long: {Longitude}";
    }
}
