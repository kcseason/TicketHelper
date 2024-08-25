using TicketHelper.DBO;
using TicketHelper.Model;

namespace TicketHelper.Handler
{
    internal class HotelHandler
    {
        public static void DataInit()
        {
            InitRentalFee();
            InitHotelFee();
        }

        private static void InitRentalFee()
        {
            var db = new SQLiteDBHotel<Hotel>();
            var list = db.QueryTableByFeeType("租房");
            db.DeleteList(list);

            string dataInitPath = "DataInit\\Rental.txt";
            var path = Path.Combine(Directory.GetCurrentDirectory(), dataInitPath);
            var lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                var arr = line.Split(',');
                // 处理每行的逻辑
                db.Insert(new Hotel
                {
                    CityName = arr[0],
                    HotelName = arr[1],
                    StartDate = Convert.ToDateTime(arr[2]),
                    EndDate = Convert.ToDateTime(arr[3]),
                    Cost = Convert.ToDecimal(arr[4]),
                    HasETicket = arr[5],
                    HasTicket = arr[6],
                    FeeType = arr[7],
                    Remark = arr[8]
                });
            }
        }

        private static void InitHotelFee()
        {
            var db = new SQLiteDBHotel<Hotel>();
            var list = db.QueryTableByFeeType("酒店");
            db.DeleteList(list);

            string dataInitPath = "DataInit\\Hotel.txt";
            var path = Path.Combine(Directory.GetCurrentDirectory(), dataInitPath);
            var lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                var arr = line.Split(',');
                // 处理每行的逻辑
                db.Insert(new Hotel
                {
                    CityName = arr[0],
                    HotelName = arr[1],
                    StartDate = Convert.ToDateTime(arr[2]),
                    EndDate = Convert.ToDateTime(arr[3]),
                    Cost = Convert.ToDecimal(arr[4]),
                    HasETicket = arr[5],
                    HasTicket = arr[6],
                    FeeType = arr[7],
                    Remark = arr[8]
                });
            }
        }

    }
}
