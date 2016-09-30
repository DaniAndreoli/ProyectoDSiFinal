using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class Medico : Persona
    {
        private long matricula;

        public long p_matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }
        
        public Medico() : base()
        {
            p_matricula = 0;
        }

        public Medico(string ape, string nom, int nroDoc, TipoDocumento tipoDoc, long matricula) :
            base(ape, nom, nroDoc, tipoDoc)
        {
            p_matricula = matricula;
        }

        private string mostrarMedico()
        {
            return "";
        }
    }
}
