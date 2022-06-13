using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BINAES.Resources;

namespace BINAES.Clases
{
    internal class UserDAO
    {
        public static User Exist(string name, string password)
        {
            string chain = db.connection_chain;
            User login = new User();

            using (SqlConnection connection = new SqlConnection(chain))
            {
                string query = "SELECT U.name, U.password, R.name" +
                               "FROM USER U " +
                               "INNER JOIN ROL R" +
                               "ON R.id = U.id_rol " +
                               "WHERE U.name like @name AND " +
                               "U.password like @password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        login.name = reader["user"].ToString();
                        login.password = reader["password"].ToString();
                        login.rol = reader["rol"].ToString();
                    }
                }
                connection.Close();
            }
            return login;
        }
    }
}
