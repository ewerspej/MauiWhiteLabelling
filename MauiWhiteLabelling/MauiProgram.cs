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
                // In order to use custom fonts, we need to add the font files to the project and set the Build Action to MauiFont.
                // For white labelling to work, a simple trick to use different fonts per client is to add the font files using the exact same name in the client-specific folders and register them using the same alias,
                // This way, we can reference the font directly by its alias and the correct font file will be used depending on the client. This is not mandatory, the font family can also be defined in a style definition in the customer specific Styles.XAML file.
				fonts.AddFont("FontRegular.ttf", "FontRegular");
				fonts.AddFont("FontSemibold.ttf", "FontSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();
		builder.Services.AddSingleton<MainPage>();

		return builder.Build();
	}
}
