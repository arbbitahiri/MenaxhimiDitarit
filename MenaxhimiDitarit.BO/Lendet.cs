using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    class Lendet:BaseAuditObject
    {
        public int LendetID { get; set; }
        public string EmriLendes { get; set; }
        public string Libri { get; set; }
        public string AutoriLibrit { get; set; }
    }
}
