using FLAppBurger.Models;
namespace FLAppBurger.Views;
public partial class FLBurgerListPage : ContentPage
{
    public FLBurgerListPage()
    {
        InitializeComponent();
        List<FLBurger> burger = App.FLBurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(FLBurgerItemPage));
    }
}