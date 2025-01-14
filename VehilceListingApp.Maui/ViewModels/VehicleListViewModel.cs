using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using VehicleListingApp.Maui.Models;
using VehicleListingApp.Maui.Services;

namespace VehicleListingApp.Maui.ViewModels
{
    /// <summary>
    /// Represents the ViewModel for the vehicle list.
    /// </summary>
    public partial class VehicleListViewModel : BaseViewModel
    {
        /// <summary>
        /// Service to fetch vehicle data.
        /// </summary>
        private readonly VehicleService _vehicleService;

        /// <summary>
        /// Collection of vehicles to be displayed.
        /// </summary>
        public ObservableCollection<Vehicle> Vehicles { get; private set; } = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleListViewModel"/> class.
        /// </summary>
        /// <param name="vehicleService">The service used to retrieve vehicle data.</param>
        public VehicleListViewModel(VehicleService vehicleService)
        {
            Title = "Vehicle List";
            _vehicleService = vehicleService;
        }

#pragma warning disable MVVMTK0045
        [ObservableProperty] private bool _isRefreshing = true;
#pragma warning restore MVVMTK0045

        /// <summary>
        /// Command to load the list of vehicles asynchronously.
        /// </summary>
        /// <returns>A task representing the asynchronous operation.</returns>
        [RelayCommand]
        async Task LoadVehiclesAsync()
        {
            if (IsLoading)
            {
                return;
            }

            try
            {
                IsLoading = true;
                if (Vehicles.Any())
                {
                    Vehicles.Clear();
                }

                var vehicles = await _vehicleService.GetVehiclesAsync();
                foreach (var vehicle in vehicles)
                {
                    Vehicles.Add(vehicle);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to fetch vehicles: {e.Message}");
                await Shell.Current.DisplayAlert("Error", "Failed to retrieve list of vehicles", "Ok");
            }
            finally
            {
                IsRefreshing = false;
                IsLoading = false;
            }
        }
    }

}
