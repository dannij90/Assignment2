using Assignment2.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Services
{
    public interface ICoursesService
    {

        List<CourseLiteDTO> GetCoursesBySemester(string semester);

        // Todo: add more functions
    }
}
