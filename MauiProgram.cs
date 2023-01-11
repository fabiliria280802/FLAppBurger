using FLAppBurger.Data;

namespace FLAppBurger;

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
        // TODO: Add statements for adding PersonRepository as a singleton
        string dbPath = FLFileAccessHelper.GetLocalFilePath("people.db3");
        builder.Services.AddSingleton<FLBurgerDatabase>(s => ActivatorUtilities.CreateInstance<FLBurgerDatabase>(s, dbPath));
        return builder.Build();
    }
}
