using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class Usuario
    {
        static Empleado empleado;

        internal static Empleado Empleado
        {
            get
            {
                return empleado;
            }

            set
            {
                empleado = value;
            }
        }

        public static string obtenerNombre()
        {
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            return " Usuario: "+ userName.ToString()+ empleado.toString();
        }
        }
}
