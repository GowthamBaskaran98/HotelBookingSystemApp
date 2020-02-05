using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace HotelBooking
{
    class LogInController
    {
        public int count,value;
        public static List<User> userList = new List<User>();
        public int LogIn(User user,SqlConnection sqlConnection)
        {
            using (SqlCommand sqlCommand = new SqlCommand("sp_LogIn", sqlConnection))
            {
                //SqlParameter sqlParameter = new SqlParameter();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@gmail", user.gmail);
                sqlCommand.Parameters.AddWithValue("@password", user.password);
                sqlConnection.Open();
                SqlDataReader data = sqlCommand.ExecuteReader();
                if(data.HasRows)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
                sqlConnection.Close();
            }
            return value;
            //count = 0;
            //userId = user.userId;
            //Console.WriteLine(Printer.enterPassword);
            //password = user.password;
            //string sql = "Select * From USER_LOGIN";
            //SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            //SqlDataAdapter myAdapter = new SqlDataAdapter(sqlCommand);
            //DataSet MyDataSet = new DataSet();
            //myAdapter.Fill(MyDataSet, "Departments");
            //foreach (DataRow myRow in MyDataSet.Tables[0].Rows)
            //{
            //    User register = new User(myRow[0].ToString().Trim(),myRow[1].ToString().Trim(),myRow[2].ToString().Trim(), myRow[3].ToString().Trim());
            //    userList.Add(register);
            //}
            //foreach (User r in userList)
            //{
            //    if (r.userId == userId && r.password == password)
            //    {
            //        if (r.userType.Equals("Customer"))
            //        {
            //            return 1;
            //            count++;
            //            break;
            //        }
            //        else if (r.userType.Equals("HotelOwner"))
            //        {
            //            count = 0;
            //            foreach (Hotel h in HotelManager.request)
            //            {
            //                if (h.ownerName == userId)
            //                {
            //                    return 2;
            //                    count++;
            //                }
            //            }
            //            //foreach (Hotel h in HotelManager.hotelList)
            //            //{
            //            //    if (h.ownerName == userId)
            //            //    {
            //            //        return 2;
            //            //        hotels.Manage(userId);
            //            //        count++;
            //            //    }
            //            //}
            //            if (count == 0)
            //            {
            //                string sqls = "REQUEST_HOTEL_LIST";
            //                hotels.RegisterHotelDetail(userId,sqls);
            //                count++;
            //            }
            //        }
            //        else if (r.userType.Equals("Admin"))
            //        {
            //            return 1;
            //            AdminManager admin = new AdminManager();
            //            count++;
            //            break;
            //        }
            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine(Printer.invalidLogin);
            //    return 0;
            //}
        }
    }
}
