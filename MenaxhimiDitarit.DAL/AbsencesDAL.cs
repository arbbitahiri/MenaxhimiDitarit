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
    public class AbsencesDAL : IBaseCRUD<Absence>, IBaseConvert<Absence>
    {
        public bool Add(Absence model)
        {
            throw new NotImplementedException();
        }

        public Absence Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Absence> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Absence ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Absence model)
        {
            throw new NotImplementedException();
        }
    }
}
