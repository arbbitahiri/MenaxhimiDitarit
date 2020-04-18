using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Arsimtaret:BaseAuditObject
    {
        public int ArsimtaretID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }
        public string Gjinia { get; set; }
        public string Adresa { get; set; }
        public string Kualifikimi { get; set; }
        public DateTime DataLindjes { get; set; }
        public string Email { get; set; }
        public string NrTelefonit { get; set; }
    }
}
