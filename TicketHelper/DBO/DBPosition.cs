using SQLite;
using TicketHelper.Entity;

namespace TicketHelper.DBO
{
    internal class DBPosition
    {
        private static List<Position> _PositionList = [];
        public static List<Position> PositionList
        {
            get
            {
                if (_PositionList != null && _PositionList.Count > 0)
                    return _PositionList;
                else
                {
                    return GetAllPosition();
                }
            }
        }

        private static string dbPath = "ticket.db";
        private static string dataInitPath = "Data\\PositionInitData.txt";

        public static void DataInit()
        {
            DeleteAll();

            var path = Path.Combine(Directory.GetCurrentDirectory(), dataInitPath);
            var lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                // 处理每行的逻辑
                Add(new Position { PositionName = line });
            }
        }
        public static void Add(Position position)
        {
            using var conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Position>();
            conn.Insert(position);
        }

        public static void Delete(Position position)
        {
            using var conn = new SQLiteConnection(dbPath);
            conn.Delete<Position>(position.Id);
        }

        public static void DeleteAll()
        {
            using var conn = new SQLiteConnection(dbPath);
            conn.DeleteAll<Position>();
        }
        public static void Update(Position position)
        {
            using var conn = new SQLiteConnection(dbPath);
            conn.Update(position);
        }

        public static List<Position> GetAllPosition()
        {
            using (var db = new SQLiteConnection(dbPath))
            {
                // 查询所有Position记录
                if (CheckIfTableExists(db, "Position"))
                    return db.Table<Position>().ToList();
                else
                    return new List<Position>();
            }
        }

        private static bool CheckIfTableExists(SQLiteConnection conn, string tableName)
        {
            try
            {
                var cmd = new SQLiteCommand(conn);
                cmd.CommandText = $"SELECT count(*) FROM sqlite_master WHERE type='table' AND name='{tableName}';";
                object result = cmd.ExecuteScalar<Int32>();
                int resultCount = Convert.ToInt32(result);
                if (resultCount > 0)
                    return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
    }
}
