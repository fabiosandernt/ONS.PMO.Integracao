using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class AuxUsinaConjunto
{
    public int IdOrigemcoletamontador { get; set; }

    public int? IdUsinamontador { get; set; }

    public int? NumGruge { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxUsinaMontador? IdUsinamontadorNavigation { get; set; }
}
