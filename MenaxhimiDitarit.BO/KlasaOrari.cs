using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    class KlasaOrari:BaseAuditObject
    {
        public int OrariID { get; set; }
        public int KlasaID { get; set; }
        public int LendaID { get; set; }
        public int OraMesimore { get; set; }
        public DateTime Dita { get; set; }
        public DateTime VitiShkollor { get; set; }
    }
}
