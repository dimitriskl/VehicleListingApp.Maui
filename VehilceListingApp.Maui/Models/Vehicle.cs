namespace VehicleListingApp.Maui.Models
{
    /// <summary>
    /// Represents a vehicle entity with properties such as name, VIN, and associated vehicle make.
    /// </summary>
    public class Vehicle : BaseEntity
    {
        public Vehicle(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the name of the vehicle.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the name of the vehicle.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Vehicle Identification Number (VIN) of the vehicle.
        /// The VIN is a unique code used to identify individual motor vehicles.
        /// </summary>
        public string? Vin { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the associated vehicle make.
        /// This property is nullable, indicating that a vehicle may not have an associated make.
        /// </summary>
        public Guid? VehicleMakeId { get; set; }

        /// <summary>
        /// Gets or sets the associated make of the vehicle.
        /// </summary>
        /// <remarks>
        /// This property represents the relationship between a vehicle and its make.
        /// It is nullable to account for cases where a vehicle may not have an associated make.
        /// </remarks>
        public VehicleMake? VehicleMake { get; set; }
    }
}
