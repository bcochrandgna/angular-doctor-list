namespace DoctorsListAPI.Models
{
    public class DoctorLanguage
    {
        public int DoctorId { get; set; }
        public int LanguageId { get; set; }
        public Doctor Doctor { get; set; }
        public Language Language { get; set; }
    }
}