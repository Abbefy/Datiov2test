using System.Data;
using System.Data.SqlClient;
//using Microsoft.Data.SqlClient;
using Datiov2test.Data;
using Datiov2test.Models;
using System;



namespace Datiov2test.Models
{
    public class UserMethods
    {
        //public readonly ILogger<UserMethods> _logger;

        //public UserMethods(ILogger<UserMethods> logger)
        //{
        //    _logger = logger;

        //}


        public int Register(UserModel user, out string error)
        {
            SqlConnection dbConnection = new SqlConnection();
            dbConnection.ConnectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Abbesdb; Integrated Security = True";

            string sqlString = "INSERT INTO dbo.Users (UserID, UserName, UserFirstName, UserLastName, UserPass, UserEmail, UserType) VALUES (@UserID, @UserName, @UserFirstName, @UserLastName, @UserPass, @UserEmail, @UserType)";
            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            dbCommand.Parameters.AddWithValue("@UserID", user.UserID);
            dbCommand.Parameters.AddWithValue("@UserName", user.UserName);
            dbCommand.Parameters.AddWithValue("@UserFirstName", user.UserFirstName);
            dbCommand.Parameters.AddWithValue("@UserLastName", user.UserLastName);
            dbCommand.Parameters.AddWithValue("@UserPass", user.UserPass);
            dbCommand.Parameters.AddWithValue("@UserEmail", user.UserEmail);
            dbCommand.Parameters.AddWithValue("@UserType", user.UserType);

            try
            {
                dbConnection.Open();
                int insert = dbCommand.ExecuteNonQuery();
                error = "";
                return insert;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                throw ex;
            }
            finally
            {
                dbConnection.Close();
            }


        }

           


    }
}
