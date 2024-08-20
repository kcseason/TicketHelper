using SQLite;
using TicketHelper.Model;

namespace TicketHelper.DBO
{
    internal class SQLiteDBHotel<T> : SQLiteDBBase<T> where T : ModelBase, new()
    {

        public int Insert(T hp) => base.Insert(hp);

        public int Insert(List<T> hpList) => base.Insert(hpList);

        // public int Delete(Hospital hp) => base.Delete((T)hp);

        public int DeleteAll() => base.DeleteAll();

        public int Update(T t) => base.Update(t);

        public int Update(List<T> list) => base.Update(list);

        public void CreateTable() => base.CreateTable();

        public void DropTable() => base.DropTable();

        public List<T> QueryTable() => base.QueryTable().ToList();
        //public Task<TableQuery<T>> QueryTable() => base.QueryTable();
    }
}
