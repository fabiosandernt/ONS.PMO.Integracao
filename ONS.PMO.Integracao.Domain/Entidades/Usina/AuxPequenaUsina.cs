using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class AuxPequenaUsina
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdSubsistemamontador { get; set; }

    public string NomPequenausina { get; set; } = null!;

    public string? DscPequenausina { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxSubsistemaMontador IdSubsistemamontadorNavigation { get; set; } = null!;
}
