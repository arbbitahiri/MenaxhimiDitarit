using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;

namespace MenaxhimiDitarit.DAL
{
    public class UserDAL : IBaseConvert<User>, IBaseCRUD<User>
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
                                result = ToObject(reader);

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

        public bool Add(User model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_User_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "@userID", model.UserID);
                        DataConnection.AddParameter(command, "@username", model.UserName);
                        DataConnection.AddParameter(command, "@userpassword", model.UserPassword);
                        DataConnection.AddParameter(command, "@expiresdate", model.ExpiresDate);
                        DataConnection.AddParameter(command, "@roleID", model.RoleID);
                        DataConnection.AddParameter(command, "@insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "@insertdate", model.InsertDate);
                        DataConnection.AddParameter(command, "@LUB", model.LUB);
                        DataConnection.AddParameter(command, "@LUD", model.LUD);
                        DataConnection.AddParameter(command, "@LUN", model.LUN);
                        DataConnection.AddParameter(command, "@firstname", model.FirstName);
                        DataConnection.AddParameter(command, "@lastname", model.LastName);

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

        public List<User> GetAll()
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    List<User> users = null;
                    string sqlproc = "dbo.usp_Users_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            users = new List<User>();
                            while (reader.Read())
                                users.Add(ToObject(reader));
                        }

                        return users;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User Get(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    User users = null;
                    string sqlproc = "dbo.usp_Users_ViewByID";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "UserID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                users = ToObject(reader);
                        }

                        return users;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User ToObject(SqlDataReader reader)
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

                return user;
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

        public User Get(User model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    User users = null;
                    string sqlproc = "dbo.usp_Users_ViewBy_UserName";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "UserName", model);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                users = ToObject(reader);
                        }

                        return users;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(User model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(User model)
        {
            throw new NotImplementedException();
        }
    }
}
