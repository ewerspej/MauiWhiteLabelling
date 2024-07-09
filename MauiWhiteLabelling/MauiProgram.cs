namespace MauiWhiteLabelling;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontRegular.ttf", "FontRegular");
				fonts.AddFont("FontSemibold.ttf", "FontSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
