using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;

namespace MenaxhimiDitarit.DAL
{
    public class TopicsDAL : IBaseCRUD<Topic>, IBaseConvert<Topic>
    {
        public bool Add(Topic model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Topic_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "topicID", model.TopicID);
                        DataConnection.AddParameter(command, "classID", model.ClassID);
                        DataConnection.AddParameter(command, "subjectID", model.SubjectID);
                        DataConnection.AddParameter(command, "date", model.Date);
                        DataConnection.AddParameter(command, "time", model.Time);
                        DataConnection.AddParameter(command, "content", model.Content);
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
            catch (Exception e)
            {
                string rerrr = e.Message;

                return false;
            }
        }

        public Topic Get(int id)
        {
            throw new NotImplementedException();
        }

        public Topic Get(Topic model)
        {
            throw new NotImplementedException();
        }

        public List<Topic> GetAll()
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    List<Topic> topic = null;
                    string sqlproc = "dbo.usp_Topics_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            topic = new List<Topic>();
                            while (reader.Read())
                                topic.Add(ToObject(reader));
                        }

                        return topic;
                    }
                }
            }
            catch (Exception)
            {

                throw;

            }
        }

        public bool Remove(Topic model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Topic_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "topicID", id);

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

        public Topic ToObject(SqlDataReader reader)
        {
            try
            {
                var topic = new Topic();

                if (reader["TopicID"] != DBNull.Value)
                    topic.TopicID = int.Parse(reader["TopicID"].ToString());

                if (reader["ClassID"] != DBNull.Value)
                    topic.ClassID = int.Parse(reader["ClassID"].ToString());

                if (reader["SubjectID"] != DBNull.Value)
                    topic.SubjectID = int.Parse(reader["SubjectID"].ToString());

                if (reader["Date"] != DBNull.Value)
                    topic.Date = DateTime.Parse(reader["Date"].ToString());

                if (reader["Time"] != DBNull.Value)
                    topic.Time = int.Parse(reader["Time"].ToString());

                if (reader["Content"] != DBNull.Value)
                    topic.Content = reader["Content"].ToString();

                if (reader["InsertBy"] != DBNull.Value)
                    topic.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    topic.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    topic.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    topic.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    topic.LUN = int.Parse(reader["LUN"].ToString());

                return topic;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Topic model)
        {
            throw new NotImplementedException();
        }
    }
}
