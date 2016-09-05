using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Services;
using Assignment2.Models.Models;

namespace Assignment2.API.Controllers
{
    [Route("api/courses")]
    public class CoursesController : Controller
    {
        private readonly ICoursesService _service;

        public CoursesController(ICoursesService service)
        {
            _service = service;
        }
        // GET api/values
        [HttpGet]
        public List<CourseLiteDTO> GetCoursesOnSemester(string semester = null)
        {
            return _service.GetCoursesBySemester(semester);
            /*
            return new list<CourseLiteDTO>
            {
                new CourseLiteDTO
                {
                    ID = 1,
                    Name = "Web Services",
                    Semester = "20163"
                }
            };*/
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
