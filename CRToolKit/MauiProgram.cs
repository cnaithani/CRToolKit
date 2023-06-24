using Microsoft.Extensions.Logging;

namespace CRToolKit;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		var app =  builder.Build();
		/*
        Task.Run(async () =>
        {
            await Task.Delay(4000);
        }).Wait();
		*/
		return app;
    }
}

