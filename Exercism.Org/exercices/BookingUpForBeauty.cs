
namespace Exercism.Org.exercices
{
    static class Appointment
    {
        public static System.DateTime Schedule(string appointmentDateDescription)
            => System.Convert.ToDateTime(appointmentDateDescription);
        public static bool HasPassed(System.DateTime appointmentDate)
            => appointmentDate < System.DateTime.Now;
        public static bool IsAfternoonAppointment(System.DateTime appointmentDate)
            => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;
        public static string Description(System.DateTime appointmentDate)
            => $"You have an appointment on {appointmentDate:M/d/yyyy h:mm:ss tt}.";
        public static System.DateTime AnniversaryDate()
            => new System.DateTime(2022, 9, 15, 0, 0, 0);
    }
}