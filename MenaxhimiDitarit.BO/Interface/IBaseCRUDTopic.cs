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
        bool RemoveTopic(int id);

        List<T> GetAllTopic();

        bool AddAbsence(T model);

        List<T> GetAllAbsence();

        bool AddComment(T model);
        bool UpdateComment(T model);

        List<T> GetAllComment();
        List<T> GetAllReview();

        bool AddStaffAbsence(T model);

        List<T> GetAllStaffAbsence();
    }
}
