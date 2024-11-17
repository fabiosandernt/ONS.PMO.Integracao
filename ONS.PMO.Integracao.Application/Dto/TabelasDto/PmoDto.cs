using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using AspNetCore.IQueryable.Extensions;
using System.Text.Json.Serialization;


namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class PmoDto
{
    [JsonIgnore]
    public int? IdPmo { get; set; }

    public int? AnoReferencia { get; set; }

    public int? MesReferencia { get; set; }

    public int? QtdMesesadiante { get; set; }

    [JsonIgnore]
    public byte[]? VerControleconcorrencia { get; set; } = null!;

    public virtual ICollection<SemanaOperativaDto>? TbSemanaoperativas { get; set; } = new List<SemanaOperativaDto>();

}
