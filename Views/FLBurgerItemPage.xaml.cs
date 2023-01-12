using FLAppBurger.Data;
using FLAppBurger.Models;

namespace FLAppBurger.Views;

public partial class FLBurgerItemPage : ContentPage
{
    FLBurger Item = new FLBurger();
    bool _flag;
    public FLBurgerItemPage()
    {
        InitializeComponent();
    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
        Item.Name = nameB.Text;
        Item.Description = descB.Text;
        Item.WithExtraCheese = _flag;
        App.FLBurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("///FLBurgerListPage");
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }
}