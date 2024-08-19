using SQLite;

namespace TicketHelper.Model
{
    public class ModelBase
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string? FeeType { get; set; }

        public string? Remark { get; set; }
    }
}
