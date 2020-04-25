using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;
using MenaxhimiDitarit.DAL;

namespace MenaxhimiDitarit.BLL
{
    public class ClassScheduleBLL : IBaseCRUD<ClassSchedule>
    {
        public ClassScheduleDAL scheduleDAL;

        public ClassScheduleBLL()
        {
            scheduleDAL = new ClassScheduleDAL();
        }

        public bool Add(ClassSchedule model)
        {
            return scheduleDAL.Add(model);
        }

        public ClassSchedule Get(int id)
        {
            throw new NotImplementedException();
        }

        public ClassSchedule Get(ClassSchedule model)
        {
            throw new NotImplementedException();
        }

        public List<ClassSchedule> GetAll()
        {
            return scheduleDAL.GetAll();
        }

        public bool Remove(ClassSchedule model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            return scheduleDAL.Remove(id);
        }

        public bool Update(ClassSchedule model)
        {
            throw new NotImplementedException();
        }
    }
}
