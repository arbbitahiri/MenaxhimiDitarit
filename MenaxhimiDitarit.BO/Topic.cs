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
        public string Reasoning { get; set; }
        public int NoStudents { get; set; }
        public string Comment { get; set; }
        public string Review { get; set; }
        public DateTime ReviewDate { get; set; }

        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
