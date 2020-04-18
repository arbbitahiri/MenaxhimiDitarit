using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MenaxhimiDitarit.BO.Interface
{
    public interface IBaseConvert<T>
    {
        T ToObject(SqlDataReader reader);
    }
}
