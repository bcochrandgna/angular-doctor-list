namespace DoctorsListAPI.Models
{
    public class PatientRating
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public string Comments { get; set; }
        public int Rating { get; set; }
    }
}