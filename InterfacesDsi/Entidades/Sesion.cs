using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class Sesion
    {
        static Usuario usuario;

        public static Usuario Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public static string obtenerSesionActual(){


            return "Sesion nº 1 "+ Usuario.obtenerNombre(); }

       public static Empleado obtenerEmpleado()
       {
            return Usuario.Empleado;
        } 
       
    }
}
