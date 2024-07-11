namespace MauiWhiteLabelling.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    
    private async void Button_OnClicked(object? sender, EventArgs e)
    {
#if DefaultApp
        await DisplayAlert("Default App", "This is the default app", "OK");
#elif ClientA
        await DisplayAlert("Client A", "This is client A", "OK");
#elif ClientB
        await DisplayAlert("Client B", "This is client B", "OK");
#endif
    }
}
