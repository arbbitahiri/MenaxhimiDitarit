using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.DAL;

namespace MenaxhimiDitarit.BLL
{
    public class AdministrationBLL
    {
        private static UserDAL usersDAL = new UserDAL();

        public static User Login(string username, string password)
        {
            return usersDAL.Login(username, password);
        }
    }
}
