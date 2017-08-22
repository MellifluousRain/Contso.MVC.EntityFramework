using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Model;
using Contso.Data;

namespace Contso.Service
{
    public class CoursesService
    {
        CoursesRepository courseRepository = new CoursesRepository();
        public void Create(Courses obj)
        {
            courseRepository.Add(obj);
        }
        public void DeleteById(int id)
        {
            courseRepository.DeleteById(id);
        }
        public void DeleteAll()
        {
            courseRepository.DeleteAll();
        }
        public Courses GetById(int id)
        {
            return courseRepository.GetById(id);
        }
        public IEnumerable<Courses> GetAll()
        {
            return courseRepository.GetAll();
        }
        public void Update(Courses obj)
        {
            courseRepository.Update(obj);
        }
    }
}
