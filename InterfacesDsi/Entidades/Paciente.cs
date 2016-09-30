using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class Paciente : Persona
    {

        public Paciente() : base()
        {

        }

        public Paciente(string ape, string nom, int nroDoc, TipoDocumento tipoDoc) : 
            base(ape, nom, nroDoc, tipoDoc)
        {

        }
    }
}
