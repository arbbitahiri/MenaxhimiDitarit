﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Roles:BaseAuditObject
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
