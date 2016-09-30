using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDsi.Entidades;

namespace Helpers
{
    public static class DbHelper
    {
        private static List<Receta> lsRecetas;
        private static List<PoliticaDescuento> lsPoliticasDescuento;
        private static List<PresentacionFarmaceutica> lsPresentacionesFarmaceuticas;
        private static List<Monodroga> lsMonodrogas;
        private static TipoDocumento objDNI;
        private static Medico objMedico;

        private static void inicializarHelper()
        {
            //Creamos 2 instancias de la clase Politicas de Descuento con sus atributos
            lsPoliticasDescuento.Add(new PoliticaDescuento("Descuento porcentual aplicado a jubilados de PAMI",
                DateTime.Parse("25 / 06 / 2016"), DateTime.Parse("31 / 12 / 2016"), null, "Jubilados de PAMI", 30));//0

            lsPoliticasDescuento.Add(new PoliticaDescuento("Descuento fijo aplicado a afiliados de APROSS",
                DateTime.Parse("20/01/2016"), DateTime.Parse("31/12/2016"), 100, "Afiliados APROSS", null));//1

            //Creamos 2 instancias de la clase Presentacion Farmaceutica con sus atributos
            lsPresentacionesFarmaceuticas.Add(new PresentacionFarmaceutica("Blister de 18 pastillas", "Comprimidos"));//0
            lsPresentacionesFarmaceuticas.Add(new PresentacionFarmaceutica("Envase de 200ml", "Jarabe"));//1
            lsPresentacionesFarmaceuticas.Add(new PresentacionFarmaceutica("Blister de 6 pastillas", "Comprimidos"));//2

            //Creamos 4 instancias de la clase Monodroga
            lsMonodrogas.Add(new Monodroga("Tranquilizantes Ansioliticos", "Clonazepan"));//0
            lsMonodrogas.Add(new Monodroga("Antiepilépticos", "Carbamazepina"));//1
            lsMonodrogas.Add(new Monodroga("Antihistaminicos", "Difenhidramina"));//2
            lsMonodrogas.Add(new Monodroga("Inhibidor de ECA", "Enalapril"));//3

            //Creamos un objeto de la clase TipoDocumento que represente al DNI
            objDNI = new TipoDocumento("DNI");

            //Creamos un medico que sera asignado a todas las recetas
            objMedico = new Medico("Andreoli", "Roberto Daniel", 36045785, objDNI, 58150);
        }

        public static void crearRecetas()
        {
            //RECETA 1-----------------------------------------------------------------------------------------------
            //Creamos instancia de receta con datos nroReceta, fecha, listado de detalles y estado: Generada
            Receta objReceta = new Receta(1, DateTime.Today, new List<DetalleReceta>());

            //Luego, creamos un medicamento para el detalle
            Medicamento objMedicamento = new Medicamento();
            objMedicamento.FormaPresentacion = lsPresentacionesFarmaceuticas.ElementAt(0); //Blister de 18 pastillas
            objMedicamento.Monodroga = lsMonodrogas.ElementAt(1);//Carbamazepina
            objMedicamento.PrecioMedicamento = new PrecioMedicamento(
                DateTime.Parse("01/09/2016"), DateTime.Parse("21/10/2016"), 150);

            //Agregamos el medicamento al detalle
            objReceta.p_ls_detalle_receta.Add(new DetalleReceta(2, objMedicamento));

            //Aplicamos nuevos datos a los atributos del objeto Medicamento para agregarlo al detalle
            objMedicamento.FormaPresentacion = lsPresentacionesFarmaceuticas.ElementAt(2); //Blister de 6 pastillas
            objMedicamento.Monodroga = lsMonodrogas.ElementAt(0);//Clonazepan
            objMedicamento.PrecioMedicamento = new PrecioMedicamento(
                DateTime.Parse("01/09/2016"), DateTime.Parse("21/10/2016"), 250);

            //Agregamos el medicamento al detalle
            objReceta.p_ls_detalle_receta.Add(new DetalleReceta(5, objMedicamento));

            //Asignamos politica de descuento
            objReceta.p_politica_descuento = lsPoliticasDescuento.ElementAt(0);

            //Asignamos un centro de salud
            objReceta.p_centro_salud = new CentroDeSalud("Hospital de Clinicas");

            //Asignamos un paciente
            objReceta.p_paciente = new Paciente("Giannobi", "Leandro Ezequiel", 37286045, objDNI);

            //Asignamos un Medico
            objReceta.p_medico = objMedico;

            //Agregamos la receta a la lista de Recetas de la Aplicacion
            lsRecetas.Add(objReceta);

            //RECETA 2-----------------------------------------------------------------------------------------------




        }

        public static Receta obtenerRecetas(int nroReceta)
        {
            foreach (Receta item in lsRecetas)
            {
                if (item.p_numero_receta == nroReceta)
                    return item;
            }
            return null;
        }

        public static List<PoliticaDescuento> obtenerPoliticasDescuento()
        {
            return lsPoliticasDescuento;
        }


    }
}
