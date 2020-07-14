namespace MenaxhimiDitarit.BO
{
    public class Role:BaseAuditObject
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public override string ToString()
        {
            return RoleName;
        }
    }
}
