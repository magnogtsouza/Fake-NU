using Microsoft.Extensions.Logging;

namespace Fake_NU;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("circular_std_bold.otf", "circular_std_bold");
                fonts.AddFont("circular_std_book.otf", "circular_std_book");
                fonts.AddFont("graphik_medium.otf", "graphik_medium");
                fonts.AddFont("graphik_regular.otf", "graphik_regular");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
