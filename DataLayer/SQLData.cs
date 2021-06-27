using System;
using System.Data.SqlClient;
using System.Data.Common;

namespace DataLayer
{
    public class SQLData
    {
        static string connectionString
        = "Data Source =.; Initial Catalog = EMS; User ID=0907;Password=0000; Integrated Security - True; databasename = trainee";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);

      
        static public bool ValidateIfTraineeExist(string traineeNumber)
        {
            var selectStatement = "SELECT UserRole FROM [PUPPoints].[dbo].[User] WHERE UserId = @UserId AND EmailAddress = @EmailAddress";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            selectCommand.Parameters.AddWithValue("@TraineeNumber", traineeNumber);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            var userRole = reader.Read();
            sqlConnection.Close();
            return userRole;
        }

        static public int GetTraineeInfo(string traineeNumber)
        {
            var selectStatement = "SELECT Points FROM StudentPoints WHERE StudentNumber = @StudentNumber";
            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
            selectCommand.Parameters.AddWithValue("@StudentNumber", traineeNumber);
            sqlConnection.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();
            var info = 0;
            if (reader.Read())
            {
                info = Convert.ToInt32(reader["Points"]);
            }
            sqlConnection.Close();
            return info;
        }

        static public void UpdateTraineeInfo(string traineeNumber, string info)
        {
            var updateStatement = $"INSERT INTO `trainee` (`traineeNumber`, `Points`) VALUES('2019-00111-BN-0', '100')";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            updateCommand.Parameters.AddWithValue("@traineeNumber", traineeNumber);
            updateCommand.Parameters.AddWithValue("@info", info);
            sqlConnection.Open();
            updateCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
