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
        public void InsertarClie (string nom, string nit, string dir, string ciu, double tel)
           {
            objetoDA.Insertar(nom, nit, dir, ciu, Convert.ToDouble(tel));
           }
            

        }
    }

    
