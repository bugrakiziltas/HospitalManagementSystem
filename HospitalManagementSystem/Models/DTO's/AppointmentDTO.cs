namespace HospitalManagementSystem.Models.DTO_s
{
    public class AppointmentDTO
    {
        public Guid PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DoctorDTO Doctor { get; set; }
    }
}
