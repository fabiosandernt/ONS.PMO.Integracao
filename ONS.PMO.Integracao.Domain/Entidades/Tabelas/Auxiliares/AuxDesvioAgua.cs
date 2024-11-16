using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxDesvioAgua
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdUsinamontadorretirada { get; set; }

    public int? IdUsinamontadorretorno { get; set; }

    public string? DscDesvioagua { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxUsinaMontador IdUsinamontadorretiradaNavigation { get; set; } = null!;

    public virtual AuxUsinaMontador? IdUsinamontadorretornoNavigation { get; set; }
}
