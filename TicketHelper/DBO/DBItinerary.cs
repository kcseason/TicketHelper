using SQLite;
using TicketHelper.Entity;

namespace TicketHelper.DBO
{
    internal class DBItinerary
    {
        private static string dbPath = "ticket.db";
        public static void Add(Itinerary itinerary)
        {
            using var conn = new SQLiteConnection(dbPath);
            conn.CreateTable<Itinerary>();
            conn.Insert(itinerary);
        }

        public static void Delete(Itinerary itinerary)
        {
            using var conn = new SQLiteConnection(dbPath);
            conn.Delete<Itinerary>(itinerary.Id);
        }

        public static void Update(Itinerary itinerary)
        {
            using var conn = new SQLiteConnection(dbPath);
            conn.Update(itinerary);
        }

        public static List<Itinerary> GetAllItinerary()
        {
            using (var db = new SQLiteConnection(dbPath))
            {
                // 查询所有Itinerary记录
                if (CheckIfTableExists(db, "Itinerary"))
                    return db.Table<Itinerary>().ToList();
                else
                    return new List<Itinerary>();
            }
        }

        public static List<Itinerary> GetAllItinerary(params object[] args)
        {
            using (var db = new SQLiteConnection(dbPath))
            {
                // 查询所有Itinerary记录
                if (CheckIfTableExists(db, "Itinerary"))
                {
                    var objs = new List<Object>();
                    var sql = @"SELECT * FROM Itinerary ";
                    var whereStr = @" WHERE DateTime>=? AND  DateTime<=?";
                    if (!args[2].ToString().Equals("全部"))
                    {
                        whereStr += @"AND LocationName=?";
                        objs.Add(args[2]);
                    }
                    if (!args[3].ToString().Equals("全部"))
                    {
                        whereStr += @"AND CompanyType=?";
                        objs.Add(args[3]);
                    }
                    if (!args[4].ToString().Equals("全部"))
                    {
                        whereStr += @"AND TicketType=?";
                        objs.Add(args[4]);
                    }
                    whereStr += "ORDER BY Id";
                    sql = sql + whereStr;

                    return db.Query<Itinerary>(sql, args);
                }
                else
                    return new List<Itinerary>();
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
