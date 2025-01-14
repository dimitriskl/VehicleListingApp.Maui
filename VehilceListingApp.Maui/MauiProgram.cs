using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace CarListingApp.Maui
{
    public static class MauiProgram
    {
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
