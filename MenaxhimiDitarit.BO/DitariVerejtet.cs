using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    class DitariVerejtet:BaseAuditObject
    {
        public int VerejtetID { get; set; }
        public int TemaID { get; set; }
        public string Verejtja { get; set; }
        public string Shqyrtimi { get; set; }
    }
}
