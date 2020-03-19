using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class TipoAjuste
    {
        public int IdTipoAjuste { get; set; }
        public decimal TasaFija { get; set; }
        public bool AjusteMensualInicial { get; set; }
        public bool AjusteMensualFinal { get; set; }

    }
}
