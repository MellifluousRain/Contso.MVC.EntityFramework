using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contso.Data;
using Contso.Model;

namespace Contso.Service
{
    public class DepartmentService
    {
        DepartmentsRepository departmentRepository = new DepartmentsRepository();
        public Departments GetById(int id)
        {
            return departmentRepository.GetById(id);
        }
        public IEnumerable<Departments> GetAll()
        {
            return departmentRepository.GetAll();
        }
        public void DeleteById(int id)
        {
            departmentRepository.DeleteById(id);
        }
        public void DeleteAll()
        {
            departmentRepository.DeleteAll();
        }
        public void Create(Departments obj)
        {
            departmentRepository.Add(obj);
        }
        public void Update(Departments obj)
        {
            departmentRepository.Update(obj);
        }
    }
}
