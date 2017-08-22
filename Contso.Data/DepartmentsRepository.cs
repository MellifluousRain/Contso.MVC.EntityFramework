using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Model;

namespace Contso.Data
{
    public class DepartmentsRepository : IRepository<Departments>
    {
        private ContsoMVC db = new ContsoMVC();

        public void Add(Departments obj)
        {
            db.Departments.Add(obj);
            db.SaveChanges();
        }

        public void DeleteAll()
        {
            foreach (var item in db.Departments)
            {
                db.Departments.Remove(item);
            }
            db.SaveChanges();
        }

        public void DeleteById(int id)
        {
            db.Departments.Remove(GetById(id));
            db.SaveChanges();
        }

        public IEnumerable<Departments> GetAll()
        {
            return db.Departments.ToList();
        }

        public Departments GetById(int id)
        {
            return db.Departments.Where(d => d.id == id).FirstOrDefault();
        }

        public void Update(Departments obj)
        {
            db.Departments.Attach(obj);
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
