using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;

namespace MenaxhimiDitarit.DAL
{
    public class UserDAL : IBaseConvertUser<User>, IBaseCRUDUser<User>
    {
        public User Login(string username, string password)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Authenticate";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "username", username);
                        DataConnection.AddParameter(command, "password", password);

                        using (var reader = command.ExecuteReader())
                        {
                            User result = null;
                            while (reader.Read())
                                result = ToObjectUser(reader);

                            return result;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #region User
        public bool AddUser(User model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_User_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "userID", model.UserID);
                        DataConnection.AddParameter(command, "username", model.UserName);
                        DataConnection.AddParameter(command, "userpassword", model.UserPassword);
                        DataConnection.AddParameter(command, "expiresdate", model.ExpiresDate);
                        DataConnection.AddParameter(command, "roleID", model.RoleID);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "LUN", model.LUN);
                        DataConnection.AddParameter(command, "firstname", model.FirstName);
                        DataConnection.AddParameter(command, "lastname", model.LastName);

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

        public List<User> GetAllUser()
        {
            try
            {
                List<User> MyUsers = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Users_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyUsers = new List<User>();
                            while (reader.Read())
                            {
                                var user = ToObjectUser(reader);
                                if (reader["RoleName"] != DBNull.Value)
                                {
                                    user.Roles = new Role { RoleName = reader["RoleName"].ToString() };
                                }
                                MyUsers.Add(user);
                            }
                        }
                    }
                }
                return MyUsers;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool RemoveUser(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Users_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "UserID", id);

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

        public bool UpdateUser(User model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_User_ChangePassword";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "userID", model.UserID);
                        DataConnection.AddParameter(command, "userpass", model.UserPassword);
                        DataConnection.AddParameter(command, "ispasswordchanged", model.IsPasswordChanged);
                        DataConnection.AddParameter(command, "lastpasswordchangedate", model.LastPasswordChangeDate);
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

        public User ToObjectUser(SqlDataReader reader)
        {
            try
            {
                var user = new User();

                if (reader["UserID"] != DBNull.Value)
                    user.UserID = int.Parse(reader["UserID"].ToString());

                if (reader["UserName"] != DBNull.Value)
                    user.UserName = reader["UserName"].ToString();

                if (reader["UserPass"] != DBNull.Value)
                    user.UserPassword = reader["UserPass"].ToString();

                if (reader["ExpiresDate"] != DBNull.Value)
                    user.ExpiresDate = DateTime.Parse(reader["ExpiresDate"].ToString());

                if (reader["RoleID"] != DBNull.Value)
                    user.RoleID = int.Parse(reader["RoleID"].ToString());

                if (reader["InsertBy"] != DBNull.Value)
                    user.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    user.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    user.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    user.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    user.LUN = int.Parse(reader["LUN"].ToString());

                if (reader["First_Name"] != DBNull.Value)
                    user.FirstName = reader["First_Name"].ToString();

                if (reader["Last_Name"] != DBNull.Value)
                    user.LastName = reader["Last_Name"].ToString();

                if (reader["LastLoginDate"] != DBNull.Value)
                    user.LastLoginDate = DateTime.Parse(reader["LastLoginDate"].ToString());

                if (reader["LastPasswordChangeDate"] != DBNull.Value)
                    user.LastPasswordChangeDate = DateTime.Parse(reader["LastPasswordChangeDate"].ToString());

                if (reader["IsPasswordChanged"] != DBNull.Value)
                    user.IsPasswordChanged = bool.Parse(reader["IsPasswordChanged"].ToString());

                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Staff Absence
        public bool AddStaffAbsence(User model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Staff_Create_Absence";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "userid", model.UserID);
                        DataConnection.AddParameter(command, "roleID", model.RoleID);
                        DataConnection.AddParameter(command, "firstname", model.FirstName);
                        DataConnection.AddParameter(command, "lastname", model.LastName);
                        DataConnection.AddParameter(command, "LUN", model.LUN);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "absencedate", model.StaffAbsenceDate);
                        DataConnection.AddParameter(command, "abreasoning", model.StaffAbsenceReasoning);

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

        public List<User> GetAllStaffAbsence()
        {
            try
            {
                List<User> MyStaffAbsences = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Staff_Absence_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            MyStaffAbsences = new List<User>();
                            while (reader.Read())
                            {
                                var staffAbsence = ToObjectStaff(reader);
                                if (reader["RoleName"] != DBNull.Value)
                                {
                                    staffAbsence.Roles = new Role { RoleName = reader["RoleName"].ToString() };
                                }
                                MyStaffAbsences.Add(staffAbsence);
                            }
                        }
                    }
                }
                return MyStaffAbsences;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public User ToObjectStaff(SqlDataReader reader)
        {
            try
            {
                var staffAbsence = new User();

                if (reader["UserID"] != DBNull.Value)
                    staffAbsence.UserID = int.Parse(reader["UserID"].ToString());

                if (reader["First_Name"] != DBNull.Value)
                    staffAbsence.FirstName = reader["First_Name"].ToString();

                if (reader["Last_Name"] != DBNull.Value)
                    staffAbsence.LastName = reader["Last_Name"].ToString();

                if (reader["RoleID"] != DBNull.Value)
                    staffAbsence.RoleID = int.Parse(reader["RoleID"].ToString());

                if (reader["AbsenceDate"] != DBNull.Value)
                    staffAbsence.StaffAbsenceDate = DateTime.Parse(reader["AbsenceDate"].ToString());

                if (reader["AbsenceReasoning"] != DBNull.Value)
                    staffAbsence.StaffAbsenceReasoning = reader["AbsenceReasoning"].ToString();

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
