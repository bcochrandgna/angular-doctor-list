using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DoctorsListAPI.Data;
using DoctorsListAPI.Dtos;
using DoctorsListAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorRepository _repository;
        private readonly IMapper _mapper;

        public DoctorsController(IDoctorRepository repository, IMapper mapper)
        {
            this._mapper = mapper;
            this._repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult> ListDoctors()
        {
            var doctors = await _repository.ListDoctors();
            var doctorDtos = _mapper.Map<IEnumerable<DoctorForListDto>>(doctors);
            return Ok(doctorDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetDoctor(int id)
        {
            var doctor = await _repository.GetDoctor(id);
            var doctorDto = _mapper.Map<DoctorForDetailDto>(doctor);
            return Ok(doctorDto);
        }
    }
}