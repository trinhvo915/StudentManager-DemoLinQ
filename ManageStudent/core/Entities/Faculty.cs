using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.core.Entities
{
    [Table("Faculty")]
    public class Faculty : BaseEntity
    {
        public Faculty() : base()
        {

        }

        public Faculty(string Name)
        {
            this.Name = Name;
        }

        [Required]
        [StringLength(50)]
        public string Name { set; get; }

        public List<Class> Classes { set; get; }
    }
}
