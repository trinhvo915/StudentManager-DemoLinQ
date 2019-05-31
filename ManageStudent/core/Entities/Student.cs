using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.core.Entities
{
    [Table("Student")]
    public class Student : BaseEntity
    {
        public Student() : base()
        {

        }

        [StringLength(50)]
        public string Name { set; get; }

        public int Age { set; get; }

        [StringLength(255)]
        public string Address { set; get; }

        public Guid ClassId { set; get; }

        public Class Clazz { set; get; }

        public List<StudentInCourse> StudentInCourses { set; get; }

    }
}
