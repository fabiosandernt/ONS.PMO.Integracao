using ONS.PMO.Integracao.Domain.Entidades.PMO;
using System.Text.Json.Serialization;



namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbPmoDto 
{
    public int IdPmo { get; set; }

    public int AnoReferencia { get; set; }

    public int MesReferencia { get; set; }

    public int? QtdMesesadiante { get; set; }

    public byte[]? VerControleconcorrencia { get; set; } = null!;

    public ICollection<SemanaOperativa> TbSemanaoperativas { get; set; } = new List<SemanaOperativa>();
}
