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
    public class ClassDAL : IBaseConvert<Class>, IBaseCRUD<Class>
    {
        public bool Add(Class model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Class_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "classID", model.ClassID);
                        DataConnection.AddParameter(command, "teacherID", model.TeacherID);
                        DataConnection.AddParameter(command, "classno", model.ClassNo);
                        DataConnection.AddParameter(command, "roomID", model.RoomID);
                        DataConnection.AddParameter(command, "LUN", model.LUN);
                        DataConnection.AddParameter(command, "LUD", model.LUD);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "insertdate", model.InsertDate);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);

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

        public List<Class> GetAll()
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    List<Class> classes = null;
                    string sqlproc = "dbo.usp_Classes_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            classes = new List<Class>();
                            while (reader.Read())
                                classes.Add(ToObject(reader));
                        }

                        return classes;
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
                    string sqlproc = "dbo.usp_Class_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "classID", id);

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

        public Class ToObject(SqlDataReader reader)
        {
            try
            {
                var classes = new Class();

                if (reader["ClassID"] != DBNull.Value)
                    classes.ClassID = int.Parse(reader["ClassID"].ToString());

                if (reader["TeacherID"] != DBNull.Value)
                    classes.TeacherID = int.Parse(reader["TeacherID"].ToString());

                if (reader["Class_No"] != DBNull.Value)
                    classes.ClassNo = int.Parse(reader["Class_No"].ToString());

                if (reader["RoomID"] != DBNull.Value)
                    classes.RoomID = int.Parse(reader["RoomID"].ToString());

                if (reader["InsertBy"] != DBNull.Value)
                    classes.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    classes.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    classes.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    classes.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    classes.LUN = int.Parse(reader["LUN"].ToString());

                return classes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Class Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Class model)
        {
            throw new NotImplementedException();
        }
    }
}
