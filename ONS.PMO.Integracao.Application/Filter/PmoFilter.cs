using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using ONS.PMO.Integracao.Domain.Entidades.Base;
using System.ComponentModel.DataAnnotations;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class PmoFilter : BaseFilter
    {        
        public int? IdPmo { get; set; }
        [Display(Name = "Ano")]
        [QueryOperator(Operator = WhereOperator.Equals)]
        public int? AnoReferencia { get; set; }
        [Display(Name = "Mês")]
        [QueryOperator(Operator = WhereOperator.Equals)]
        public int? MesReferencia { get; set; }        
        public int? QtdMesesadiante { get; set; }    

    }
}
