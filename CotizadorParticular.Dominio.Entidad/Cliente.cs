using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        public int Edad { get; set; }
        public string DNI { get; set; }

        public string Informacion1 { get; set; }
        public string Informacion2 { get; set; }
        public string Informacion3 { get; set; }
    }
}
