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
    }
}
