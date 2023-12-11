using System.Data.SqlClient;

namespace Domain
{
    public class DatabaseOptions
    {
#if DEBUG
        public const string DatabaseConnectionString = @"Data Source=127.0.0.1;Initial Catalog=PostMaker;Persist Security Info=True;User ID=sqlserver;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;Trusted_Connection=True";
        //public const string DatabaseConnectionString = @"Data Source = 35.239.171.79;Initial Catalog=PostMaker;User id=sqlserver;Password=AlH4tmr35f0;MultipleActiveResultSets=True";

#endif

#if RELEASE
        public const string DatabaseConnectionString = @"Data Source = tcp:lab3pad.database.windows.net;Initial Catalog=PostMakerV2;User id=sqlserver;Password=AlH4tmr35f0;MultipleActiveResultSets=True";
#endif
    }
}
