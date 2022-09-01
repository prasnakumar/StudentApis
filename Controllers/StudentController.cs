using Microsoft.AspNetCore.Mvc;
using StudentApis.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApis.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IListStudent _student;
        public StudentController(IListStudent student)
        {
            _student = student;

        }
        [HttpGet]
        [Route("GetAllStudent")]
        public async Task<IActionResult> GetAllStudent()
        {
            var StudentValue= await _student.allStudent();
            return Ok(StudentValue);
        }

    }
}
