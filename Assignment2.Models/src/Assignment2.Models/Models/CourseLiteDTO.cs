using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models.Models
{
    public class CoursesDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Semester { get; set; }
        public string TemplateID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

