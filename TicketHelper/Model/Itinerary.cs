using System.ComponentModel.DataAnnotations.Schema;

namespace TicketHelper.Model
{
    [Table("Itinerary")]
    internal class Itinerary : ModelBase
    {
        public string? Start { get; set; }

        public string? End { get; set; }

        public decimal Cost { get; set; }
        public string? CompanyType { get; set; }
        public string? TicketType { get; set; }
        public string? HasTicket { get; set; }
        public string? HasDetail { get; set; }
        public string? ItineraryNO { get; set; }
    }
}
