using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using ONS.PMO.Integracao.Domain.Entidades.Base;
using System.ComponentModel.DataAnnotations;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class InsumoFilter : BaseFilter
    {
        [Display(Name = "Nome")]
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string? NomInsumopmo { get; set; }

        [Display(Name = "Sligla")]
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string? SglInsumo { get; set; }

        [Display(Name = "Tipo")]
        [QueryOperator(Operator = WhereOperator.Contains)]
        public string? TipInsumopmo { get; set; }
    }
}
