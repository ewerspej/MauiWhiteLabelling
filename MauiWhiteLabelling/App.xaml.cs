using CommunityToolkit.Maui;

namespace MauiWhiteLabelling;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        UserAppTheme = AppTheme.Light;

		MainPage = new AppShell();
	}

    protected override void OnStart()
    {
        if (!Resources.TryGetValue("Primary", out var color) || color is not Color primaryColor)
        {
            return;
        }
        
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(primaryColor);
    }
}
