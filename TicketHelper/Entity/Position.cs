using SQLite;

namespace TicketHelper.Entity
{
    internal class Position
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string? PositionName { get; set; }
    }
}
