using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using AspNetCore.IQueryable.Extensions;
using System.Text.Json.Serialization;


namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class PmoDto : ICustomQueryable, IQueryPaging, IQuerySort
{
    [JsonIgnore]
    public int? IdPmo { get; set; }

    public int? AnoReferencia { get; set; }

    public int? MesReferencia { get; set; }

    public int? QtdMesesadiante { get; set; }

    [JsonIgnore]
    public byte[]? VerControleconcorrencia { get; set; } = null!;

    public virtual ICollection<SemanaOperativaDto>? TbSemanaoperativas { get; set; } = new List<SemanaOperativaDto>();
    public int? Limit { get; set; } = 10;
    public int? Offset { get; set; }
    public string? Sort { get; set; }
}
