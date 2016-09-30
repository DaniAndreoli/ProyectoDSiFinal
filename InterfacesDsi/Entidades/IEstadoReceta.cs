using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public interface IEstadoReceta
    {
        void crear();
        bool esAutorizado();
        bool esEmitida();
        string mostrarDescripcion();
        string mostrarNombre();
    }
}
