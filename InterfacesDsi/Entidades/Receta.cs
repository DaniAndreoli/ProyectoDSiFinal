using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDsi.Entidades
{
    public class Receta
    {
        private DateTime fecha_prescripcion;
        private int numero_receta;
        private List<DetalleReceta> ls_detalle_receta;
        private IEstadoReceta estado;
        private PoliticaDescuento politica_descuento;
        private CentroDeSalud centro_salud;
        private Paciente paciente;
        private Medico medico;

        #region Properties
        public DateTime p_fecha_prescripcion
        {
            get
            {
                return fecha_prescripcion;
            }

            set
            {
                fecha_prescripcion = value;
            }
        }

        public int p_numero_receta
        {
            get
            {
                return numero_receta;
            }

            set
            {
                numero_receta = value;
            }
        }

        public List<DetalleReceta> p_ls_detalle_receta
        {
            get
            {
                return ls_detalle_receta;
            }

            set
            {
                ls_detalle_receta = value;
            }
        }

        public IEstadoReceta p_estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public PoliticaDescuento p_politica_descuento
        {
            get
            {
                return politica_descuento;
            }

            set
            {
                politica_descuento = value;
            }
        }

        public CentroDeSalud p_centro_salud
        {
            get
            {
                return centro_salud;
            }

            set
            {
                centro_salud = value;
            }
        }

        public Paciente p_paciente
        {
            get
            {
                return paciente;
            }

            set
            {
                paciente = value;
            }
        }

        public Medico p_medico
        {
            get
            {
                return medico;
            }

            set
            {
                medico = value;
            }
        }



        #endregion

        public Receta()
        {
            this.p_numero_receta = 0;
            this.p_fecha_prescripcion = DateTime.Today;
            this.p_ls_detalle_receta = new List<DetalleReceta>();
            this.p_estado = new Generada();
        }

        public Receta(int nroReceta, DateTime fechaPrescip, List<DetalleReceta> lsDetalles)
        {
            this.p_numero_receta = nroReceta;
            this.p_fecha_prescripcion = fechaPrescip;
            this.p_ls_detalle_receta = lsDetalles;
            this.p_estado = new Generada();
        }

        public void autorizar()
        {
            IEstadoReceta estado = new Autorizada();
            this.estado = estado;
            
        }

        public double calcularCosto()
        {
            return 1;
            //falta
        }

        public double calcularMontoConDescuento()
        {
            return 1;
            //falta
        }

        public IEstadoReceta conocerEstadoReceta()
        {
            return this.estado;

        }

        public string mostrarReceta()
        {
            return string.Empty;
            //falta
        }

        public void agregarDetalle(DetalleReceta itemDetalle)
        {
            this.ls_detalle_receta.Add(itemDetalle);
        }
    }
}
