using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class User:BaseAuditObject
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime ExpiresDate { get; set; }
        public int RoleID { get; set; }

        public Role Roles { get; set; }

        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }
    }
}
