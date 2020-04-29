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
    public class UserBLL : IBaseCRUD<User>
    {
        private UserDAL dal;

        public UserBLL()
        {
            dal = new UserDAL();
        }

        public bool Add(User model)
        {
            return dal.Add(model);
        }

        public User Get(int id)
        {
            return dal.Get(id);
        }

        public List<User> GetAll()
        {
            return dal.GetAll();
        }

        public bool Remove(int id)
        {
            return dal.Remove(id);
        }

        public bool Update(User model)
        {
            return dal.Update(model);
        }
    }
}
