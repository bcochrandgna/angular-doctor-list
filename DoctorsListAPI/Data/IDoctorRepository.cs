using System.Collections.Generic;
using System.Threading.Tasks;
using DoctorsListAPI.Models;

namespace DoctorsListAPI.Data
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> ListDoctors();
        Task<Doctor> GetDoctor(int id);
    }
}