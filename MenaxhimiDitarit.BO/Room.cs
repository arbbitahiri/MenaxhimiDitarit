using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Room:BaseAuditObject
    {
        public int RoomID { get; set; }
        public int RoomNo { get; set; }
        public string RoomType { get; set; }

        public override string ToString()
        {
            return RoomType;
        }
    }
}
