using static System.Net.Mime.MediaTypeNames;
using System;
using System.Security.Permissions;
using System.Data.SqlClient;
using BibleVerseApp.Models;

namespace CLCMilestone.Services
{
    public class SecurityDAO
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CLC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public bool FindUserByNameAndPassword(Login User)
        {
            // Assume nothing is found
            bool success = false;

            // Uses prepared statements for security. @username @password are defined below

            string sqlStatement = "SELECT * FROM dbo.Users WHERE username = @username and password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                // Define the values of the two placeholders in the sqlStatement string
                command.Parameters.Add("@USERNAME", System.Data.SqlDbType.VarChar, 50).Value = User.Username;
                command.Parameters.Add("@PASSWORD", System.Data.SqlDbType.VarChar, 50).Value = User.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                        success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                };
            }
            return success;
        }

        public string RegisterUser(Register User)
        {
            string sqlStatement = "INSERT INTO dbo.users (FIRSTNAME, LASTNAME, SEX, AGE, STATE, EMAIL, USERNAME, PASSWORD) VALUES (@firstname, @lastname, @sex, @age, @state, @email, @username, @password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@firstname", System.Data.SqlDbType.VarChar, 50).Value = User.FirstName;
                command.Parameters.Add("@lastname", System.Data.SqlDbType.VarChar, 50).Value = User.LastName;
                command.Parameters.Add("@sex", System.Data.SqlDbType.VarChar, 50).Value = User.Sex;
                command.Parameters.Add("@age", System.Data.SqlDbType.VarChar, 50).Value = User.Age;
                command.Parameters.Add("@state", System.Data.SqlDbType.VarChar, 50).Value = User.State;
                command.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 50).Value = User.Email;
                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50).Value = User.Username;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 50).Value = User.Password;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "RegistrationFailed";
                }
            }
            return "RegistrationSuccess";
        }
    }
}
