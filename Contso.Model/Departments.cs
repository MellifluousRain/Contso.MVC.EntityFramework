using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Model
{
    public class Departments
    {
        public int id { get; set; }
        [DisplayName("Department Name")]
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int Instructorid { get; set; }
        public string RowVersion { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Instructor> Instructors { get; set; }
        //public Instructor Instructor { get; set; }
    }
}
