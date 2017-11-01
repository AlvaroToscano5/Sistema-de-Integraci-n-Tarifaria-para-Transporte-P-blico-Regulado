using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAO {
    public class EmpleadoDAO {
        ConexionDAO cn = new ConexionDAO();

        public DataTable iniciarSesion(String usuario, String contraseña) {
            DataTable dt = new DataTable();

            try {
                cn.getcn.Open();

                SqlCommand cmd = new SqlCommand("usp_IniciarSesion", cn.getcn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USU", usuario);
                cmd.Parameters.AddWithValue("@PSS", contraseña);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(dt);
            }
            catch { }
            finally { }

            return dt;
        }
    }
}
