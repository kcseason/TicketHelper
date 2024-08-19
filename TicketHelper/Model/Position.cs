using SQLite;

namespace TicketHelper.Model
{
    [Table("Position")]
    internal class Position : ModelBase
    {
        public string? PositionName { get; set; }
    }
}
