using DoctorsListAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorsListAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<MedicalSchool> MedicalSchools { get; set; }
        public DbSet<PatientRating> PatientRatings { get; set; }
        public DbSet<DoctorSpecialty> DoctorSpecialties { get; set; }
        public DbSet<DoctorLanguage> DoctorLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DoctorSpecialty>()
                .HasKey(ds => new { ds.DoctorId, ds.SpecialtyId });

            builder.Entity<DoctorSpecialty>()
                .HasOne(ds => ds.Doctor)
                .WithMany(ds => ds.DoctorSpecialties)
                .HasForeignKey(ds => ds.DoctorId);

            builder.Entity<DoctorSpecialty>()
                .HasOne(ds => ds.Specialty)
                .WithMany(ds => ds.DoctorSpecialties)
                .HasForeignKey(ds => ds.SpecialtyId);

            builder.Entity<DoctorLanguage>()
                .HasKey(ds => new { ds.DoctorId, ds.LanguageId });

            builder.Entity<DoctorLanguage>()
                .HasOne(ds => ds.Doctor)
                .WithMany(ds => ds.DoctorLanguages)
                .HasForeignKey(ds => ds.DoctorId);

            builder.Entity<DoctorLanguage>()
                .HasOne(ds => ds.Language)
                .WithMany(ds => ds.DoctorLanguages)
                .HasForeignKey(ds => ds.LanguageId);
        }
    }
}