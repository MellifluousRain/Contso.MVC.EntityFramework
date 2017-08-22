using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Model
{
    public class Enrollments
    {
        public int id { get; set; }
        public int Courseid { get; set; }
        public int Studentid { get; set; }
        public decimal Grade { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public Student Student { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
    }
}
