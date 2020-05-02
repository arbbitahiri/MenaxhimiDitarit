using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO
{
    public class Teacher:BaseAuditObject
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Qualification { get; set; }
        public DateTime DayofBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }

        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
