using Core3Sqlite.Models;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Core3Sqlite.DataContext
{
    public class ConnectData
    {
        public SqliteConnection connectDb;
        public ConnectData(IOptions<ModelAppSettings> appSettigs)
        {
            connectDb = new SqliteConnection(appSettigs.Value.ConnectionString);
        }
    }
}