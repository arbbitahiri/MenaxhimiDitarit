using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Topic:BaseAuditObject
    {
        public int TopicID { get; set; }
        public int ClassID { get; set; }
        public int SubjectID { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public string Content { get; set; }
    }
}
