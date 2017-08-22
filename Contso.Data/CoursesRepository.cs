using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Model;

namespace Contso.Data
{
    public class CoursesRepository : IRepository<Courses>
    {
        Contso.Data.ContsoMVC db = new ContsoMVC();
        public void Add(Courses obj)
        {
            db.Courses.Add(obj);
            db.SaveChanges();
        }

        public void DeleteAll()
        {
            foreach (var item in db.Courses)
            {
                db.Courses.Remove(item);
            }
            db.SaveChanges();
        }

        public void DeleteById(int id)
        {
            db.Courses.Remove(GetById(id));
            db.SaveChanges();
        }

        public IEnumerable<Courses> GetAll()
        {
            return db.Courses.ToList();
        }

        public Courses GetById(int id)
        {
            return db.Courses.Where(d => d.id == id).FirstOrDefault();
        }

        public void Update(Courses obj)
        {
            db.Courses.Attach(obj);
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
