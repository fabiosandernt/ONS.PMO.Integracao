
namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class SemanaOperativaDto
{
    public int IdSemanaoperativa { get; set; }

    public int IdPmo { get; set; }
    
    public string? NomSemanaoperativa { get; set; }

    public int? IdTpsituacaosemanaoper { get; set; }

    public DateTime DatIniciosemana { get; set; }

    public DateTime DatFimsemana { get; set; }

    public DateTime DatReuniao { get; set; }

    public DateTime DatIniciomanutencao { get; set; }

    public DateTime DatFimmanutencao { get; set; }

    public int? NumRevisao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public DateTime? DinUltimaalteracao { get; set; }    
    


}
