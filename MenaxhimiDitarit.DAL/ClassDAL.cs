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
    public class ClassDAL : IBaseConvert<Class>, IBaseCRUD<Class>
    {
        public bool Add(Class model)
        {
            throw new NotImplementedException();
        }

        public Class Get(int id)
        {
            throw new NotImplementedException();
        }

        public Class Get(Class model)
        {
            throw new NotImplementedException();
        }

        public List<Class> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Class model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Class ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Class model)
        {
            throw new NotImplementedException();
        }
    }
}
