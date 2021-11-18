using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentPortal.IBusinessServiceLayer;
using StudentPortal.Model;
using StudentPortal.Services.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentService StudentService;
        private readonly ILogger<StudentController> _logger;
        public StudentController(ILogger<StudentController> logger, IStudentService studentService)
        {
            _logger = logger;
            this.StudentService = studentService;
        }

        [HttpGet]
        public IEnumerable<StudentViewModel> Get()
        {
            var st = StudentService.Get();
            return st;
        }

        [HttpGet("{id:int}")]
        public StudentViewModel Get(int id)
        {
            var st = StudentService.GetById(id);
            return st;
        }
        [HttpGet("Get/{StudentName}")]
        public StudentViewModel Get(string StudentName)
        {
            var st = StudentService.GetbyName(StudentName);
            return st;
        }
        [HttpGet("GetMarks")]
        public IActionResult GetMarks(int id)
        {
           
            var st = StudentService.GetById(id); 
            CalculatePercentage CalPer = new CalculatePercentage();
            Calculation calculation = CalPer;
            float TotalMarks = calculation.GetTotalMarks(st.Marks1, st.Marks1, st.Marks1);
            // float Per = CalPer.getPercentage(st.Marks1, st.Marks1, st.Marks1);
            return Ok("Total Marks =" +TotalMarks);
        }
        [HttpGet("GetPercentage")]
        public IActionResult GetPercentage(int id)
        {
            var st = StudentService.GetById(id);
            CalculatePercentage CalPer = new CalculatePercentage();
          
            float Per = CalPer.getPercentage(st.Marks1, st.Marks1, st.Marks1);
            return Ok("Total Percentage =" + Per);
        }

        [HttpGet("GetStudentAddress")]
       public IEnumerable<StudentViewModel> GetStudentAddress()
        {
            var st = StudentService.GetStudentAddress();
            return st;
        }

        [HttpPost]
        public IActionResult Post([FromBody] StudentViewModel student)
        {
            string InsertVal = "";
            bool Success = StudentService.Insert(student);
            if (Success == true)
            {
                InsertVal = "Record Inserted";
            }
            else
            {
                InsertVal = "Record not Inserted";
            }
            return Ok(InsertVal);
        }

        [HttpPost("PostRabbitMQ")]
        public IActionResult PostRabbitMQ([FromBody] StudentViewModel student)
        {
            string InsertVal = "";
            bool Success = StudentService.InsertRMQ(student);
            if (Success == true)
            {
                InsertVal = "Record Inserted";
            }
            else
            {
                InsertVal = "Record not Inserted";
            }
            return Ok(InsertVal);
        }
        [HttpPut]
        public IActionResult Put([FromBody] StudentViewModel student)
        {
            string UpdateVal = "";
            bool Success = StudentService.Update(student);
            if (Success == true)
            {
                UpdateVal = "Updated Record";
            }
            else
            {
                UpdateVal = "Record not updated";
            }
            return Ok(UpdateVal);
        }

        [HttpDelete("{id:int}")]
        [Authorize]
        public IActionResult Delete(int id)
        {
            StudentService.Delete(id);
            return Ok("Deleted");
         }
        [HttpGet("StudentGroupby")]
        public IEnumerable<StudentViewModel> StudentGroupby()
        {
          var st=  StudentService.StudentGroupby();
            return st;
        }

    }
}

