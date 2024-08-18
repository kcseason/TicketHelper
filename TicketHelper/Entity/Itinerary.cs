using SQLite;

namespace TicketHelper.Entity
{
    internal class Itinerary
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime DateTime { get; set; }

        public string? Start { get; set; }

        public string? End { get; set; }

        public decimal Cost { get; set; }

        public string? LocationName { get; set; }
        public string? CompanyType { get; set; }
        public string? TicketType { get; set; }

        public string? Remark { get; set; }
    }
}
