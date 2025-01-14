using VehicleListingApp.Maui.ViewModels;

namespace VehicleListingApp.Maui
{
    public partial class MainPage
    {
        public MainPage(VehicleListViewModel vehicleListViewModel)
        {
            InitializeComponent();
            BindingContext = vehicleListViewModel;
        }
    }

}
