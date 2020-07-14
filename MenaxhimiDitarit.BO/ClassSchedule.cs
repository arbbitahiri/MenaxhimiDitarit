namespace MenaxhimiDitarit.BO
{
    public class ClassSchedule:BaseAuditObject
    {
        public int ScheduleID { get; set; }
        public int ClassID { get; set; }
        public int SubjectID { get; set; }
        public int Time { get; set; }
        public string Day { get; set; }
        public int Year { get; set; }

        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
