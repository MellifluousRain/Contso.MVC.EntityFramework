using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contso.Data
{
    public interface IRepository<T>
    {
        void Add(T obj);
        void DeleteById(int id);
        void DeleteAll();
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Update(T obj);
    }
}
