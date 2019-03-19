using System.Collections.Generic;
using System.Threading.Tasks;
using DoctorsListAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorsListAPI.Data
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _context;
        public DoctorRepository(DataContext context)
        {
            this._context = context;

        }

        public async Task<Doctor> GetDoctor(int id)
        {
            return await _context.Doctors
                .Include(d => d.DoctorSpecialties)
                    .ThenInclude(ds => ds.Specialty)
                .Include(d => d.DoctorLanguages)
                    .ThenInclude(dl => dl.Language)
                .Include(d => d.PatientRatings)
                .Include(d => d.MedicalSchool)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<Doctor>> ListDoctors()
        {
            return await _context.Doctors
                .Include(d => d.DoctorSpecialties)
                    .ThenInclude(ds => ds.Specialty)
                .Include(d => d.DoctorLanguages)
                    .ThenInclude(dl => dl.Language)
                .Include(d => d.PatientRatings)
                .Include(d => d.MedicalSchool)
                .ToListAsync();
        }
    }
}