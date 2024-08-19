using System.ComponentModel.DataAnnotations.Schema;

namespace TicketHelper.Model
{
    [Table("Hospital")]
    internal class Hospital : ModelBase
    {
        public Hospital() { }
        public string HospitalName { get; set; }

        public DateTime Date { get; set; }

        public bool HasInPatientRecord { get; set; }
        public bool HasInPatientTicket { get; set; }
        public bool HasInPatientDetail { get; set; }

        public bool HasOutPatientRecord { get; set; }
        public bool HasOutPatientTicket { get; set; }
        public bool HasOutPatientDetail { get; set; }

        public bool HasCheckReport { get; set; }
    }
}
