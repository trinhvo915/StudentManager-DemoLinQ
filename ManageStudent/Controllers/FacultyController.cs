using Microsoft.AspNetCore.Mvc;
using StudentAPI.core.Business.Models.Faculties;
using StudentAPI.core.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly IFacultyService _facultyService;

        public FacultyController(IFacultyService facultyService)
        {
            _facultyService = facultyService;
        }

        [HttpGet]
        public string GetAllFaculty()
        {
            return new string("anc");
        }

        [HttpPost]
        public async Task<IActionResult> InsertFaculty([FromBody] FacultyViewModel facultyViewModel)
        {
            Console.WriteLine("into this function");
            var response = await _facultyService.InserFacultyAsync(facultyViewModel);
            if (response.HttpStatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(response.Data);
            }
            else
            {
                return BadRequest(new string("Insert Faculty no success!!!"));
            }
        }

        //
    }
}
