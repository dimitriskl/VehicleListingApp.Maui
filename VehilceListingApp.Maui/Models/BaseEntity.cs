namespace VehicleListingApp.Maui.Models
{
    /// <summary>
    /// Serves as the base class for all entities in the application, providing a unique identifier.
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        /// <remarks>
        /// This property serves as the primary key for the entity and ensures that each entity instance
        /// can be uniquely identified within the application.
        /// </remarks>
        public Guid Id { get; set; }
    }
}