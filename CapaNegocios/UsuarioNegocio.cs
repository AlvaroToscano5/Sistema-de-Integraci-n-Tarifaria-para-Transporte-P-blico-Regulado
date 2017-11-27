using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using DAO;

namespace CapaNegocios {
    public class UsuarioNegocio {
        usuarioDAO usuario = new usuarioDAO();

        public List<UsuarioEntity> listar() {
            return usuario.listar();
        }
    }
}
