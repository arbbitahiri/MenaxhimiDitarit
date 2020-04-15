using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseCRUD<T>
    {
        bool Add(T model);
        bool Update(T model);
        bool Remove(T model);
        List<T> GetAll();
    }
}
