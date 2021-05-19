using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using DataAcceso;

namespace Dominio
{
    public class N_ConsultasClientes
    {
        private ConsultasClientes objetoDA = new ConsultasClientes();

        public DataTable MostrarClie()
        {
            DataTable tabla = new DataTable();
            tabla = objetoDA.Mostrar();
            return tabla;
        }
        public void InsertarClie(string nombre, string nit, string direccion, string ciudad, string telefono)
        {
            objetoDA.Insertar(nombre, nit, direccion, ciudad, telefono);
        }

        public void EditarClie(string nombre, string nit, string direccion, string ciudad, string telefono, string id)
        {
            objetoDA.Editar(nombre, nit, direccion, ciudad, telefono, Convert.ToInt32(id));
        }
        public void EliminarClie(string id)
        {
            objetoDA.Eliminar(Convert.ToInt32(id));
        }

    }
    }

    
