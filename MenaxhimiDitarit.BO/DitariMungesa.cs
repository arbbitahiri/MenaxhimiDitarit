using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    class DitariMungesa:BaseAuditObject
    {
        public int MungesaID { get; set; }
        public int TemaID { get; set; }
        public string Arsyetimi { get; set; }
        public int NrNxenesve { get; set; }
    }
}
