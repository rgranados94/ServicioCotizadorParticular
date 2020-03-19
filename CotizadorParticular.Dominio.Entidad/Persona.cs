using System;
using System.Collections.Generic;
using System.Text;

namespace CotizadorParticular.Dominio.Entidad
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string FechaNacimiento { get; set; }
        public int Sexo { get; set; }
        public int Condicion { get; set; }
        public int Parentesco { get; set; }
        public int PorcentajeBeneficio { get; set; }
        public string CodigoTablaMortalidad { get; set; }
        public int PorcentajeMejoraProbabilidad { get; set; }
        public string CodigoTablaFactorMejora { get; set; }
        public int EdadMensualLimite { get; set; }
    }
}
