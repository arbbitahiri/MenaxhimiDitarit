using System.Data.SqlClient;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseConvertUser<T>
    {
        T ToObjectUser(SqlDataReader reader);
        T ToObjectStaff(SqlDataReader reader);
    }
}
