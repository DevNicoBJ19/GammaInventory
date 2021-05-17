using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcceso
{
    public class ConsultasClientes
    {
        private ConexionDB conexion = new ConexionDB();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar() {

            //Transaccion SQL

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Clientes";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string nom, string nit, string dir, string ciu, double tel)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Clientes values ('"+nom+"', '"+nit+"', '"+dir+"', '"+ciu+"', '"+tel+"')";
            comando.ExecuteNonQuery();
        }
    }
}
