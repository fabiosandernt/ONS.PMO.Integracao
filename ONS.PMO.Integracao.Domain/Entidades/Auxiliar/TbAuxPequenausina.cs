using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxPequenausina
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdSubsistemamontador { get; set; }

    public string NomPequenausina { get; set; } = null!;

    public string? DscPequenausina { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxSubsistemamontador IdSubsistemamontadorNavigation { get; set; } = null!;
}
