using HospitalManagementSystem.Models.Entities;

namespace HospitalManagementSystem.Models.ResponseModels
{
    public class CreateAppointmentResponseModel
    {
        public Guid PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public Doctor Doctor { get; set; }
    }
}
