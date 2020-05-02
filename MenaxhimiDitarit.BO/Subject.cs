using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Subject:BaseAuditObject
    {
        public int SubjectID { get; set; }
        public string SubjectTitle { get; set; }
        public string Book { get; set; }
        public string Book_Author { get; set; }
        public int TeacherID { get; set; }

        public virtual Teacher Teacher { get; set; }

        public override string ToString()
        {
            return SubjectTitle;
        }
    }
}
