using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Model
{
    public class Instructor
    {
        [Key]
        public int id { get; set; }
        public DateTime HireDate { get; set; }

        [ForeignKey("id")]
        public People People { get; set; }

        public ICollection<Courses> Courses { get; set; }
    }
}
