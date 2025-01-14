namespace VehicleListingApp.Maui.Models;

/// <summary>
/// Represents a vehicle make, which serves as a category or brand for vehicles.
/// </summary>
public class VehicleMake : BaseEntity

{
   public VehicleMake(string name)
   {
      Name = name;
   }

   /// <summary>
   /// Gets or sets the name of the vehicle make.
   /// </summary>
   public string Name { get; set; }

   /// <summary>
   /// Gets or sets the list of vehicles associated with this vehicle make.
   /// </summary>
   public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}