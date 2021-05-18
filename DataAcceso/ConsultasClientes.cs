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
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
        public void Insertar(string nombre, string nit, string direccion, string ciudad, string telefono)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@nit", nit);
            comando.Parameters.AddWithValue("@direccion ", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.ExecuteNonQuery();
            
        }
        public void Editar(string nombre, string nit, string direccion, string ciudad, string telefono, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@nit", nit);
            comando.Parameters.AddWithValue("@direccion ", direccion);
            comando.Parameters.AddWithValue("@ciudad", ciudad);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        
    }
}
