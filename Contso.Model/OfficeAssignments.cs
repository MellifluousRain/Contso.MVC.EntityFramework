using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Model
{
    public class OfficeAssignments
    {
        [Key]
        public int Instructorid { get; set; }
        public string Location { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        [ForeignKey("Instructorid")]
        public Instructor Instructor { get; set; }
    }
}
