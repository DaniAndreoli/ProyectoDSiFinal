using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class Medicamento
    {
        private PresentacionFarmaceutica formaPresentacion;
        private Monodroga monodroga;
        private double precioActual;
        private double precioBajo;
        private PrecioMedicamento precioMedicamento;

        #region Properties
        public PresentacionFarmaceutica FormaPresentacion
        {
            get
            {
                return formaPresentacion;
            }

            set
            {
                formaPresentacion = value;
            }
        }

        public Monodroga Monodroga
        {
            get
            {
                return monodroga;
            }

            set
            {
                monodroga = value;
            }
        }

        public double PrecioActual
        {
            get
            {
                return precioActual;
            }

            set
            {
                precioActual = value;
            }
        }

        public double PrecioBajo
        {
            get
            {
                return precioBajo;
            }

            set
            {
                precioBajo = value;
            }
        }

        public PrecioMedicamento PrecioMedicamento
        {
            get
            {
                return precioMedicamento;
            }

            set
            {
                precioMedicamento = value;
            }
        }
        #endregion

        #region Constructores
        public Medicamento()
        {
            this.formaPresentacion = new PresentacionFarmaceutica();
            this.monodroga = new Monodroga();
            this.precioActual = 0;
            this.precioBajo = 0;
            this.precioMedicamento = new PrecioMedicamento();
        }

        public Medicamento(PresentacionFarmaceutica formaPresentacion, Monodroga monodroga, double precioActual, double precioBajo, PrecioMedicamento precioMedicamento)
        {
            this.formaPresentacion = formaPresentacion;
            this.monodroga = monodroga;
            this.precioActual = precioActual;
            this.precioBajo = precioBajo;
            this.precioMedicamento = precioMedicamento;
        }
        #endregion
    }
}
