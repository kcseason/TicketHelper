namespace TicketHelper.DBO
{
    internal class SQLiteDBConfig
    {
        public const string DBFileName = "ticket.db";

        public static string DBPath => Path.Combine(Directory.GetCurrentDirectory(), DBFileName);

        internal static readonly SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.NoMutex |
            SQLite.SQLiteOpenFlags.SharedCache |
             SQLite.SQLiteOpenFlags.ProtectionNone;
    }
}
