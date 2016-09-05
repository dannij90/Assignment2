using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models.Models
{
    public class CourseLiteDTO
    {
        /// <summary>
        /// Database-generated ID of the course
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// The name of the course
        /// Example: "Web services"
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Example: 20163 -> fall 2016
        /// </summary>
        public string Semester { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

