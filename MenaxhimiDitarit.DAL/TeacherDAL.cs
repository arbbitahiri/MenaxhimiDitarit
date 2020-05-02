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
    public class TeacherDAL : IBaseCRUD<Teacher>, IBaseConvert<Teacher>
    {
        public bool Add(Teacher model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Teacher_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "teacherID", model.TeacherID);
                        DataConnection.AddParameter(command, "firstname", model.FirstName);
                        DataConnection.AddParameter(command, "lastname", model.LastName);
                        DataConnection.AddParameter(command, "gender", model.Gender);
                        DataConnection.AddParameter(command, "city", model.City);
                        DataConnection.AddParameter(command, "qualification", model.Qualification);
                        DataConnection.AddParameter(command, "dayofbirth", model.DayofBirth);
                        DataConnection.AddParameter(command, "email", model.Email);
                        DataConnection.AddParameter(command, "phoneno", model.PhoneNo);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "LUN", model.LUN);


                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;

                return false;
            }
        }

        public List<Teacher> GetAll()
        {
            try
            {
                List<Teacher> MyTeachers = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Teachers_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyTeachers = new List<Teacher>();
                            while (reader.Read())
                                MyTeachers.Add(ToObject(reader));
                        }
                    }
                }
                return MyTeachers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Teacher ToObject(SqlDataReader reader)
        {
            try
            {
                var teacher = new Teacher();

                if (reader["TeacherID"] != DBNull.Value)
                    teacher.TeacherID = int.Parse(reader["TeacherID"].ToString());

                if (reader["First_Name"] != DBNull.Value)
                    teacher.FirstName = reader["First_Name"].ToString();

                if (reader["Last_Name"] != DBNull.Value)
                    teacher.LastName = reader["Last_Name"].ToString();

                if (reader["Gender"] != DBNull.Value)
                    teacher.Gender = reader["Gender"].ToString();

                if (reader["City"] != DBNull.Value)
                    teacher.City = reader["City"].ToString();

                if (reader["Qualification"] != DBNull.Value)
                    teacher.Qualification = reader["Qualification"].ToString();

                if (reader["Day_of_Birth"] != DBNull.Value)
                    teacher.DayofBirth = DateTime.Parse(reader["Day_of_Birth"].ToString());

                if (reader["Email"] != DBNull.Value)
                    teacher.Email = reader["Email"].ToString();

                if (reader["Phone_No"] != DBNull.Value)
                    teacher.PhoneNo = reader["Phone_No"].ToString();

                if (reader["InsertBy"] != DBNull.Value)
                    teacher.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    teacher.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    teacher.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    teacher.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    teacher.LUN = int.Parse(reader["LUN"].ToString());

                return teacher;
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
                    string sqlproc = "dbo.usp_Teachers_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "teacherID", id);

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

        public Teacher Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Teacher model)
        {
            throw new NotImplementedException();
        }
    }
}
