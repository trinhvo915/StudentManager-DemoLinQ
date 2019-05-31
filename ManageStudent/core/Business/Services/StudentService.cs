using StudentAPI.core.DataAccess.Repositories;
using StudentAPI.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.core.Business.Services
{
    public interface IStudentService
    {
        IQueryable<Student> getAllStudent();
    }

    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _repositorystudent;
        public StudentService(IRepository<Student> repositorystudent)
        {
            _repositorystudent = repositorystudent;
        }
        public IQueryable<Student> getAllStudent()
        {
            return _repositorystudent.GetAll();
        }
    }
}
