using FLAppBurger.Views;

namespace FLAppBurger;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(FLBurgerItemPage), typeof(FLBurgerItemPage));
    }
}
