namespace HospitalManagementSystem.Models.RequestModels
{
    public class GetAppointmentRequestModel
    {
        public Guid patientName { get; set; }
        public int doctorId { get; set; }
    }
}
