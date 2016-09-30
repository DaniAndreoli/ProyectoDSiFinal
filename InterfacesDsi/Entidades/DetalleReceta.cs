using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class DetalleReceta
    {
        private int cantidad_recetada;
        private Medicamento medicamento;

        #region Properties
        public int p_cantidad_recetada
        {
            get
            {
                return cantidad_recetada;
            }

            set
            {
                cantidad_recetada = value;
            }
        }

        public Medicamento p_medicamento
        {
            get
            {
                return medicamento;
            }

            set
            {
                medicamento = value;
            }
        }
        #endregion

        #region Constructores
        public DetalleReceta()
        {
            this.p_cantidad_recetada = 0;
            this.p_medicamento = new Medicamento();
        }

        public DetalleReceta(int cantRecetada, Medicamento med)
        {
            this.p_cantidad_recetada = cantRecetada;
            this.p_medicamento = med;
        }

        #endregion

        private void calcularConDescuento()
        {

        }

        private void calcularCosto()
        {

        }

        private void mostrarDetalleReceta()
        {

        }
    }
}
