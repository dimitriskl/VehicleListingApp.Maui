namespace CarListingApp.Maui.Models;

public class VehicleMake : BaseEntity
{
    public string Name { get; set; }
    public List<Vehicle> Cars { get; set; }
}