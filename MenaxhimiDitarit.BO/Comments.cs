using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Comments:BaseAuditObject
    {
        public int CommentID { get; set; }
        public int TopicID { get; set; }
        public string Comment { get; set; }
        public string Review { get; set; }
    }
}
