using System.Data.SqlClient;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseConvert<T>
    {
        T ToObject(SqlDataReader reader);
    }
}
