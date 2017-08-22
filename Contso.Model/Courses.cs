using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Model
{
    public class Courses
    {
        public int id { get; set; }
        public string Title { get; set; }
        public decimal Credits { get; set; }
        public int Departmentid { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public Departments Department { get; set; }

        public ICollection<Instructor> Instructor { get; set; }
    }
}
