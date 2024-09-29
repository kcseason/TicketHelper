using SQLite;
using TicketHelper.Model;

namespace TicketHelper.DBO
{
    internal class SQLiteDBHospitalPatient<T> : SQLiteDBBase<T> where T : ModelBase, new()
    {

        public int Insert(T t) => base.Insert(t);

        public int Insert(List<T> list) => base.Insert(list);

        // public int Delete(Hospital hp) => base.Delete((T)hp);

        public int DeleteAll() => base.DeleteAll();

        public int Update(T t) => base.Update(t);

        public int Update(List<T> list) => base.Update(list);

        public void CreateTable() => base.CreateTable();

        public void DropTable() => base.DropTable();
        public List<T> QueryTable() => base.QueryTable();
        public List<T> QueryTable(params object[] args)
        {
            var sql = @"SELECT * FROM Hospital  WHERE StartDate>=? AND  StartDate<=? ";
            var objs = new List<object>() { args[0], args[1] };
            if (!args[2].ToString().Equals("全部"))
            {
                sql += @"AND CityName=? ";
                objs.Add(args[2]);
            }
            if (!args[4].ToString().Equals("全部"))
            {
                sql += @"AND TicketType=? ";
                objs.Add(args[4]);
            }

            return base.QueryTable(sql, objs.ToArray());
        }
    }
}
