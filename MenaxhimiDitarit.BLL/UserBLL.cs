using System.Collections.Generic;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;
using MenaxhimiDitarit.DAL;

namespace MenaxhimiDitarit.BLL
{
    public class UserBLL : IBaseCRUDUser<User>
    {
        private UserDAL userDAL;

        public UserBLL()
        {
            userDAL = new UserDAL();
        }

        #region User
        public bool AddUser(User model)
        {
            return userDAL.AddUser(model);
        }

        public List<User> GetAllUser()
        {
            return userDAL.GetAllUser();
        }

        public bool RemoveUser(int id)
        {
            return userDAL.RemoveUser(id);
        }

        public bool UpdateUser(User model)
        {
            return userDAL.UpdateUser(model);
        }
        #endregion

        #region Staff Absence
        public bool AddStaffAbsence(User model)
        {
            return userDAL.AddStaffAbsence(model);
        }

        public List<User> GetAllStaffAbsence()
        {
            return userDAL.GetAllStaffAbsence();
        }
        #endregion
    }
}
