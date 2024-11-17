using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxUsinaconjunto
{
    public int IdOrigemcoletamontador { get; set; }

    public int? IdUsinamontador { get; set; }

    public int? NumGruge { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontador? IdUsinamontadorNavigation { get; set; }
}
