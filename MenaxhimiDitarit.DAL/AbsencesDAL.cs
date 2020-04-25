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
    public class AbsencesDAL : IBaseCRUD<Absences>, IBaseConvert<Absences>
    {
        public bool Add(Absences model)
        {
            throw new NotImplementedException();
        }

        public Absences Get(int id)
        {
            throw new NotImplementedException();
        }

        public Absences Get(Absences model)
        {
            throw new NotImplementedException();
        }

        public List<Absences> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Absences model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Absences ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Absences model)
        {
            throw new NotImplementedException();
        }
    }
}
