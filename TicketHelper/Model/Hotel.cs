using System.ComponentModel.DataAnnotations.Schema;

namespace TicketHelper.Model
{
    [Table("Hotel")]
    public class Hotel : ModelBase
    {
        public Hotel() { }
        public string HotelName { get; set; }
        public string HasTicket { get; set; }
        public decimal Cost { get; set; }
    }
}
