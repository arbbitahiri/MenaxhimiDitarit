using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseCRUDUser<T>
    {
        bool AddUser(T model);
        bool UpdateUser(T model);
        bool RemoveUser(int id);
        List<T> GetAllUser();


        bool AddStaffAbsence(T model);
        List<T> GetAllStaffAbsence();
    }
}
