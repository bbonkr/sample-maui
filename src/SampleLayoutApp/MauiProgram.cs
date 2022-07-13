using SampleLayoutApp.ViewModels;
using SampleLayoutApp.Views;

namespace SampleLayoutApp;

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

        // ViewModels
        builder.Services.AddSingleton<LayoutsViewModel>();
        builder.Services.AddSingleton<FlexLayoutViewModel>();

        //Views
        builder.Services.AddSingleton<LayoutsPage>();
        builder.Services.AddSingleton<FlexLayoutPage>();

        return builder.Build();
    }
}
