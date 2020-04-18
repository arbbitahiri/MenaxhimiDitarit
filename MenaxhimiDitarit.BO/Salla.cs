using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    class Salla:BaseAuditObject
    {
        public int SallaID { get; set; }
        public int NrSalles { get; set; }
        public string Tipi { get; set; }
    }
}
