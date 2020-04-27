using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Absence:BaseAuditObject
    {
        public int AbsencesID { get; set; }
        public int TopicID { get; set; }
        public string Reasoning { get; set; }
        public int NoStudents { get; set; }

        public virtual Topic Topic { get; set; }
    }
}
