using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class PoliticaDescuento
    {
        private string descripcion;
        private DateTime fechaVigenciaDesde;
        private DateTime fechaVigenciaHasta;
        private double? montoFijoDescuento;
        private string nombre;
        private float? porcentajeDescuento;

        #region Properties
        public string Descripcion
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

        public DateTime FechaVigenciaDesde
        {
            get
            {
                return fechaVigenciaDesde;
            }

            set
            {
                fechaVigenciaDesde = value;
            }
        }

        public DateTime FechaVigenciaHasta
        {
            get
            {
                return fechaVigenciaHasta;
            }

            set
            {
                fechaVigenciaHasta = value;
            }
        }

        public double? MontoFijoDescuento
        {
            get
            {
                return montoFijoDescuento;
            }

            set
            {
                montoFijoDescuento = value;
            }
        }

        public string Nombre
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

        public float? PorcentajeDescuento
        {
            get
            {
                return porcentajeDescuento;
            }

            set
            {
                porcentajeDescuento = value;
            }
        }
        #endregion

        #region Constructores
        public PoliticaDescuento()
        {
            this.descripcion = "";
            this.fechaVigenciaDesde = DateTime.Today;
            this.fechaVigenciaHasta = DateTime.Today;
            this.montoFijoDescuento = 0;
            this.nombre = "";
            this.porcentajeDescuento = 0;
        }

        public PoliticaDescuento(string descripcion, DateTime fechaVigenciaDesde, DateTime fechaVigenciaHasta, double? montoFijoDescuento, string nombre, float? porcentajeDescuento)
        {
            this.descripcion = descripcion;
            this.fechaVigenciaDesde = fechaVigenciaDesde;
            this.fechaVigenciaHasta = fechaVigenciaHasta;
            this.montoFijoDescuento = montoFijoDescuento;
            this.nombre = nombre;
            this.porcentajeDescuento = porcentajeDescuento;
        }
        #endregion

        public string mostrarNombre()
        { return this.nombre; }

        public string mostrarPoliticaDescuento()
        {
            string descuento;
            string tipo;
            if (montoFijoDescuento == null)
            {
                descuento = porcentajeDescuento.ToString();
                tipo = "%";
            }
            else
            {
                descuento = MontoFijoDescuento.ToString();
                tipo = "pesos";
            }

            return "Nombre: " + this.nombre + "\nDescripcion: " + this.descripcion + "\n Descuento " + descuento + " " + tipo;
        }

    }
}
