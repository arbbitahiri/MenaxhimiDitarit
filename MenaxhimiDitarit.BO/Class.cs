using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Class:BaseAuditObject
    {
        public int ClassID { get; set; }
        public int TeacherID { get; set; }
        public int ClassNo { get; set; }
        public int RoomID { get; set; }
    }
}
