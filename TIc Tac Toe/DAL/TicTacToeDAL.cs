
using System.Data.SqlClient;
using TIc_Tac_Toe.Models;

namespace TIc_Tac_Toe.DAL
{
    public class TicTacToeDAL
    {
        private IConfiguration Configuration { get; }
        private SqlConnection conn;

        public TicTacToeDAL()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
            string strConn = Configuration.GetConnectionString(
            "TicTacToeConnectionString");
            //Instantiate a SqlConnection object with the
            //Connection String read.
            conn = new SqlConnection(strConn);
        }

        public bool Login(string username, string password)
        {
            bool authenticated = false;
            //Create a SqlCommand object from connection object
            SqlCommand cmd = conn.CreateCommand();
            //Specify the SELECT SQL statement 
            cmd.CommandText = @"SELECT * FROM users";
            //Open a database connection
            conn.Open();
            //Execute the SELECT SQL through a DataReader
            SqlDataReader reader = cmd.ExecuteReader();
            //Read all records until the end
            while (reader.Read())
            {
                // Convert email address to lowercase for comparison
                // Password comparison is case-sensitive
                if ((reader.GetString(1).ToLower() == username.ToLower()) &&
                (reader.GetString(2) == password))
                {
                    authenticated = true;
                    break; // Exit the while loop
                }
            }
            //Close the Data Reader
            reader.Close();
            //Close the data base connectio
            conn.Close();
            return authenticated;
        }
    }
}
