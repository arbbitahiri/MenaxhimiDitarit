using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseConvertTopic<T>
    {
        T ToObjectTopic(SqlDataReader reader);
        T ToObjectAbsence(SqlDataReader reader);
        T ToObjectComment(SqlDataReader reader);
    }
}
