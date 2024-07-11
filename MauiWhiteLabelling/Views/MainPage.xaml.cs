namespace MauiWhiteLabelling.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    
    private async void Button_OnClicked(object? sender, EventArgs e)
    {
#if DEFAULT_APP
        await DisplayAlert("Default App", "This is the default app", "OK");
#elif CLIENT_A
        await DisplayAlert("Client A", "This is client A", "OK");
#elif CLIENT_B
        await DisplayAlert("Client B", "This is client B", "OK");
#endif
    }
}
