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
    public class CommentsDAL : IBaseConvert<Comment>, IBaseCRUD<Comment>
    {
        public bool Add(Comment model)
        {
            throw new NotImplementedException();
        }

        public Comment Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Comment ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Comment model)
        {
            throw new NotImplementedException();
        }
    }
}
