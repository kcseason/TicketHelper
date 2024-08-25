using SQLite;
using TicketHelper.Model;

namespace TicketHelper.DBO
{
    internal class SQLiteDBBase<T> where T : ModelBase, new()
    {
        private static SQLiteConnection _connection;
        public static SQLiteConnection Connection
        {
            get
            {
                if (_connection == null)
                    _connection = new SQLiteConnection(SQLiteDBConfig.DBPath, SQLiteDBConfig.Flags);

                return _connection;
            }
        }

        public SQLiteDBBase()
        {
            if (!IsTableExists())
                CreateTable();
        }

        public string GetDBFilePath() => Connection.DatabasePath;

        public int GetLibVersionNO() => Connection.LibVersionNumber;

        public string GetDateTimeStringFormat() => Connection.DateTimeStringFormat;

        public List<TableMapping> GetTableMappings() => Connection.TableMappings.ToList();

        public int Insert<T>(T t) => Connection.Insert(t);

        public int Insert<T>(List<T> list) => Connection.InsertAll(list, true);

        public int Delete(T t) => Connection.Delete<T>(t.Id);
        public int DeleteList(List<T> list)
        {
            for (var i = 0; i < list.Count; i++)
                Delete(list[i]);

            return list.Count;
        }
        public int DeleteAll() => Connection.DeleteAll<T>();

        public int Update<T>(T t) => Connection.Update(t);

        public int Update<T>(List<T> list) => Connection.UpdateAll(list, true);

        public void CreateTable() => Connection.CreateTable<T>();

        public void DropTable() => Connection.DropTable<T>();

        public List<T> QueryTable(string sql, params object[] objs) => Connection.Query<T>(sql, objs).ToList();

        public List<T> QueryTable() => Connection.Table<T>().ToList();

        private bool IsTableExists()
        {
            try
            {
                var conn = new SQLiteConnection(SQLiteDBConfig.DBPath);
                var cmd = new SQLiteCommand(conn);
                cmd.CommandText = $"SELECT name FROM sqlite_master WHERE type='table' AND name='{nameof(T)}';";
                var result = cmd.ExecuteQuery<T>();

                return (result != null && result.Count > 0);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
