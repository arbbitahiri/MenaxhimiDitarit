using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;

namespace MenaxhimiDitarit.DAL
{
    public class RoomDAL : IBaseCRUD<Room>, IBaseConvert<Room>
    {
        public bool Add(Room model)
        {
            throw new NotImplementedException();
        }

        public Room Get(int id)
        {
            throw new NotImplementedException();
        }

        public Room Get(Room model)
        {
            throw new NotImplementedException();
        }

        public List<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Room model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Room ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }

        public bool Update(Room model)
        {
            throw new NotImplementedException();
        }
    }
}
