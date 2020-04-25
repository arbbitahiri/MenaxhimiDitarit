using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    class ClassSchedule:BaseAuditObject
    {
        public int ScheduleID { get; set; }
        public int ClassID { get; set; }
        public int SubjectID { get; set; }
        public int Time { get; set; }
        public DateTime Date { get; set; }
        public DateTime Year { get; set; }
    }
}
