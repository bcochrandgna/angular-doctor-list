namespace DoctorsListAPI.Dtos
{
    public class DoctorForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Specialties { get; set; }
        public double AverageRating { get; set; }
    }
}