using Mde.OnlineServices.Flags.Services;
using Mde.OnlineServices.Flags.ViewModels;
using Microsoft.Extensions.Logging;

namespace Mde.OnlineServices.Flags
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<IFlagService, WebFlagService>();

            builder.Services.AddHttpClient(Constants.FlagsClientName,
                config => config.BaseAddress = new Uri(Constants.FlagsApiUrl));
#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
