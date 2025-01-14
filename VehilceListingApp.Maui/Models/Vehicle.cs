namespace CarListingApp.Maui.Models;

public class Vehicle : BaseEntity
{
    public string Name { get; set; }
    public string Vin { get; set; }
    public Guid? CarMakeId { get; set; }
    public VehicleMake? CarMake { get; set; }
}