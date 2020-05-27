using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;
using System.Data;

namespace MenaxhimiDitarit.DAL
{
    public class AbsencesDAL : IBaseCRUD<Absence>, IBaseConvert<Absence>
    {
        public bool Add(Absence model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlProc = "dbo.usp_Absence_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlProc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "absenceID", model.AbsencesID);
                        DataConnection.AddParameter(command, "topicID", model.TopicID);
                        DataConnection.AddParameter(command, "reasoning", model.Reasoning);
                        DataConnection.AddParameter(command, "nostudents", model.NoStudents);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "LUN", model.LUN);
                        DataConnection.AddParameter(command, "LUB", model.LUB);

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

        public List<Absence> GetAll()
        {
            try
            {
                List<Absence> MyAbsences = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlProc = "dbo.usp_Absence_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlProc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyAbsences = new List<Absence>();
                            while (reader.Read())
                            {
                                var absence = ToObject(reader);
                                if (reader["Subject_Title"] != DBNull.Value && reader["Class_No"] != DBNull.Value && reader["Time"] != DBNull.Value)
                                {
                                    absence.Topic.Subject = new Subject { SubjectTitle = reader["Subject_Title"].ToString() };
                                    absence.Topic.Class = new Class { ClassNo = int.Parse(reader["Class_No"].ToString()) };
                                    absence.Topic = new Topic { Time = int.Parse(reader["Time"].ToString()) };
                                }

                                MyAbsences.Add(absence);
                            }
                        }
                    }
                }

                return MyAbsences;
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
                    string sqlProc = "dbo.usp_Absence_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlProc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "absenceID", id);

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

        public bool Update(Absence model)
        {
            throw new NotImplementedException();
        }

        public Absence ToObject(SqlDataReader reader)
        {
            try
            {
                var absence = new Absence();

                if (reader["AbsenceID"] != DBNull.Value)
                    absence.AbsencesID = int.Parse(reader["AbsenceID"].ToString());

                if (reader["TopicID"] != DBNull.Value)
                    absence.TopicID = int.Parse(reader["TopicID"].ToString());

                if (reader["Reasoning"] != DBNull.Value)
                    absence.Reasoning = reader["Reasoning"].ToString();

                if (reader["No_Students"] != DBNull.Value)
                    absence.NoStudents = int.Parse(reader["No_Students"].ToString());

                if (reader["InsertBy"] != DBNull.Value)
                    absence.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    absence.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    absence.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    absence.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    absence.LUN = int.Parse(reader["LUN"].ToString());

                return absence;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Absence Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
