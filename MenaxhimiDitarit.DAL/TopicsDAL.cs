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
    public class TopicsDAL : IBaseCRUD<Topics>, IBaseConvert<Topics>
    {
        public bool Add(Topics model)
        {
            throw new NotImplementedException();
        }

        public Topics Get(int id)
        {
            throw new NotImplementedException();
        }

        public Topics Get(Topics model)
        {
            throw new NotImplementedException();
        }

        public List<Topics> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Topics model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Topics ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Topics model)
        {
            throw new NotImplementedException();
        }
    }
}
