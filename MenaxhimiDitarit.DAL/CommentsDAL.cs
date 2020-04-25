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
    public class CommentsDAL : IBaseConvert<Comments>, IBaseCRUD<Comments>
    {
        public bool Add(Comments model)
        {
            throw new NotImplementedException();
        }

        public Comments Get(int id)
        {
            throw new NotImplementedException();
        }

        public Comments Get(Comments model)
        {
            throw new NotImplementedException();
        }

        public List<Comments> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Comments model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Comments ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Comments model)
        {
            throw new NotImplementedException();
        }
    }
}
