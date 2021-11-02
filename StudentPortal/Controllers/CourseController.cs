using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentPortal.Model.Models;
using StudentPortal.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService CourseService;
        private readonly ILogger<CourseController> _logger;
        public CourseController(ILogger<CourseController> logger, ICourseService courseService)
        {
            _logger = logger;
            this.CourseService = courseService;
        }

        [HttpGet]
        public IEnumerable<CourseViewModel> Get()
        {
            var st = CourseService.Get();
            return (IEnumerable<CourseViewModel>)st;
        }

        [HttpGet("{id:int}")]
        public CourseViewModel Get(int id)
        {
            var st = CourseService.GetById(id);
            return st;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CourseViewModel course)
        {
            string InsertVal = "";
            bool Success = CourseService.Insert(course);
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
        public IActionResult Put([FromBody] CourseViewModel course)
        {
            string UpdateVal = "";
            bool Success = CourseService.Update(course);
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
            CourseService.Delete(id);
            return Ok("Deleted");
        }
    }
}
