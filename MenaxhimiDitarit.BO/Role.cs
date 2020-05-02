using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Role:BaseAuditObject
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public override string ToString()
        {
            return RoleName;
        }
    }
}
