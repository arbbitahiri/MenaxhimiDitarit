using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseConvertUser<T>
    {
        T ToObjectUser(SqlDataReader reader);
        T ToObjectStaff(SqlDataReader reader);
    }
}
