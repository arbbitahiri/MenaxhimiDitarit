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
    public class UsersDAL : IBaseConvert<Users>, IBaseCRUD<Users>
    {
        public Users Login(string username, string password)
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
                            Users result = null;
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

        public bool Add(Users model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_User_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "UserID", model.UserID);
                        DataConnection.AddParameter(command, "Emri", model.Emri);
                        DataConnection.AddParameter(command, "Mbiemri", model.Mbiemri);
                        DataConnection.AddParameter(command, "UserName", model.UserName);
                        DataConnection.AddParameter(command, "UserPassword", model.UserPassword);
                        DataConnection.AddParameter(command, "ExpiresDate", model.ExpiresDate);
                        DataConnection.AddParameter(command, "RoleId", model.RoleID);
                        DataConnection.AddParameter(command, "InsertBy", model.InsertBy);
                        DataConnection.AddParameter(command, "InsertDate", model.InsertDate);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        DataConnection.AddParameter(command, "LUD", model.LUD);
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

        public List<Users> GetAll()
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    List<Users> users = null;
                    string sqlproc = "dbo.usp_Users_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            users = new List<Users>();
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

        public Users Get(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    Users users = null;
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

        public Users ToObject(SqlDataReader reader)
        {
            try
            {
                var user = new Users();

                if (reader["UserID"] != DBNull.Value)
                    user.UserID = int.Parse(reader["UserID"].ToString());

                if (reader["Emri"] != DBNull.Value)
                    user.Emri = reader["Emri"].ToString();

                if (reader["Mbiemri"] != DBNull.Value)
                    user.Mbiemri = reader["Mbiemri"].ToString();

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

        public Users Get(Users model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Users model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Users model)
        {
            throw new NotImplementedException();
        }
    }
}
