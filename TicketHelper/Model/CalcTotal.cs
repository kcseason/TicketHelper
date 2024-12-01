using SQLite;

namespace TicketHelper.Model
{
    [Table("CalcTotal")]
    internal class CalcTotal : ModelBase
    {
        public string? PositionName { get; set; }

        public decimal? TotalFee { get; set; }
    }
}
