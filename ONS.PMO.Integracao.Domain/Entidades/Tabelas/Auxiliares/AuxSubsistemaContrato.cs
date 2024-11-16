using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxSubsistemaContrato
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdContrato { get; set; }

    public int IdOrigemcoletamontadorsubsistema { get; set; }

    public virtual AuxContrato IdContratoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxSubsistemaMontador IdOrigemcoletamontadorsubsistemaNavigation { get; set; } = null!;
}
