using System.ComponentModel.DataAnnotations.Schema;

namespace TicketHelper.Model
{
    [Table("Itinerary")]
    internal class Itinerary : ModelBase
    {
        public DateTime DateTime { get; set; }

        public string? Start { get; set; }

        public string? End { get; set; }

        public decimal Cost { get; set; }

        public string? LocationName { get; set; }
        public string? CompanyType { get; set; }
        public string? TicketType { get; set; }
    }
}
