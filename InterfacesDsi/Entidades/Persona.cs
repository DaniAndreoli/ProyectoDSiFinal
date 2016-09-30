using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfacesDsi.Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int nro_documento;
        private TipoDocumento tipo_documento;

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

        public int p_nro_documento
        {
            get
            {
                return nro_documento;
            }

            set
            {
                nro_documento = value;
            }
        }

        public string p_apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public TipoDocumento p_tipo_documento
        {
            get
            {
                return tipo_documento;
            }

            set
            {
                tipo_documento = value;
            }
        }

        public Persona()
        {
            this.p_apellido = "";
            this.p_nombre = "";
            this.p_nro_documento = 0;
            this.p_tipo_documento = new TipoDocumento();
        }

        public Persona(string ape, string nom, int nroDoc, TipoDocumento tipoDoc)
        {
            p_apellido = ape;
            p_nombre = nom;
            p_nro_documento = nroDoc;
            p_tipo_documento = tipoDoc;
        }
    }
}
