using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Users:BaseAuditObject
    {
        public int UserID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime ExpiresDate { get; set; }
        public int RoleID { get; set; }
    }
}
