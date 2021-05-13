using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaComun.Cache;

namespace DataAcceso
{
    //Indico que esta clase hereda de la clase ConnectionToSQL
    public class UsuarioData:ConnectionToSQL
    {
        public bool Login(String user, string pass)
        {
            using (var connection = GetSqlConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select * from Users where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()){
                            CacheLoginUsuario.IdUser = reader.GetInt32(0);
                            CacheLoginUsuario.LoginName = reader.GetString(1);
                            CacheLoginUsuario.Password = reader.GetString(2);
                            CacheLoginUsuario.FirstName = reader.GetString(3);
                            CacheLoginUsuario.LastName = reader.GetString(4);
                            CacheLoginUsuario.Position = reader.GetString(5);
                            CacheLoginUsuario.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}