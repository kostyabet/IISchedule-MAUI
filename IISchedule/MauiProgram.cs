using Microsoft.Extensions.Logging;
using Mopups.Hosting;

namespace IISchedule
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMopups()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("DinPro-400.ttf", "DinPro");
                    fonts.AddFont("DinPro-Bold.ttf", "DinPro-Bold");
                    fonts.AddFont("DinPro-Light.ttf", "DinPro-Light");
                    fonts.AddFont("DinPro-Bold_Italic.ttf", "DinPro-Bold-Italic");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
