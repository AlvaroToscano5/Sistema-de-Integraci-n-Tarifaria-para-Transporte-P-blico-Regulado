using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace DAO {
    public class usuarioDAO {
        conexionDAO cn = new conexionDAO();

        public List<UsuarioEntity> listar() {
            string m = "";
            List<UsuarioEntity> lista = new List<UsuarioEntity>();
            cn.getcn.Open();

            try {
                SqlCommand cmd = new SqlCommand("usp_ListarUsuario", cn.getcn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    UsuarioEntity reg = new UsuarioEntity();
                    reg.codigo = dr[0].ToString();
                    reg.dni = dr[1].ToString();
                    reg.nombre = dr[2].ToString();
                    reg.apellidos = dr[3].ToString();
                    reg.sexo = dr[4].ToString();
                    reg.edad = Convert.ToInt32(dr[5]);
                    reg.nacionalidad = dr[6].ToString();
                    reg.usuario = dr[7].ToString();
                    reg.contraseña = dr[8].ToString();
                    reg.saldo = Convert.ToDouble(dr[9]);
                    reg.fechaReg = dr[10].ToString();
                    reg.fechaAct = dr[11].ToString();
                    reg.tipo = dr[12].ToString();
                    reg.estado = dr[13].ToString();
                    /*reg.huella = (byte[])dr[14];*/
                    lista.Add(reg);
                }
            }
            catch (SqlException ex) { m = ex.Message; }
            finally { cn.getcn.Close(); }
            return lista;
        }
    }
}
