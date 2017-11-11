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
    public class TipoNegocio {
        TipoDAO tipo = new TipoDAO();

        public DataTable listadoTipoEmpleado() {
            return tipo.listadoTipoEmpleado();
        }
    }
}
