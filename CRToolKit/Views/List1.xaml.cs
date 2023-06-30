using CRToolKit.Models;

namespace CRToolKit.Views;

public partial class List1 : ContentPage
{
	public List1VM currentVM;
	public List1()
	{
        InitializeComponent();       
    }

    protected override void OnAppearing()
    {
        currentVM = new List1VM();
        BindingContext = currentVM;
    }
}
