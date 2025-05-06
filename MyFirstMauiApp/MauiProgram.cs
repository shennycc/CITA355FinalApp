using Microsoft.Extensions.Logging;
using MyFirstMauiApp.ViewModel;

namespace MyFirstMauiApp
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



            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<StudentInfo>();
            builder.Services.AddTransient<DetailViewModel>();


            return builder.Build();
        } 
    }
}
