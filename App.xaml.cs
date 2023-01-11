using FLAppBurger.Data;

namespace FLAppBurger;

public partial class App : Application
{
    public static FLBurgerDatabase FLBurgerRepo { get; private set; }
    public App(FLBurgerDatabase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();
        FLBurgerRepo = repo;
    }
}

