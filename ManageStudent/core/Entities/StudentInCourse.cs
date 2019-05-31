using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.core.Entities
{
    [Table("StudentInCourse")]
    public class StudentInCourse : BaseEntity
    {
        public StudentInCourse() : base()
        {

        }

        public Guid StudentId { set; get; }

        public Student Student { set; get; }

        public Guid CourseId { set; get; }

        public Course Course { set; get; }

    }
}
