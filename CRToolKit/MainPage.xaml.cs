namespace CRToolKit;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		
        /*
        Task.Run(async () =>
        {
            await Task.Delay(2000);
        }).Wait();
		*/
		
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    void Theme_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
		if (Application.Current.UserAppTheme == AppTheme.Dark)
		{
			Application.Current.UserAppTheme = AppTheme.Light;

        }
		else
		{
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }
}


