using CotizadorParticular.Dominio.Entidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Nucleo.DTO.ResponseDTO
{
    public class AnexosResponse
    {
        public List<Anexo1> ListAnexo1 { get; set; }
        public List<Anexo3> ListAnexo3 { get; set; }
        public List<Anexo4> ListAnexo4 { get; set; }
    }
}
