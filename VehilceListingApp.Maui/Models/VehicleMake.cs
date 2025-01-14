namespace VehicleListingApp.Maui.Models;

public class VehicleMake : BaseEntity
{
    public string Name { get; set; }
    public List<Vehicle> Vehicles { get; set; }
}