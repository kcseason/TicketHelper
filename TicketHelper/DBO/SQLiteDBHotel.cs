using SQLite;
using TicketHelper.Model;

namespace TicketHelper.DBO
{
    internal class SQLiteDBHotel<T> : SQLiteDBBase<T> where T : ModelBase, new()
    {

        public int Insert(T hp) => base.Insert(hp);

        public int Insert(List<T> hpList) => base.Insert(hpList);

        public int Delete(T t) => base.Delete(t);

        public int DeleteAll() => base.DeleteAll();
        public int DeleteList(List<T> list) => base.DeleteList(list);
        public int Update(T t) => base.Update(t);

        public int Update(List<T> list) => base.Update(list);

        public void CreateTable() => base.CreateTable();

        public void DropTable() => base.DropTable();

        public List<T> QueryTable() => base.QueryTable().ToList();
        public List<T> QueryTable(params object[] args)
        {
            var sql = @"SELECT * FROM Hotel  WHERE StartDate>=? AND  StartDate<=? ";
            var objs = new List<object>() { args[0], args[1] };
            if (!args[2].ToString().Equals("全部"))
            {
                sql += @"AND CityName=? ";
                objs.Add(args[2]);
            }
            if (!args[3].ToString().Equals("全部"))
            {
                sql += @"AND FeeType=? ";
                objs.Add(args[3]);
            }

            return base.QueryTable(sql, objs.ToArray());
        }
        public List<T> QueryTableByFeeType(string feeType)
        {
            var sql = @"SELECT * FROM Hotel  WHERE FeeType=? ORDER BY StartDate DESC";

            return base.QueryTable(sql, feeType);
        }
    }
}
