using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Room_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "roomID", model.RoomID);
                        DataConnection.AddParameter(command, "roomno", model.RoomNo);
                        DataConnection.AddParameter(command, "roomtype", model.RoomType);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "LUN", model.LUN);


                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Room> GetAll()
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    List<Room> room = null;
                    string sqlproc = "dbo.usp_Rooms_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            room = new List<Room>();
                            while (reader.Read())
                                room.Add(ToObject(reader));
                        }

                        return room;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Room_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "roomID", id);

                        int result = command.ExecuteNonQuery();

                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Room ToObject(SqlDataReader reader)
        {
            try
            {
                var room = new Room();

                if (reader["RoomID"] != DBNull.Value)
                    room.RoomID = int.Parse(reader["RoomID"].ToString());

                if (reader["Room_No"] != DBNull.Value)
                    room.RoomNo = int.Parse(reader["Room_No"].ToString());

                if (reader["Room_Type"] != DBNull.Value)
                    room.RoomType = reader["Room_Type"].ToString();

                if (reader["InsertBy"] != DBNull.Value)
                    room.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    room.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    room.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    room.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    room.LUN = int.Parse(reader["LUN"].ToString());

                return room;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Room Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Room model)
        {
            throw new NotImplementedException();
        }
    }
}
