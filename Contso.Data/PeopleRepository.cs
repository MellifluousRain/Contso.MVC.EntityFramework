using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Model;

namespace Contso.Data
{
    public class PeopleRepository : IRepository<People>
    {
        ContsoMVC db = new ContsoMVC();
        public void Add(People obj)
        {
            db.People.Add(obj);
            db.SaveChanges();
        }

        public void DeleteAll()
        {
            foreach (var item in db.People)
            {
                db.People.Remove(item);
            }
            db.SaveChanges();
        }

        public void DeleteById(int id)
        {
            db.People.Remove(GetById(id));
            db.SaveChanges();
        }

        public IEnumerable<People> GetAll()
        {
            return db.People.ToList();
        }

        public People GetById(int id)
        {
            return db.People.Where(d => d.id == id).FirstOrDefault();
        }

        public void Update(People obj)
        {
            db.People.Attach(obj);
            db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
