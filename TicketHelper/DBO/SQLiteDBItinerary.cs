using TicketHelper.Model;

namespace TicketHelper.DBO
{
    internal class SQLiteDBItinerary<T> : SQLiteDBBase<T> where T : ModelBase, new()
    {

        public SQLiteDBItinerary()
        {
        }

        public int Insert(T t) => base.Insert(t);

        public int Insert(List<T> hpList) => base.Insert(hpList);

        public int Delete(T t) => base.Delete(t);

        public int DeleteList(List<T> list) => base.DeleteList(list);

        public int DeleteAll() => base.DeleteAll();

        public int Update(T t) => base.Update(t);

        public int Update(List<T> list) => base.Update(list);

        public void CreateTable() => base.CreateTable();

        public void DropTable() => base.DropTable();

        public List<T> QueryTable() => base.QueryTable();
        //public Task<TableQuery<T>> QueryTable() => base.QueryTable();


        public List<T> QueryTable(params object[] args)
        {
            var sql = @"SELECT * FROM Itinerary  WHERE StartDate>=? AND  StartDate<=? ";
            var objs = new List<object>() { args[0], args[1] };
            if (!string.IsNullOrEmpty(args[2].ToString()))
            {
                sql += @" AND CityName IN(" + args[2].ToString() + ")";
            }
            if (!string.IsNullOrEmpty(args[3].ToString()))
            {
                sql += @" AND CompanyType IN(" + args[3].ToString() + ")";
            }
            if (!string.IsNullOrEmpty(args[4].ToString()))
            {
                sql += @" AND TicketType IN(" + args[4].ToString() + ")";
            }

            return base.QueryTable(sql, objs.ToArray()).ToList();
        }
        public List<T> QueryTableByTicketType(string ticketType)
        {
            var sql = @"SELECT * FROM Itinerary  WHERE TicketType=?";

            return base.QueryTable(sql, ticketType);
        }
    }
}
