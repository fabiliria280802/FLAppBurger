using FLAppBurger.Models;
namespace FLAppBurger.Views;
public partial class FLBurgerListPage : ContentPage
{
    public event EventHandler AddBurger;
    public FLBurgerListPage()
    {
        InitializeComponent();
        BindingContext= this;
        //List<FLBurger> flburger = App.FLBurgerRepo.GetAllBurgers();
        //burgerList.ItemsSource = flburger;
        //MessagingCenter.Subscribe<FLBurgerItemPage>(this, "itemAdded", (sender) => OnUpdate(sender, EventArgs.Empty));
    }
    //async void OnItemAdded(object sender, EventArgs e) ya no es necesario
    void OnItemAdded(object sender, EventArgs e)
    {
        //await 
        Shell.Current.GoToAsync(nameof(FLBurgerItemPage), true, new Dictionary<string, object> 
        { 
            ["Item"] = new FLBurger()
        });
    }

    private void OnUpdate(object sender, EventArgs e)
    {
        //fetch new items and update the Burgers property
        List<FLBurger> newBurgers = App.FLBurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
        //AddBurger?.Invoke(this, EventArgs.Empty);
    }

    private void OnUpdateButtonClicked(object sender, EventArgs e)
    {
        OnUpdate(sender, e);
    }

    private void burgerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}