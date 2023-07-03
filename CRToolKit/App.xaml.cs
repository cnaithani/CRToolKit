using CRToolKit.Data;
using CRToolKit.Interfaces;

namespace CRToolKit;

public partial class App : Application
{
    static AppDatabase database;
    static bool isDatabaseInitialized = false;
    public App()
	{
		InitializeComponent();

        Application.Current.UserAppTheme = AppTheme.Dark;

        if (database == null)
        {
            InitiateDB().ConfigureAwait(false);
        }
        Task.Run(async () =>
        {
            await database.UpdateDatabase();
            isDatabaseInitialized = true;
        });

        MainPage = new AppShell();
    }
    public static  AppDatabase Database
    {
        get
        {
            if (database == null)
            {
                InitiateDB().ConfigureAwait(false);
            }
            return database;
        }
    }
    private static async Task InitiateDB()
    {
        if (database == null)
        {
            var commonDeviceHandler = App.Current.Handler.MauiContext.Services.GetServices<ICommonDeviceHelper>().FirstOrDefault();
            database = new AppDatabase(await commonDeviceHandler.GetDBFile());
        }
    }
    protected  override void OnStart()
    {
        base.OnStart();
        
    }
}

