using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using AspNetCore.IQueryable.Extensions;

using ONS.PMO.Integracao.Application.Dto;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class PmoFilter : ICustomQueryable, IQueryPaging, IQuerySort
    {        
        public int? IdPmo { get; set; }
        public int? AnoReferencia { get; set; }
        public int? MesReferencia { get; set; }
        public int? QtdMesesadiante { get; set; }    
        public int? Limit { get; set; } = 10;
        public int? Offset { get; set; }
        public string? Sort { get; set; }
    }
}
