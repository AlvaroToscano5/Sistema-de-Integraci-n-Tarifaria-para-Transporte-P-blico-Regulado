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
    public class EstacionNegocio {
        EstacionDAO estacion = new EstacionDAO();

        public DataTable listadoEstacion() {
            return estacion.listadoEstacion();
        }
    }
}
