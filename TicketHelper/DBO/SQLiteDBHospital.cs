using TicketHelper.Model;

namespace TicketHelper.DBO
{
    internal class SQLiteDBHospital<T> : SQLiteDBBase<T> where T : ModelBase, new()
    {

        public SQLiteDBHospital()
        {
        }

        public int Insert(Hospital hp) => base.Insert(hp);

        public int Insert(List<Hospital> hpList) => base.Insert(hpList);

       // public int Delete(Hospital hp) => base.Delete((T)hp);

        public int DeleteAll() => base.DeleteAll();

        public int Update(Hospital hp)=>base.Update(hp);

        public int Update(List<Hospital> list) => base.Update(list);   

        public void CreateTable()=>base.CreateTable();

        public void DropTable() => base.DropTable();
    }
}
