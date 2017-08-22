using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Model
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public DateTime EnrollmentDate { get; set; }

        [ForeignKey("id")]
        public People People { get; set; }
    }
}
