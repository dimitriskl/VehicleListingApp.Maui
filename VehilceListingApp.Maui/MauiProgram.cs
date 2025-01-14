using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using VehicleListingApp.Maui.Services;
using VehicleListingApp.Maui.ViewModels;

namespace VehicleListingApp.Maui
{
    /// <summary>
    /// Provides the entry point for configuring and building the application.
    /// </summary>
    public static class MauiProgram
        {
            /// <summary>
            /// Configures and builds the Maui application.
            /// </summary>
            /// <returns>
            /// A fully configured <see cref="MauiApp"/> instance.
            /// </returns>
            public static MauiApp CreateMauiApp()
            {
                var builder = MauiApp.CreateBuilder();
                builder
                    .UseMauiApp<App>()
                    .ConfigureSyncfusionCore()
                    .ConfigureFonts(fonts =>
                    {
                        fonts.AddFont("FontAwesomeRegular.otf", "FontAwesomeRegular");
                        fonts.AddFont("FontAwesomeSolid.otf", "FontAwesomeSolid");
                        fonts.AddFont("FontAwesomeBrands.otf", "FontAwesomeBrands");
                        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                        fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    });
                builder.Services.AddSingleton<VehicleService>();
                builder.Services.AddSingleton<VehicleListViewModel>();
                builder.Services.AddSingleton<MainPage>();
#if DEBUG
                builder.Logging.AddDebug();
#endif
                return builder.Build();
            }
        }
}


