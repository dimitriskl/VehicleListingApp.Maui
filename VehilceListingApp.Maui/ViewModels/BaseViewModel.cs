using CommunityToolkit.Mvvm.ComponentModel;

namespace CarListingApp.Maui.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty] private string title;

        [ObservableProperty] [NotifyPropertyChangedFor(nameof(isNotLoading))]
        private bool isLoading;

        public bool isNotLoading => !isLoading;
    }
}