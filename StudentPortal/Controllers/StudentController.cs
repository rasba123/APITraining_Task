using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentPortal.DataAccessLayer;
using StudentPortal.IDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
     
        private readonly ILogger<StudentController> _logger;
       // readonly IStudentRepository st = new StudentRepository();
        public StudentController(ILogger<StudentController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            this.studentRepository = studentRepository;
        }
        private IStudentRepository studentRepository;

        [HttpGet]
       
        public IEnumerable<StudentViewModel> Get()
        {
            studentRepository.GetStudent();


            return Enumerable.Range(1, 1).Select(index => new StudentViewModel
            {
                Date = Utilities.Constants.Dated,
                 FirstName = Utilities.Constants.FirstName,
                SecondName = Utilities.Constants.SecondName,
                Percentage = Utilities.Constants.Percentage,

            })
            .ToArray();
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(new Response{ StatusCode = 1 ,});
        }

        [HttpPost]

        public List<StudentViewModel> Post([FromBody] StudentViewModel student)
        {
            List<StudentViewModel> StudentList = new List<StudentViewModel>();
            StudentList.Add(student);
            return StudentList;
           
        }
        [HttpPut]
        public string Put([FromBody] StudentViewModel student)
        {

            return "Updated";
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            // if (id <= 0)
            ///return BadRequest("Not a valid student id");


            return Ok("okay!");
        }
    }
}

