using System;

namespace MenaxhimiDitarit.BO
{
    public class User:BaseAuditObject
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public DateTime ExpiresDate { get; set; }
        public int RoleID { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastPasswordChangeDate { get; set; }
        public bool IsPasswordChanged { get; set; }
        public DateTime StaffAbsenceDate { get; set; }
        public string StaffAbsenceReasoning { get; set; }
        public int TeacherID { get; set; }

        public virtual Teacher Teachers { get; set; }
        public virtual Role Roles { get; set; }

        public string FullName {
            get {
                return FirstName + " " + LastName;
            }
        }
    }
}
