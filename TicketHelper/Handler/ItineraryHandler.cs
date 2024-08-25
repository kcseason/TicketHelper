using TicketHelper.DBO;
using TicketHelper.Model;

namespace TicketHelper.Handler
{
    internal class ItineraryHandler
    {
        public static void DataInit()
        {
            InitTrainTicket();
            InitAirplaneTicket();
        }

        private static void InitTrainTicket()
        {
            var db = new SQLiteDBItinerary<Itinerary>();
            var list = db.QueryTableByTicketType("火车票");
            db.DeleteList(list);

            string dataInitPath = "DataInit\\TrainTicket.txt";
            var path = Path.Combine(Directory.GetCurrentDirectory(), dataInitPath);
            var lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                var arr = line.Split(',');
                // 处理每行的逻辑
                db.Insert(new Itinerary
                {
                    Start = arr[0],
                    End = arr[1],
                    Cost = Convert.ToDecimal(arr[2]),
                    CompanyType = arr[3],
                    TicketType = arr[4],
                    CityName = arr[5],
                    StartDate = Convert.ToDateTime(arr[6]),
                    EndDate = Convert.ToDateTime(arr[6]),
                    FeeType = arr[8],
                    HasTicket = arr[9],
                    HasDetail = arr[10],
                    Remark = arr[11]
                });

            }

        }

        private static void InitAirplaneTicket()
        {
            var db = new SQLiteDBItinerary<Itinerary>();
            var list = db.QueryTableByTicketType("飞机票");
            db.DeleteList(list);

            string dataInitPath = "DataInit\\AirplaneTicket.txt";
            var path = Path.Combine(Directory.GetCurrentDirectory(), dataInitPath);
            var lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                var arr = line.Split(',');
                // 处理每行的逻辑
                db.Insert(new Itinerary
                {
                    Start = arr[0],
                    End = arr[1],
                    Cost = Convert.ToDecimal(arr[2]),
                    CompanyType = arr[3],
                    TicketType = arr[4],
                    CityName = arr[5],
                    StartDate = Convert.ToDateTime(arr[6]),
                    EndDate = Convert.ToDateTime(arr[6]),
                    FeeType = arr[8],
                    HasTicket = arr[9],
                    HasDetail = arr[10],
                    Remark = arr[11]
                });

            }

        }
    }
}
