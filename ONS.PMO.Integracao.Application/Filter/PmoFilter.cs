using AspNetCore.IQueryable.Extensions.Attributes;
using AspNetCore.IQueryable.Extensions.Filter;
using System.ComponentModel.DataAnnotations;
using ONS.PMO.Integracao.Domain.Filter;

namespace ONS.PMO.Integracao.Application.Filter
{
    public class PmoFilter : BaseFilter
    {
        [Display(Name = "Ano")]
        [QueryOperator(Operator = WhereOperator.Equals)]
        public int? AnoReferencia { get; set; }

        [Display(Name = "Mês")]
        [QueryOperator(Operator = WhereOperator.Equals)]
        public int? MesReferencia { get; set; }  
        
        //exemplo de mudunça Limit de 10 para 20

        //public override int? Limit { get; set; } = 20;
        
    }
}

