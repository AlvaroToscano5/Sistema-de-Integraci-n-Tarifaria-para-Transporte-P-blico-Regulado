﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;
using DAO;

namespace CapaNegocios
{
    public class EmpleadoNegocio {
        EmpleadoDAO empleado = new EmpleadoDAO();

        public DataTable iniciarSesion(String usuario, String contraseña) {
            return empleado.iniciarSesion(usuario, contraseña);
        }

        public string registrar(EmpleadoEntity emp) {
            return empleado.registrar(emp);
        }
    }
}
