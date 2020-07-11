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
                                var absence = ToObjectAbsence(reader);
                                if (reader["Class_No"] != DBNull.Value && reader["Subject_Title"] != DBNull.Value)
                                {
                                    absence.Class = new Class { ClassNo = int.Parse(reader["Class_No"].ToString()) };
                                    absence.Subject = new Subject { SubjectTitle = reader["Subject_Title"].ToString() };
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

        public Topic ToObjectAbsence(SqlDataReader reader)
        {
            try
            {
                var absence = new Topic();

                if (reader["TopicID"] != DBNull.Value)
                    absence.TopicID = int.Parse(reader["TopicID"].ToString());

                if (reader["ClassID"] != DBNull.Value)
                    absence.ClassID = int.Parse(reader["ClassID"].ToString());

                if (reader["SubjectID"] != DBNull.Value)
                    absence.SubjectID = int.Parse(reader["SubjectID"].ToString());

                if (reader["Date"] != DBNull.Value)
                    absence.Date = DateTime.Parse(reader["Date"].ToString());

                if (reader["Time"] != DBNull.Value)
                    absence.Time = int.Parse(reader["Time"].ToString());

                if (reader["AbsenceReasoning"] != DBNull.Value)
                    absence.Reasoning = reader["AbsenceReasoning"].ToString();

                if (reader["NoStudents_Absence"] != DBNull.Value)
                    absence.NoStudents = int.Parse(reader["NoStudents_Absence"].ToString());

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

        public bool UpdateComment(Topic model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Review";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "topicID", model.TopicID);
                        DataConnection.AddParameter(command, "review", model.Review);
                        DataConnection.AddParameter(command, "reviewdate", model.ReviewDate);
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
                                var comment = ToObjectComment(reader);
                                if (reader["Class_No"] != DBNull.Value && reader["Subject_Title"] != DBNull.Value)
                                {
                                    comment.Class = new Class { ClassNo = int.Parse(reader["Class_No"].ToString()) };
                                    comment.Subject = new Subject { SubjectTitle = reader["Subject_Title"].ToString() };
                                }
                                MyComments.Add(comment);
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

        public List<Topic> GetAllReview()
        {
            try
            {
                List<Topic> MyReviews = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Review_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyReviews = new List<Topic>();
                            while (reader.Read())
                            {
                                var review = ToObjectComment(reader);
                                if (reader["Class_No"] != DBNull.Value && reader["Subject_Title"] != DBNull.Value)
                                {
                                    review.Class = new Class { ClassNo = int.Parse(reader["Class_No"].ToString()) };
                                    review.Subject = new Subject { SubjectTitle = reader["Subject_Title"].ToString() };
                                }
                                MyReviews.Add(review);
                            }
                        }
                    }
                }
                return MyReviews;
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
                var comment = new Topic();

                if (reader["TopicID"] != DBNull.Value)
                    comment.TopicID = int.Parse(reader["TopicID"].ToString());

                if (reader["ClassID"] != DBNull.Value)
                    comment.ClassID = int.Parse(reader["ClassID"].ToString());

                if (reader["SubjectID"] != DBNull.Value)
                    comment.SubjectID = int.Parse(reader["SubjectID"].ToString());

                if (reader["Date"] != DBNull.Value)
                    comment.Date = DateTime.Parse(reader["Date"].ToString());

                if (reader["Time"] != DBNull.Value)
                    comment.Time = int.Parse(reader["Time"].ToString());

                if (reader["Comment"] != DBNull.Value)
                    comment.Comment = reader["Comment"].ToString();

                if (reader["Review"] != DBNull.Value)
                    comment.Review = reader["Review"].ToString();

                if (reader["InsertBy"] != DBNull.Value)
                    comment.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    comment.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    comment.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    comment.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    comment.LUN = int.Parse(reader["LUN"].ToString());

                return comment;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Staff Absence
        public bool AddStaffAbsence(Topic model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Staff_Absence";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "topicID", model.TopicID);
                        DataConnection.AddParameter(command, "absencedate", model.Date);
                        DataConnection.AddParameter(command, "LUN", model.LUN);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "reasoning", model.StaffAbsenceReasoning);
                        DataConnection.AddParameter(command, "userID", model.UserID);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception e)
            {
                string eee = e.Message;
                return false;
            }
        }

        public List<Topic> GetAllStaffAbsence()
        {
            try
            {
                List<Topic> MyAbsences = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Staf_Absence_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyAbsences = new List<Topic>();
                            while (reader.Read())
                            {
                                var staffAbsence = ToObjectStaff(reader);
                                if (reader["First_Name"] != DBNull.Value && reader["Last_Name"] != DBNull.Value)
                                {
                                    staffAbsence.User = new User { FirstName = reader["First_Name"].ToString(), LastName = reader["Last_Name"].ToString() };
                                }
                                MyAbsences.Add(staffAbsence);
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

        public Topic ToObjectStaff(SqlDataReader reader)
        {
            try
            {
                var staffAbsence = new Topic();

                if (reader["TopicID"] != DBNull.Value)
                    staffAbsence.TopicID = int.Parse(reader["TopicID"].ToString());

                if (reader["Date"] != DBNull.Value)
                    staffAbsence.Date = DateTime.Parse(reader["Date"].ToString());

                if (reader["InsertBy"] != DBNull.Value)
                    staffAbsence.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    staffAbsence.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    staffAbsence.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    staffAbsence.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    staffAbsence.LUN = int.Parse(reader["LUN"].ToString());
                
                if (reader["UserID"] != DBNull.Value)
                    staffAbsence.UserID = int.Parse(reader["UserID"].ToString());

                if (reader["StaffAbsenceReason"] != DBNull.Value)
                    staffAbsence.StaffAbsenceReasoning = reader["StaffAbsenceReason"].ToString();

                return staffAbsence;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
