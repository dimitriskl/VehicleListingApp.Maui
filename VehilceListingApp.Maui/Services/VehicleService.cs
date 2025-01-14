using VehicleListingApp.Maui.Models;

namespace VehicleListingApp.Maui.Services
{
    public class VehicleService
    {
        /// <summary>
        /// Retrieves a list of predefined vehicles.
        /// </summary>
        /// <returns>A list of <see cref="Vehicle"/> objects, each representing a predefined vehicle with properties such as name, VIN, and unique identifier.</returns>
        public List<Vehicle> GetVehicles()
        {
            return new List<Vehicle>()
            {
                new Vehicle("Ford")
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),

                    Vin = "1234567890"
                },
                new Vehicle("Toyota")
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),

                    Vin = "9876543210"
                },
                new Vehicle("Chevrolet")
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Vin = "4567891230"
                },
                new Vehicle("Honda")
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),

                    Vin = "7890123456"
                },
                new Vehicle("Tesla")
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),

                    Vin = "5432167890"
                },
                new Vehicle("BMW")
                {
                    Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),

                    Vin = "6789012345"
                },
                new Vehicle("Mercedes-Benz")
                {
                    Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),

                    Vin = "8901234567"
                },
                new Vehicle("Nissan")
                {
                    Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
                    Vin = "2109876543"
                },
                new Vehicle("Hyundai")
                {
                    Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
                    Vin = "3210987654"
                },
                new Vehicle("Kia")
                {
                    Id = Guid.Parse("00000000-0000-0000-0000-000000000000"),
                    Vin = "6543210987"
                },
            };
        }

        /// <summary>
        /// Asynchronously retrieves a collection of vehicles.
        /// </summary>
        /// <returns>
        /// A task that represents the asynchronous operation. The task result contains an <see cref="IEnumerable{T}"/> of <see cref="Vehicle"/> objects.
        /// </returns>
        public async Task<IEnumerable<Vehicle>> GetVehiclesAsync()
        {
            return await Task.Run(GetVehicles);
        }
    }
}