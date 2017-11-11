using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class TipoDAO {
        ConexionDAO cn = new ConexionDAO();

        public DataTable listadoTipoEmpleado() {
            DataTable dt = new DataTable();

            try {
                cn.getcn.Open();

                SqlCommand cmd = new SqlCommand("usp_TipoEmpleado", cn.getcn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
            }
            catch { }
            finally { }

            return dt;
        }
    }
}
