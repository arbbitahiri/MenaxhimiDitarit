using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MenaxhimiDitarit.BO;
using MenaxhimiDitarit.BO.Interface;

namespace MenaxhimiDitarit.DAL
{
    public class RoleDAL : IBaseCRUD<Role>, IBaseConvert<Role>
    {
        public bool Add(Role model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Role_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "@roleID", model.RoleID);
                        DataConnection.AddParameter(command, "@rolename", model.RoleName);
                        DataConnection.AddParameter(command, "@insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "@insertdate", model.InsertDate);
                        DataConnection.AddParameter(command, "@LUB", model.LUB);
                        DataConnection.AddParameter(command, "@LUD", model.LUD);
                        DataConnection.AddParameter(command, "@LUN", model.LUN);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception e)
            {
                string error = e.Message;

                return false;
            }
        }

        public List<Role> GetAll()
        {
            try
            {
                List<Role> result = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Roles_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            result = new List<Role>();
                            while (reader.Read())
                                result.Add(ToObject(reader));
                        }
                    }
                }

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Remove(int id)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Roles_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "@roleID", id);

                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Role Get(int id)
        {
            try
            {
                Role result = null;
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_Roles_GetByID";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "@roleID", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                                result = ToObject(reader);
                        }
                    }
                }

                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Role ToObject(SqlDataReader reader)
        {
            try
            {
                var roles = new Role();

                if (reader["RoleID"] != DBNull.Value)
                    roles.RoleID = int.Parse(reader["RoleID"].ToString());

                if (reader["RoleName"] != DBNull.Value)
                    roles.RoleName = reader["RoleName"].ToString();

                if (reader["InsertBy"] != DBNull.Value)
                    roles.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    roles.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    roles.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    roles.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    roles.LUN = int.Parse(reader["LUN"].ToString());

                return roles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Remove(Role model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Role model)
        {
            throw new NotImplementedException();
        }

        public Role Get(Role model)
        {
            throw new NotImplementedException();
        }
    }
}
