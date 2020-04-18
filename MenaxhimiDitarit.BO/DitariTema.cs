using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    class DitariTema:BaseAuditObject
    {
        public int TemaID { get; set; }
        public int KlasaID { get; set; }
        public int LendaID { get; set; }
        public DateTime Data { get; set; }
        public DateTime Ora { get; set; }
        public string Permbajtja { get; set; }
    }
}
