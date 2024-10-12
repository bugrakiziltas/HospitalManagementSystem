namespace HospitalManagementSystem.Models.RequestModels
{
    public class CreateAppointmentRequestModel
    {
        public Guid PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int DoctorId { get; set; }
    }
}
