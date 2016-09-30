using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDsi.Entidades;
using Helpers;



namespace InterfacesDsi.Entidades
{
    public static class Gestor_RegistrarAutorizacion
    {
        
        public static List<PoliticaDescuento> buscarDescuento()
        {
            List<PoliticaDescuento> politicas= new List<PoliticaDescuento>();
            politicas = DbHelper.obtenerPoliticasDescuento();
            return politicas;


        }

        public static Receta buscarVigente(int numeroReceta)
        {
            Receta receta = DbHelper.obtenerRecetas(numeroReceta);
            IEstadoReceta estado = receta.p_estado;
            if (estado.esEmitida())
            { return receta; }
            else
            {
                receta = null;
                return receta;
            }

        }

        public static double calcularCosto(Receta receta)
        {
            return receta.calcularCosto();
            
        }

        public static double calcularMontoConDescuento(Receta receta)
        {
            return receta.calcularMontoConDescuento();

        }

        public static void emitirComprobante(Receta receta, Object codigoQr)
        {
            Impresora.emitir(receta, codigoQr, Sesion.obtenerEmpleado());
        }

        public static void finCU()
        {
        }

        public static Object generarCodigo(Receta receta)
        {
            Object codigoQr = new object();
            //generar codigo qr
            return codigoQr;
        }

        public static string mostrarReceta(Receta receta)
        {
            return receta.mostrarReceta();

        }

        public static Receta nroReceta(int nro)
        {
            return buscarVigente(nro);
        }

        public static void registrarAutorizacion(Receta receta)
        {
           
            receta.autorizar();
        }

        public static Boolean verificarMonto(double descuento, double monto)
        {
            if (descuento > monto)
            { return true; }else{ return false; }

        }

        public static Boolean obtenerEstadoAutorizado(Receta receta)
        {
            IEstadoReceta estado = receta.p_estado;
            return estado.esAutorizado();
            
            
        }
    }
}
