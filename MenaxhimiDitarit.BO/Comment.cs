using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Comment:BaseAuditObject
    {
        public int CommentID { get; set; }
        public int TopicID { get; set; }
        public string Comments { get; set; }
        public string Review { get; set; }
    }
}
