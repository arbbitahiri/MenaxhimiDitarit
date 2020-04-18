using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    class Klasa:BaseAuditObject
    {
        public int KlasaID { get; set; }
        public int ArsimtaretID { get; set; }
        public int VitiMesimor { get; set; }
        public int SallaID { get; set; }
    }
}
