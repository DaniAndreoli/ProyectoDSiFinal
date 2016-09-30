using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

﻿namespace InterfacesDsi.Entidades
{
    public class TipoDocumento
    {
        private string tipo_documento;

        public TipoDocumento(string tipo_documento)
        {
            this.tipo_documento = tipo_documento;
        }

        public string p_tipo_documento
        {
            get
            {
                return tipo_documento;
            }

            set
            {
                tipo_documento = value;
            }
        }
    }

}