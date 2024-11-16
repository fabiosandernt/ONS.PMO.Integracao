using AspNetCore.IQueryable.Extensions.Pagination;
using AspNetCore.IQueryable.Extensions.Sort;
using AspNetCore.IQueryable.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class DisponibilidadeFilterDto : ICustomQueryable, IQueryPaging, IQuerySort
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string[]? SglInsumo { get; set; }
        public int? Limit { get; set; } = 10;
        public int? Offset { get; set; }
        public string? Sort { get; set; }
    }
}
