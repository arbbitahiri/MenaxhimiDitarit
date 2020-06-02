﻿using System;
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
    public class TopicsDAL : IBaseCRUDTopic<Topic>, IBaseConvertTopic<Topic>
    {
        #region Topic
        public bool AddTopic(Topic model)
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
                        DataConnection.AddParameter(command, "LUB", model.LUB);
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

        public List<Topic> GetAllTopic()
        {
            try
            {
                List<Topic> MyTopics = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Topics_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyTopics = new List<Topic>();
                            while (reader.Read())
                            {
                                var topic = ToObjectTopic(reader);
                                if (reader["Class_No"] != DBNull.Value && reader["Subject_Title"] != DBNull.Value)
                                {
                                    topic.Class = new Class { ClassNo = int.Parse(reader["Class_No"].ToString()) };
                                    topic.Subject = new Subject { SubjectTitle = reader["Subject_Title"].ToString() };
                                }
                                MyTopics.Add(topic);
                            }
                        }
                    }
                }
                return MyTopics;
            }
            catch (Exception)
            {

                throw;

            }
        }

        public bool RemoveTopic(int id)
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

        public Topic ToObjectTopic(SqlDataReader reader)
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
        #endregion

        #region Absence
        public bool AddAbsence(Topic model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Absence_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "topicID", model.TopicID);
                        DataConnection.AddParameter(command, "classID", model.ClassID);
                        DataConnection.AddParameter(command, "subjectID", model.SubjectID);
                        DataConnection.AddParameter(command, "date", model.Date);
                        DataConnection.AddParameter(command, "time", model.Time);
                        DataConnection.AddParameter(command, "absencereasoning", model.Reasoning);
                        DataConnection.AddParameter(command, "nostudents_absence", model.NoStudents);
                        DataConnection.AddParameter(command, "LUN", model.LUN);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
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

        public List<Topic> GetAllAbsence()
        {
            try
            {
                List<Topic> MyAbsences = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Absence_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyAbsences = new List<Topic>();
                            while (reader.Read())
                            {
                                var topic = ToObjectAbsence(reader);
                                if (reader["Class_No"] != DBNull.Value && reader["Subject_Title"] != DBNull.Value)
                                {
                                    topic.Class = new Class { ClassNo = int.Parse(reader["Class_No"].ToString()) };
                                    topic.Subject = new Subject { SubjectTitle = reader["Subject_Title"].ToString() };
                                }
                                MyAbsences.Add(topic);
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

        public Topic ToObjectAbsence(SqlDataReader reader)
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

                if (reader["AbsenceReasoning"] != DBNull.Value)
                    topic.Reasoning = reader["AbsenceReasoning"].ToString();

                if (reader["NoStudents_Absence"] != DBNull.Value)
                    topic.NoStudents = int.Parse(reader["NoStudents_Absence"].ToString());

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
        #endregion

        #region Comment
        public bool AddComment(Topic model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Comment_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "topicID", model.TopicID);
                        DataConnection.AddParameter(command, "classID", model.ClassID);
                        DataConnection.AddParameter(command, "subjectID", model.SubjectID);
                        DataConnection.AddParameter(command, "date", model.Date);
                        DataConnection.AddParameter(command, "time", model.Time);
                        DataConnection.AddParameter(command, "comment", model.Comment);
                        DataConnection.AddParameter(command, "LUN", model.LUN);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception e)
            {
                string t = e.Message;
                return false;
            }
        }

        public List<Topic> GetAllComment()
        {
            try
            {
                List<Topic> MyComments = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Comment_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyComments = new List<Topic>();
                            while (reader.Read())
                            {
                                var topic = ToObjectComment(reader);
                                if (reader["Class_No"] != DBNull.Value && reader["Subject_Title"] != DBNull.Value)
                                {
                                    topic.Class = new Class { ClassNo = int.Parse(reader["Class_No"].ToString()) };
                                    topic.Subject = new Subject { SubjectTitle = reader["Subject_Title"].ToString() };
                                }
                                MyComments.Add(topic);
                            }
                        }
                    }
                }
                return MyComments;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Topic ToObjectComment(SqlDataReader reader)
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

                if (reader["Comment"] != DBNull.Value)
                    topic.Comment = reader["Comment"].ToString();

                if (reader["Review"] != DBNull.Value)
                    topic.Review = reader["Review"].ToString();

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
        #endregion

        public bool UpdateTopic(Topic model)
        {
            throw new NotImplementedException();
        }

        public Topic GetTopic(int id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAbsence(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAbsence(Topic model)
        {
            throw new NotImplementedException();
        }


        public Topic GetAbsence(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateComment(Topic model)
        {
            throw new NotImplementedException();
        }

        public Topic GetComment(int id)
        {
            throw new NotImplementedException();
        }
    }
}
