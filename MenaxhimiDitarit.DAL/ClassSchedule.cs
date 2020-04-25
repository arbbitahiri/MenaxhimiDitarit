using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;

namespace MenaxhimiDitarit.DAL
{
    public class ClassSchedule : IBaseCRUD<ClassSchedule>, IBaseConvert<ClassSchedule>
    {
        public bool Add(ClassSchedule model)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool Remove(ClassSchedule model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public ClassSchedule ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Update(ClassSchedule model)
        {
            throw new NotImplementedException();
        }
    }
}
