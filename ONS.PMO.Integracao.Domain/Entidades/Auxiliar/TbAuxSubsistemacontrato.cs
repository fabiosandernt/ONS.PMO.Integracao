using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxSubsistemacontrato
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdContrato { get; set; }

    public int IdOrigemcoletamontadorsubsistema { get; set; }

    public virtual TbAuxContrato IdContratoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxSubsistemamontador IdOrigemcoletamontadorsubsistemaNavigation { get; set; } = null!;
}
