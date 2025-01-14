using CommunityToolkit.Mvvm.ComponentModel;


namespace VehicleListingApp.Maui.ViewModels
    {
        /// <summary>
        /// Serves as the base view model for all view models in the application.
        /// Provides common properties and functionality for derived view models.
        /// </summary>
        public partial class BaseViewModel : ObservableObject
        {
#pragma warning disable MVVMTK0045
            /// <summary>
            /// Gets or sets the title of the view model.
            /// This property is observable and notifies changes to its value.
            /// </summary>
            [ObservableProperty] private string _title = String.Empty;
#pragma warning restore MVVMTK0045

#pragma warning disable MVVMTK0045
            /// <summary>
            /// Gets or sets a value indicating whether the view model is currently loading.
            /// This property is observable and notifies changes to its value.
            /// </summary>
            [ObservableProperty] [NotifyPropertyChangedFor(nameof(IsNotLoading))]
            private bool _isLoading;
#pragma warning restore MVVMTK0045

            /// <summary>
            /// Gets a value indicating whether the view model is not loading.
            /// This is a computed property that returns the negation of <see cref="_isLoading"/>.
            /// </summary>
#pragma warning disable MVVMTK0034
            public bool IsNotLoading => !_isLoading;
#pragma warning restore MVVMTK0034
        }
    }