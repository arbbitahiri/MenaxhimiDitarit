using System.Collections.Generic;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseCRUD<T>
    {
        bool Add(T model);
        bool Update(T model);
        bool Remove(int id);

        List<T> GetAll();
        T Get(int id);
    }
}
