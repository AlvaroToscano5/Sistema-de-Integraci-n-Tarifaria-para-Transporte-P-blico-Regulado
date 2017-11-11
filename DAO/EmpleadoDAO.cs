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
            string m = "";
            cn.getcn.Open();

            try {
                SqlCommand cmd = new SqlCommand("usp_IniciarSesion", cn.getcn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USU", usuario);
                cmd.Parameters.AddWithValue("@PSS", contraseña);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(dt);
            }
            catch (SqlException ex){ m = ex.Message; }
            finally { cn.getcn.Close(); }

            return dt;
        }

        public string registrar(EmpleadoEntity emp) {
            string m = "";
            cn.getcn.Open();

            try {
                SqlCommand cmd = new SqlCommand("usp_RegistrarEmpleado", cn.getcn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", emp.codigo);
                cmd.Parameters.AddWithValue("@dni", emp.dni);
                cmd.Parameters.AddWithValue("@nom", emp.nombre);
                cmd.Parameters.AddWithValue("@ape", emp.apellidos);
                cmd.Parameters.AddWithValue("@sex", emp.sexo);
                cmd.Parameters.AddWithValue("@cor", emp.correo);
                cmd.Parameters.AddWithValue("@eda", emp.edad);
                cmd.Parameters.AddWithValue("@dir", emp.direccion);
                cmd.Parameters.AddWithValue("@tel", emp.telefono);
                cmd.Parameters.AddWithValue("@usu", emp.usuario);
                cmd.Parameters.AddWithValue("@con", emp.contraseña);
                cmd.Parameters.AddWithValue("@frg", emp.fechaReg);
                cmd.Parameters.AddWithValue("@fac", emp.fechaAct);
                cmd.Parameters.AddWithValue("@tem", emp.tipo);
                cmd.Parameters.AddWithValue("@teu", emp.estado);
                cmd.Parameters.AddWithValue("@est", emp.estacion);
                cmd.Parameters.AddWithValue("@are", emp.area);

                cmd.ExecuteNonQuery();

                m = "Registro Agregado";
            }
            catch (SqlException ex ){ m = ex.Message; }
            finally { cn.getcn.Close(); }
            return m;
        }
    }
}
