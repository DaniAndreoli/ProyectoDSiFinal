using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
   public class Empleado : Persona
    {

        public Empleado() : base()
        {

        }

        public Empleado(string ape, string nom, int nroDoc, TipoDocumento tipoDoc) : 
            base(ape, nom, nroDoc, tipoDoc)
        {
            
        }

        public string toString()
        {
            return " Nro de documento del empleado:" +this.p_nro_documento.ToString();
        }

    }
}
