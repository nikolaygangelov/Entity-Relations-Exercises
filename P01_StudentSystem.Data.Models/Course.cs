using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
             StudentsCourses = new HashSet<StudentCourse>();
            Resources = new HashSet<Resource>();
            Homeworks = new List<Homework>();
        }

        [Key]
        public int CourseId { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Decimal Price { get; set; }
        public ICollection<StudentCourse> StudentsCourses { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
    }
}
