using StudentAPI.core.Business.Models.Faculties;
using StudentAPI.core.DataAccess.Repositories;
using StudentAPI.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.core.Business.Services
{
    public interface IFacultyService
    {
        Task<ResponseModel> InserFacultyAsync(FacultyViewModel facultyViewModel);

        Task<ResponseModel> InsertFacultAsync(IEnumerable<Faculty> faculties);
    }

    public class FacultyService : IFacultyService
    {
        public readonly IRepository<Faculty> _repository;

        public FacultyService(IRepository<Faculty> repository)
        {
            _repository = repository;
        }

        public async Task<ResponseModel> InserFacultyAsync(FacultyViewModel facultyViewModel)
        {
            var faculty = AutoMapper.Mapper.Map<Faculty>(facultyViewModel);
            try
            {

                return await _repository.InsertAsync(faculty);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ResponseModel> InsertFacultAsync(IEnumerable<Faculty> faculties)
        {
            return await _repository.InsertAsync(faculties);
        }
    }
}
