using System;
namespace CRToolKit.Data
{
    public class DatabaseUpdates
    {
        public const int LAST_DATABASE_VERSION = 9;
        public async Task UpdateDatabase()
        {
            int currentDbVersion = 0;
            currentDbVersion = await GetDatabaseVersion();

            if (currentDbVersion < LAST_DATABASE_VERSION)
            {
                int startUpgradingFrom = currentDbVersion + 1;
                switch (startUpgradingFrom)
                {
                    case 1: //starting version
                        goto case 2;
                    case 2:
                        UpgradeFrom1To2();
                        break;
                    default:
                        break;
                }
            }
        }
        private async Task<int> GetDatabaseVersion()
        {
            return await App.Database.database.ExecuteScalarAsync<int>("PRAGMA user_version");
        }
        private async Task<int> SetDatabaseToVersion(int version)
        {
            return await App.Database.database.ExecuteAsync("PRAGMA user_version =" + version.ToString());
        }
        internal void UpgradeFrom1To2()
        {
            //await App.Database.database.CreateTableAsync<ActivityDetail>();
        }
    }
}

