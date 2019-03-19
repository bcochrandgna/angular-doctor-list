using System.Collections.Generic;

namespace DoctorsListAPI.Dtos
{
    public class DoctorForDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string MedicalSchool { get; set; }
        public ICollection<SpecialtyDto> DoctorSpecialties { get; set; }
        public ICollection<LanguageDto> DoctorLanguages { get; set; }
        public ICollection<PatientRatingDto> PatientRatings { get; set; }
    }
}