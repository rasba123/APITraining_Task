using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
       
        public IEnumerable<Student> Get()
        {
          
            return Enumerable.Range(1, 1).Select(index => new Student
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

        public List<Student> Post([FromBody] Student student)
        {
            List<Student> StudentList = new List<Student>();
            StudentList.Add(student);
            return StudentList;
           
        }
        [HttpPut]
        public string Put([FromBody] Student student)
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

