using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Domain.Entidades.SAGER.DisponibilidadeCVU
{
    public class DadoResultPmo
    {
        public int? IdDadoResultPmo { get; set; }
        public int? IdMnemonicopmo { get; set; }
        public int? IdListaResultadoPmo { get; set; }
        public int? IdTppatamar { get; set; }
        public string? DscValorColetadoMnemonico { get; set; }
        public bool? FlgValorOficial { get; set; }
        public int? NumEstagio { get; set; }
        public int? CodDpp { get; set; }
        public string? NomLongo { get; set; }
        public string? NomCurto { get; set; }
        public int? IdResultadoColetaPmo { get; set; }
        public int? IdTpPeriodoMontador { get; set; }
        public int? IdTpDadoGrandeza { get; set; }
        public bool? FlgAtivo { get; set; }
        public string? CodMnemonicopmo { get; set; }
        public string? NomMnemonicopmo { get; set; }
        public int? IdSemanaOperativa { get; set; }
        public string? NomSemanaOperativa { get; set; }
        public DateTime? DatInicioSemana { get; set; }
        public DateTime? DatFimSemana { get; set; }
        public string? DscTppatamar { get; set; }
    }
}
