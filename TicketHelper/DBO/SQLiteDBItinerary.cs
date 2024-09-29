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

        public int DeleteList(List<T> list)=>base.DeleteList(list);

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
            if (!args[2].ToString().Equals("全部"))
            {
                sql += @"AND CityName=? ";
                objs.Add(args[2]);
            }
            if (!args[3].ToString().Equals("全部"))
            {
                sql += @"AND CompanyType=? ";
                objs.Add(args[3]);
            }
            if (!args[4].ToString().Equals("全部"))
            {
                sql += @"AND TicketType=? ";
                objs.Add(args[4]);
            }

            return base.QueryTable(sql, objs.ToArray());
        }
        public List<T> QueryTableByTicketType(string ticketType)
        {
            var sql = @"SELECT * FROM Itinerary  WHERE TicketType=?";

            return base.QueryTable(sql, ticketType);
        }
    }
}
