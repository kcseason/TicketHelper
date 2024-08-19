using TicketHelper.DBO;
using TicketHelper.Model;

namespace TicketHelper.Handler
{
    internal class PositionHandler
    {
        public static void DataInit()
        {
            var db = new SQLiteDBPosition<Position>();
            db.DeleteAll();

            string dataInitPath = "Data\\PositionInitData.txt";
            var path = Path.Combine(Directory.GetCurrentDirectory(), dataInitPath);
            var lines = File.ReadAllLines(path);
            foreach (string line in lines)
                // 处理每行的逻辑
                db.Insert(new Position { PositionName = line });
        }


    }
}
