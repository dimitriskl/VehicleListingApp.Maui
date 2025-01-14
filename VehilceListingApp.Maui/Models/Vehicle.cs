namespace VehicleListingApp.Maui.Models
{
    public class Vehicle : BaseEntity
    {
        public string Name { get; set; }
        public string Vin { get; set; }
        public Guid? VehicleMakeId { get; set; }
        public VehicleMake? VehicleMake { get; set; }
    }
}