using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataAcceso
//Esta capa no tiene acceso a ninguna otra, porque es la capa inferior.
//Añado la libreria de SQL que es System.Data.SQLClient
{
    //Declaro la clase abstracta porque declara el metodo pero no su implementacion especifica
    public abstract class ConnectionToSQL
    {
        private readonly string connectionString;
        //creamos el metodo constructor y asignamos la conexion al servidor SQL con la direccion y nombre de la Base de datos,
        //y especificamos el acceso con credenciales establecidas en la base de datos

        public ConnectionToSQL()
        {
            connectionString = "Server = DESKTOP-PN1AJE8;DataBase = GammaInventory; integrated security = true";
        }
        //Creacion de metodo protegido para llamar a la conexion con el servidor, 
        //retornamos la cadena de conexion.
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}