using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.core.Entities
{
    [Table("Class")]
    public class Class : BaseEntity
    {
        public Class() : base()
        {

        }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        public Guid FacultyId { set; get; }

        public Faculty Faculty { set; get; }

        public List<Student> Students { set; get; }
    }
}
