using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class PrecioMedicamento
    {
        private DateTime fecha_desde;
        private DateTime fecha_hasta;
        private double precio_drogueria;

        public PrecioMedicamento(DateTime fecha_desde, DateTime fecha_hasta, double precio_drogueria)
        {
            this.fecha_desde = fecha_desde;
            this.fecha_hasta = fecha_hasta;
            this.precio_drogueria = precio_drogueria;
        }

        public DateTime Fecha_desde
        {
            get
            {
                return fecha_desde;
            }

            set
            {
                fecha_desde = value;
            }
        }

        public DateTime Fecha_hasta
        {
            get
            {
                return fecha_hasta;
            }

            set
            {
                fecha_hasta = value;
            }
        }

        public double Precio_drogueria
        {
            get
            {
                return precio_drogueria;
            }

            set
            {
                precio_drogueria = value;
            }
        }
    }
}
