using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxSubsistemaintervalocustodeficit
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdIntervalocustodeficit { get; set; }

    public int IdOrigemcoletamontadorsubsistema { get; set; }

    public virtual TbAuxIntervalocustodeficit IdIntervalocustodeficitNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxSubsistemamontador IdOrigemcoletamontadorsubsistemaNavigation { get; set; } = null!;
}
