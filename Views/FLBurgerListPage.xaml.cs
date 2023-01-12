using FLAppBurger.Models;
namespace FLAppBurger.Views;
public partial class FLBurgerListPage : ContentPage
{
    public event EventHandler AddBurger;
    public FLBurgerListPage()
    {
        InitializeComponent();
        List<FLBurger> flburger = App.FLBurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = flburger;
        MessagingCenter.Subscribe<FLBurgerItemPage>(this, "itemAdded", (sender) => OnUpdate(sender, EventArgs.Empty));
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(FLBurgerItemPage));
    }

    private void OnUpdate(object sender, EventArgs e)
    {
        //fetch new items and update the Burgers property
        List<FLBurger> newBurgers = App.FLBurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
        AddBurger?.Invoke(this, EventArgs.Empty);
    }

    private void OnUpdateButtonClicked(object sender, EventArgs e)
    {
        OnUpdate(sender, e);
    }
}