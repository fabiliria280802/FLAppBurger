using FLAppBurger.Data;
using FLAppBurger.Models;

namespace FLAppBurger.Views;

public partial class FLBurgerItemPage : ContentPage
{
    //FLBurger Item = new FLBurger();
    //bool _flag;

    public FLBurger Item
    {
        get => BindingContext as FLBurger;
        set => BindingContext = value;
    }
    public FLBurgerItemPage()
    {
        InitializeComponent();
        //BindingContext = Item;
    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
        //Item.Name = nameB.Text;
        //Item.Description = descB.Text;
        //Item.WithExtraCheese = _flag;
        App.FLBurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
        //MessagingCenter.Send(this, "itemAdded", true);
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        // _flag = e.Value;
    }
}