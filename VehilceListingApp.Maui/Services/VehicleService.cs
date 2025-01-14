using VehicleListingApp.Maui.Models;

namespace VehicleListingApp.Maui.Services
{
    public class VehicleService
    {
        public List<Vehicle> GetVehicles()
        {
            return new List<Vehicle>()
            {
                new Vehicle()
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Name = "Ford",
                    Vin = "1234567890"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Name = "Toyota",
                    Vin = "9876543210"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Name = "Chevrolet",
                    Vin = "4567891230"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    Name = "Honda",
                    Vin = "7890123456"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    Name = "Tesla",
                    Vin = "5432167890"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
                    Name = "BMW",
                    Vin = "6789012345"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
                    Name = "Mercedes-Benz",
                    Vin = "8901234567"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    Name = "Nissan",
                    Vin = "2109876543"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                    Name = "Hyundai",
                    Vin = "3210987654"
                },
                new Vehicle()
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    Name = "Kia",
                    Vin = "6543210987"
                },
            };
        }
    }
}