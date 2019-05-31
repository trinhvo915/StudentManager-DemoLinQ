using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.core.Entities
{
    [Table("Course")]
    public class Course : BaseEntity
    {
        public Course() : base()
        {

        }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        public List<StudentInCourse> StudentInCourses { set; get; }
    }
}
