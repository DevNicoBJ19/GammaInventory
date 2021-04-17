using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcceso;

namespace Dominio
{
    public class ModeloUsuario
    {
        UsuarioData usuarioData = new UsuarioData();
        public bool LoginUser(string user, string pass)
        {
            return usuarioData.Login(user, pass);
        }
    }
}
