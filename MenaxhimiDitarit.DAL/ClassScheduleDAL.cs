﻿using System;
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
    public class ClassScheduleDAL : IBaseCRUD<ClassSchedule>, IBaseConvert<ClassSchedule>
    {
        public bool Add(ClassSchedule model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    string sqlproc = "dbo.usp_ClassSchedule_Create";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "scheduleID", model.ScheduleID);
                        DataConnection.AddParameter(command, "classID", model.ClassID);
                        DataConnection.AddParameter(command, "subjectID", model.ScheduleID);
                        DataConnection.AddParameter(command, "time", model.Time);
                        DataConnection.AddParameter(command, "date", model.Date);
                        DataConnection.AddParameter(command, "year", model.Year);
                        DataConnection.AddParameter(command, "insertby", model.InsertBy);
                        DataConnection.AddParameter(command, "insertdate", model.InsertDate);
                        DataConnection.AddParameter(command, "LUB", model.LUN);
                        DataConnection.AddParameter(command, "LUN", model.LUD);
                        DataConnection.AddParameter(command, "LUD", model.LUB);

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

        public List<ClassSchedule> GetAll()
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    List<ClassSchedule> schedule = null;
                    string sqlproc = "dbo.usp_ClassSchedule_ViewAll";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            schedule = new List<ClassSchedule>();
                            while (reader.Read())
                                schedule.Add(ToObject(reader));
                        }

                        return schedule;
                    }
                }
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
                    string sqlproc = "dbo.usp_ClassSchedule_Delete";
                    using (var command = DataConnection.GetCommand(connection, sqlproc, CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "scheduleID", id);

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

        public ClassSchedule ToObject(SqlDataReader reader)
        {
            try
            {
                var schedule = new ClassSchedule();

                if (reader["ScheduleID"] != DBNull.Value)
                    schedule.ScheduleID = int.Parse(reader["ScheduleID"].ToString());

                if (reader["ClassID"] != DBNull.Value)
                    schedule.ClassID = int.Parse(reader["ClassID"].ToString());

                if (reader["SubjectID"] != DBNull.Value)
                    schedule.SubjectID = int.Parse(reader["SubjectID"].ToString());

                if (reader["Time"] != DBNull.Value)
                    schedule.Time = int.Parse(reader["Time"].ToString());

                if (reader["Date"] != DBNull.Value)
                    schedule.Date = reader["Date"].ToString();

                if (reader["Year"] != DBNull.Value)
                    schedule.Year = int.Parse(reader["Year"].ToString());

                if (reader["InsertBy"] != DBNull.Value)
                    schedule.InsertBy = reader["InsertBy"].ToString();

                if (reader["InsertDate"] != DBNull.Value)
                    schedule.InsertDate = DateTime.Parse(reader["InsertDate"].ToString());

                if (reader["LUB"] != DBNull.Value)
                    schedule.LUB = reader["LUB"].ToString();

                if (reader["LUD"] != DBNull.Value)
                    schedule.LUD = DateTime.Parse(reader["LUD"].ToString());

                if (reader["LUN"] != DBNull.Value)
                    schedule.LUN = int.Parse(reader["LUN"].ToString());

                return schedule;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ClassSchedule Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ClassSchedule model)
        {
            throw new NotImplementedException();
        }
    }
}
