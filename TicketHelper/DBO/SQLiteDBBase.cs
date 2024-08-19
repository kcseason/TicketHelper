using SQLite;
using TicketHelper.Model;

namespace TicketHelper.DBO
{
    internal class SQLiteDBBase<T> where T : ModelBase, new()
    {
        private static SQLiteAsyncConnection _connection;
        public static SQLiteAsyncConnection Connection
        {
            get
            {
                if (_connection == null)
                    _connection = new SQLiteAsyncConnection(SQLiteDBConfig.DBPath, SQLiteDBConfig.Flags);

                return _connection;
            }
        }
        public string GetDBFilePath() => Connection.DatabasePath;

        public int GetLibVersionNO() => Connection.LibVersionNumber;

        public string GetDateTimeStringFormat() => Connection.DateTimeStringFormat;

        public List<TableMapping> GetTableMappings() => Connection.TableMappings.ToList();

        public int Insert<T>(T t) => Connection.InsertAsync(t).Result;

        public int Insert<T>(List<T> list) => Connection.InsertAllAsync(list, true).Result;

        public int Delete(T t) => Connection.DeleteAsync<T>(t.Id).Result;

        public int DeleteAll() => Connection.DeleteAllAsync<T>().Result;

        public int Update<T>(T t) => Connection.UpdateAsync(t).Result;

        public int Update<T>(List<T> list) => Connection.UpdateAllAsync(list, true).Result;

        public void CreateTable() => Connection.CreateTableAsync<T>();

        public void DropTable() => Connection.DropTableAsync<T>();

        //public List<T> QueryByWhere(T t, string sql, params object[] objs) => Connection.QueryAsync<T>(sql, objs);

        public List<T> QueryTable() => new SQLiteConnection(SQLiteDBConfig.DBPath).Table<T>().ToList();

    }
}
