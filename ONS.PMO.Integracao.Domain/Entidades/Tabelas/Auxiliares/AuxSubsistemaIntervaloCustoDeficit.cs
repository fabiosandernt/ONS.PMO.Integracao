using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxSubsistemaIntervaloCustoDeficit
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdIntervalocustodeficit { get; set; }

    public int IdOrigemcoletamontadorsubsistema { get; set; }

    public virtual AuxIntervaloCustoDeficit IdIntervalocustodeficitNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxSubsistemaMontador IdOrigemcoletamontadorsubsistemaNavigation { get; set; } = null!;
}
