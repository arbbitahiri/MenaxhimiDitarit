using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class BaseAuditObject
    {
        public string InsertBy { get; set; }
        public string InsertDate { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
        public int UpdateNo { get; set; }
    }
}
