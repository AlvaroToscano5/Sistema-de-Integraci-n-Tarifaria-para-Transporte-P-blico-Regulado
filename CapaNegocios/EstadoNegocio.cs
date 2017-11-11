using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using DAO;

namespace CapaNegocios
{
    public class EstadoNegocio {
        EstadoDAO estado = new EstadoDAO();

        public DataTable listadoEstadoEmpUsu() {
            return estado.listadoEstadoEmpUsu();
        }
    }
}
