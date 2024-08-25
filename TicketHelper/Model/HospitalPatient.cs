using System.ComponentModel.DataAnnotations.Schema;

namespace TicketHelper.Model
{
    [Table("HospitalPatient")]
    public class HospitalPatient : ModelBase
    {
        public HospitalPatient() { }

        public string HospitalName { get; set; }

        public string PatientType {  get; set; }

        public string HasPatientRecord { get; set; }
        public string HasPatientTicket { get; set; }
        public string HasPatientDetail { get; set; }

        public string HasBChaoReport { get; set; }

        public string HasCTReport { get; set; }
        public string HasMRReport { get; set; }
        public decimal Cost { get; set; }
    }
}
