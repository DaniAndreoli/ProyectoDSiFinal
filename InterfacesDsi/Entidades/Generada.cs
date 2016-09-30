using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class Generada : IEstadoReceta
    {
        private string descripcion;
        private string nombre;

        public string p_descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string p_nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public void crear()
        {
            this.p_descripcion = "";
            this.p_nombre = "";
        }

        public void crear(string desc, string nom)
        {
            this.p_descripcion = desc;
            this.p_nombre = nom;
        }

        public bool esAutorizado()
        {
            return false;
        }

        public bool esEmitida()
        {
            return true;
        }

        public string mostrarDescripcion()
        {
            return this.p_descripcion;
        }

        public string mostrarNombre()
        {
            return this.p_nombre;
        }
    }
}
