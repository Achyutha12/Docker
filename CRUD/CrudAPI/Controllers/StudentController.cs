using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public static ArrayList StudentData = new ArrayList() { "Scott","Smith"};

        
        [HttpGet]
        [Route("GetAllStudents")]
        public ArrayList GetAllUsers()
        {
            return StudentData;
        }

        //[HttpGet]
        //[Route("GetStudent")]
        //public string GetStudent(int id)
        //{
        //    return StudentData[id].ToString();
        //}

        [HttpPost]
        [Route("SaveNewStudent")]
        public ArrayList SaveNewStudent([FromQuery] string student)
        {
            StudentData.Add(student);
            return StudentData;
        }

        [HttpPut]
        [Route("UpdateStudent")]
        public ArrayList UpdateStudent(int id, [FromQuery] string student)
        {
            StudentData[id] = student;
            return StudentData;
        }

        [HttpDelete]
        [Route("DeleteStudent")]

        public ArrayList DeleteStudent(int id, [FromQuery] string student)
        {
            StudentData[id] = student;
            StudentData.Remove(student);
            return StudentData;
        }
    }
}
