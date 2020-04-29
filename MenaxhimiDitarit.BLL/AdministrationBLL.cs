﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.DAL;

namespace MenaxhimiDitarit.BLL
{
    public class AdministrationBLL
    {
        private static UserDAL usersDAL = new UserDAL();

        public static User Login(string username, string password, DateTime lastlogindate)
        {
            return usersDAL.Login(username, password, lastlogindate);
        }
    }
}