using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseCRUDTopic<T>
    {
        bool AddTopic(T model);
        bool UpdateTopic(T model);
        bool RemoveTopic(int id);

        List<T> GetAllTopic();
        T GetTopic(int id);

        bool AddAbsence(T model);
        bool UpdateAbsence(T model);
        bool RemoveAbsence(int id);

        List<T> GetAllAbsence();
        T GetAbsence(int id);
    }
}
