using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentPortal.IBusinessServiceLayer;
using StudentPortal.Services.IService;
using StudentPortal.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Controllers
{

    [Route("[controller]")]
    public class TeacherController : Controller
    {
      
        private ITeacherService TeacherService;
        private readonly ILogger<TeacherController> _logger;
        public TeacherController(ILogger<TeacherController> logger, ITeacherService teacherService)
        {
            _logger = logger;
            this.TeacherService = teacherService;
        }

        [HttpGet]
        public IEnumerable<TeacherViewModel> Get()
        {
            var st = TeacherService.Get();
            return (IEnumerable<TeacherViewModel>)st;
        }

        [HttpGet("{id:int}")]
        public TeacherViewModel Get(int id)
        {
            var st = TeacherService.GetById(id);
            return st;
        }

        [HttpPost]
        public IActionResult Post([FromBody] TeacherViewModel teacher)
        {
            string InsertVal = "";
            bool Success = TeacherService.Insert(teacher);
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
        public IActionResult Put([FromBody] TeacherViewModel teacher)
        {
            string UpdateVal = "";
            bool Success = TeacherService.Update(teacher);
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
        public IActionResult Delete(int id)
        {
            TeacherService.Delete(id);
            return Ok("Deleted");
        }
        [HttpGet("GetTeacherCourses")]
        public IEnumerable<TeacherViewModel> GetTeacherCourses()
        {
            var st = TeacherService.GetTeacherCourses();
            return (IEnumerable<TeacherViewModel>)st;
        }
    }
}
