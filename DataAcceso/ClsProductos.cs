using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcceso
{
    public class ClsProductos
    {
        private ConexionDB Conexion = new ConexionDB();
        //ejecuta instrucciones desúes de muchos procedimientos
        private SqlCommand Comando = new SqlCommand();
        //metodo para leer filas de la base de datos
        private SqlDataReader LeerFilas;
        //Listar categorias es un codigo de consulta
        string idprod;
        public DataTable ListarCategorias()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarCategorias";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public DataTable ListarMarcas()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarMarcas";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public void InsertarProductos(int idCategoria, int idMarca, string descripcion, double precio)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "AgregarProducto";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@idcategoria", idCategoria);
            Comando.Parameters.AddWithValue("@idmarca", idMarca);
            Comando.Parameters.AddWithValue("@descrip", descripcion);
            Comando.Parameters.AddWithValue("@prec", precio);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();
        }
        public DataTable ListarProductos()
        {
            DataTable Tabla = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ListarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return Tabla;
        }
        public void EditarProductos(int idCategoria, int idMarca, int v, string descripcion, double precio)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "update PRODUCTOS set IDCATEGORIA=" + idCategoria + ",IDMARCA=" + idMarca + ",DESCRIPCION='" + descripcion + "',PRECIO=" + precio + " WHERE IDPROD=" + idprod;
            Comando.CommandType = CommandType.Text;
            
            Conexion.CerrarConexion();
        }
    }
}


    

