using System.Data.SqlClient;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseConvertTopic<T>
    {
        T ToObjectTopic(SqlDataReader reader);
        T ToObjectAbsence(SqlDataReader reader);
        T ToObjectComment(SqlDataReader reader);
    }
}
