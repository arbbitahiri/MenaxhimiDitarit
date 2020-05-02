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
    public class SubjectDAL : IBaseConvert<Subject>, IBaseCRUD<Subject>
    {
        public bool Add(Subject model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Subject_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "subjectID", model.SubjectID);
                        DataConnection.AddParameter(command, "subjecttitle", model.SubjectTitle);
                        DataConnection.AddParameter(command, "book", model.Book);
                        DataConnection.AddParameter(command, "bookauthor", model.Book_Author);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "LUN", model.LUN);
                        DataConnection.AddParameter(command, "teacherID", model.TeacherID);


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

        public List<Subject> GetAll()
        {
            try
            {
                List<Subject> MySubjects = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Subject_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MySubjects = new List<Subject>();
                            while (reader.Read())
                            {
                                var subject = ToObject(reader);
                                if (reader["First_Name"] != DBNull.Value && reader["Last_Name"] != DBNull.Value)
                                {
                                    subject.Teacher = new Teacher
                                    {
                                        FirstName = reader["First_Name"].ToString(),
                                        LastName = reader["Last_Name"].ToString()
                                    };
                                }
                                MySubjects.Add(subject);
                            }
                        }
                    }
                }
                return MySubjects;
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
                    string sqlproc = "dbo.usp_Subject_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "subjectID", id);

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

        public Subject ToObject(SqlDataReader reader)
        {
            try
            {
                var subject = new Subject();

                if (reader["SubjectID"] != DBNull.Value)
                    subject.SubjectID = int.Parse(reader["SubjectID"].ToString());

                if (reader["Subject_Title"] != DBNull.Value)
                    subject.SubjectTitle = reader["Subject_Title"].ToString();

                if (reader["Book"] != DBNull.Value)
                    subject.Book = reader["Book"].ToString();

                if (reader["Book_Author"] != DBNull.Value)
                    subject.Book_Author = reader["Book_Author"].ToString();

                if (reader["InsertBy"] != DBNull.Value)
                    subject.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    subject.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    subject.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    subject.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    subject.LUN = int.Parse(reader["LUN"].ToString());

                if (reader["TeacherID"] != DBNull.Value)
                    subject.TeacherID = int.Parse(reader["TeacherID"].ToString());

                return subject;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Subject Get(int id)
        {
            throw new NotImplementedException();
        }


        public bool Update(Subject model)
        {
            throw new NotImplementedException();
        }
    }
}
