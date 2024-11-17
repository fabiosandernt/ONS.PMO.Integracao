using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxDesvioagua
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdUsinamontadorretirada { get; set; }

    public int? IdUsinamontadorretorno { get; set; }

    public string? DscDesvioagua { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontador IdUsinamontadorretiradaNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontador? IdUsinamontadorretornoNavigation { get; set; }
}
