﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentPortal.DataAccessLayer;
using StudentPortal.IBusinessServiceLayer;

using StudentPortal.Model;
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
        private ICRUDService<StudentViewModel> StudentService;
        private readonly ILogger<StudentController> _logger;
        public StudentController(ILogger<StudentController> logger, ICRUDService<StudentViewModel> studentService)
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
        public IActionResult Delete(int id)
        {
            StudentService.Delete(id);
            return Ok("Deleted");
        }
    }
}

