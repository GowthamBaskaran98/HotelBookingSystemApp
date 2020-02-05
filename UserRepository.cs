using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace HotelBooking
{
    class UserRepository
    {
        public int Registration(User data, SqlConnection sqlConnection)
        {
            sqlConnection.Open();
            string sql = "REGISTRATION";
            using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@firstName";
                parameter.Value = data.firstName;
                parameter.SqlDbType = SqlDbType.Char;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@lastName";
                parameter.Value = data.lastName;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 20;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@mobileNumber";
                parameter.Value = data.mobileNumber;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 20;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@gmail";
                parameter.Value = data.gmail;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 30;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@password";
                parameter.Value = data.password;
                parameter.SqlDbType = SqlDbType.Char;
                parameter.Size = 20;
                sqlCommand.Parameters.Add(parameter);
                parameter = new SqlParameter();
                parameter.ParameterName = "@userType";
                parameter.Value = data.userType;
                parameter.SqlDbType = SqlDbType.Char;
                sqlCommand.Parameters.Add(parameter);
                int retRows = sqlCommand.ExecuteNonQuery();
                return retRows;
            }
        }
    }
}
