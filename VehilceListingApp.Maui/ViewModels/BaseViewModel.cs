using CommunityToolkit.Mvvm.ComponentModel;

namespace VehicleListingApp.Maui.ViewModels
{
    namespace VehicleListingApp.Maui.ViewModels
    {
        /// <summary>
        /// Serves as the base view model for all view models in the application.
        /// Provides common properties and functionality for derived view models.
        /// </summary>
        public partial class BaseViewModel : ObservableObject
    {
        /// <summary>
        /// Gets or sets the title of the view model.
        /// This property is observable and notifies changes to its value.
        /// </summary>
        [ObservableProperty] private string _title;

        /// <summary>
        /// Gets or sets a value indicating whether the view model is currently loading.
        /// This property is observable and notifies changes to its value.
        /// </summary>
        [ObservableProperty] [NotifyPropertyChangedFor(nameof(IsNotLoading))]
        private bool _isLoading;

        /// <summary>
        /// Gets a value indicating whether the view model is not loading.
        /// This is a computed property that returns the negation of <see cref="_isLoading"/>.
        /// </summary>
        public bool IsNotLoading => !_isLoading;
    }
}
}