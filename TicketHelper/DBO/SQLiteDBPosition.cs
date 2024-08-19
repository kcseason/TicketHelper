using TicketHelper.Model;

namespace TicketHelper.DBO
{
    internal class SQLiteDBPosition<T> : SQLiteDBBase<T> where T : ModelBase, new()
    {
        public SQLiteDBPosition()
        {
        }

        public int Insert(Position hp) => base.Insert(hp);

        public int Insert(List<Position> hpList) => base.Insert(hpList);

        // public int Delete(Position hp) => base.Delete((T)hp);

        public int DeleteAll() => base.DeleteAll();

        public int Update(Position hp) => base.Update(hp);

        public int Update(List<Position> list) => base.Update(list);

        public void CreateTable() => base.CreateTable();

        public void DropTable() => base.DropTable();

        public List<T> QueryTable() => base.QueryTable().ToList();
    }
}
