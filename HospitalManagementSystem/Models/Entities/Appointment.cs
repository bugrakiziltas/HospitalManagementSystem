using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagementSystem.Models.Entities
{
    public class Appointment
    {
        public Guid PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public Doctor Doctor { get; set; }
    }
}
