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
    public class UsersBLL : IBaseCRUD<Users>
    {
        private UsersDAL dal;

        public UsersBLL()
        {
            dal = new UsersDAL();
        }

        public bool Add(Users model)
        {
            return dal.Add(model);
        }

        public Users Get(int id)
        {
            return dal.Get(id);
        }

        public Users Get(Users model)
        {
            return dal.Get(model);
        }

        public List<Users> GetAll()
        {
            return dal.GetAll();
        }

        public bool Remove(Users model)
        {
            return dal.Remove(model);
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Update(Users model)
        {
            return dal.Update(model);
        }
    }
}
