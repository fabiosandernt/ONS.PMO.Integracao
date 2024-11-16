
namespace ONS.PMO.Integracao.Application.Dto.DisponibilidadeCVU
{
    public class DisponibilidadeDto
    {
        public int IdPmo { get; set; }
        public int AnoReferencia { get; set; }
        public int MesReferencia { get; set; }
        public int IdSemanaOperativa { get; set; }
        public string NomSemanaOperativa { get; set; }
        public DateTime DatInicioSemana { get; set; }
        public DateTime DatFimSemana { get; set; }
        public DateTime DatReuniao { get; set; }
        public int? NumRevisao { get; set; }
        public string DscSituacaoSemanaOper { get; set; }
        public int IdAgenteInstituicao { get; set; }
        public string DscApelidoRazaoSocial { get; set; }
        public int IdInsumoPmo { get; set; }
        public string NomInsumoPmo { get; set; }
        public string SglInsumo { get; set; }
        public string IdOrigemColeta { get; set; }
        public string NomExibicao { get; set; }
        public string CodSubsistema { get; set; }
        public string CodSubmercado { get; set; }
        public string CodTpGeracao { get; set; }
        public int CodDpp { get; set; }
        public string NomCurto { get; set; }
        public string NomLongo { get; set; }
        public int IdGrandeza { get; set; }
        public string NomGrandeza { get; set; }
        public string DscEstagio { get; set; }
        public int IdTpPatamar { get; set; }
        public string DscTpPatamar { get; set; }
        public string ValDado { get; set; }
    }
}
