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
   
    [Route("[controller]")]
    public class EnrollmentController : Controller
    {
        private IEnrollmentService _EnrollmentService;
        private readonly ILogger<EnrollmentController> _logger;
        public EnrollmentController(ILogger<EnrollmentController> logger, IEnrollmentService enrollmentService)
        {
            _logger = logger;
            this._EnrollmentService = enrollmentService;
        }

        [HttpGet]
        public IEnumerable<EnrollmentViewModel> Get()
        {
            var st = _EnrollmentService.Get();
            return (IEnumerable<EnrollmentViewModel>)st;
        }

        [HttpGet("{id:int}")]
        public EnrollmentViewModel Get(int id)
        {
            var st = _EnrollmentService.GetById(id);
            return st;
        }

        [HttpPost]
        public IActionResult Post([FromBody] EnrollmentViewModel Enroll)
        {
            string InsertVal = "";
            bool Success = _EnrollmentService.Insert(Enroll);
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
        public IActionResult Put([FromBody] EnrollmentViewModel teacher)
        {
            string UpdateVal = "";
            bool Success = _EnrollmentService.Update(teacher);
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
            _EnrollmentService.Delete(id);
            return Ok("Deleted");
        }
    
}
}
