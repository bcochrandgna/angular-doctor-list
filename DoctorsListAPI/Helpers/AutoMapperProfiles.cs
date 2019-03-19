using System.Linq;
using AutoMapper;
using DoctorsListAPI.Dtos;
using DoctorsListAPI.Models;

namespace DoctorsListAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Doctor, DoctorForListDto>()
                .ForMember(dest => dest.Specialties, opt =>
                {
                    opt.MapFrom(src => string.Join(", ", src.DoctorSpecialties.Select(ds => ds.Specialty.Name)));
                })
                .ForMember(dest => dest.AverageRating, opt =>
                {
                    opt.MapFrom(src => src.PatientRatings.Select(p => p.Rating).DefaultIfEmpty(0).Average(p => p));
                });

            CreateMap<Doctor, DoctorForDetailDto>()
                .ForMember(dest => dest.MedicalSchool, opt =>
                {
                    opt.MapFrom(src => src.MedicalSchool.Name);
                });
            CreateMap<DoctorSpecialty, SpecialtyDto>()
                .ForMember(dest => dest.Name, opt =>
                {
                    opt.MapFrom(src => src.Specialty.Name);
                });
            CreateMap<DoctorLanguage, LanguageDto>()
                .ForMember(dest => dest.Name, opt =>
                {
                    opt.MapFrom(src => src.Language.Name);
                });
            CreateMap<MedicalSchool, MedicalSchoolDto>();
            CreateMap<PatientRating, PatientRatingDto>();
        }
    }
}