using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Data;
using Contso.Model;

namespace Contso.Service
{
    public class PeopleService
    {
        PeopleRepository peopleRepository = new PeopleRepository();
        public void Create(People obj)
        {
            peopleRepository.Add(obj);
        }
        public void DeleteById(int id)
        {
            peopleRepository.DeleteById(id);
        }
        public void DeleteAll()
        {
            peopleRepository.DeleteAll();
        }
        public IEnumerable<People> GetAll()
        {
            return peopleRepository.GetAll();
        }
        public People GetById(int id)
        {
            return peopleRepository.GetById(id);
        }
        public void Update(People obj)
        {
            peopleRepository.Update(obj);
        }
    }
}
