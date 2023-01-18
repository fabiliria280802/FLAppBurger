using FLAppBurger.Data;
using FLAppBurger.Models;
using FLAppBurger.ViewModels;
namespace FLAppBurger.Views;
public partial class FLBurgerListPage : ContentPage
{
    //public event EventHandler AddBurger;
    public FLBurgerListPage()
    {
        InitializeComponent();
        BindingContext = this;
        //List<FLBurger> flburger = App.FLBurgerRepo.GetAllBurgers();
        //burgerList.ItemsSource = flburger;
        //MessagingCenter.Subscribe<FLBurgerItemPage>(this, "itemAdded", (sender) => OnUpdate(sender, EventArgs.Empty));
    }
    //async void OnItemAdded(object sender, EventArgs e) ya no es necesario
    public void OnItemAdded(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(FLBurgerItemPage)
        Shell.Current.GoToAsync(nameof(FLBurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new FLBurger()
        });
    }
    //Ya no se usa OnUpdate
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

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        List<FLBurger> newBurgers = App.FLBurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
        //base.OnNavigatedTo(args);
    }

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //Aqui falta codigo que tome el item seleccionado y lo pase a la pagina FLBurgerItemPage
        FLBurger burgers = e.CurrentSelection.FirstOrDefault() as FLBurger;
        if (burgers == null)
            return;
        Shell.Current.GoToAsync(nameof(FLBurgerItemPage), true, new Dictionary<string, object>
        {
            {"Item", burgers }
        });
        ((CollectionView)sender).SelectedItem = null;

        //Intentos de implementacion con viewmodels
        /*string previous = (e.PreviousSelection.FirstOrDefault() as FLBurger)?.Name;
        string current = (e.CurrentSelection.FirstOrDefault() as FLBurger)?.Name;
        var resp = new Dictionary<string, object>();
        resp.Add("flBurger", FLBurger);
        Shell.Current.GoToAsync(nameof(FLBurgerItemPage), resp);
        FLBurger fLBurger = (FLBurger)burgerList.ItemsSource;
        App.FLBurgerRepo.
        App.FLBurgerRepo.DeleteItem(fLBurger);
        Shell.Current.GoToAsync(FLBurgerItemPage);*/
    }
}