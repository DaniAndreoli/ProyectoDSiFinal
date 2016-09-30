using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class CentroDeSalud
    {
        private string nombre;

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

        private void actualizarStock()
        {

        }

        private void buscarPrecioMedicamento()
        {

        }

        private void buscarStockMedicamento()
        {

        }

        private void mostrarNombre()
        {

        }

        public CentroDeSalud()
        {
            this.p_nombre = "";
        }

        public CentroDeSalud(string nombre)
        {
            this.p_nombre = nombre;
        }
    }
}