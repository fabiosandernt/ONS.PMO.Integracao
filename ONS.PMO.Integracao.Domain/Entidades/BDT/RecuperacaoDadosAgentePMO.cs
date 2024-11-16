using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class RecuperacaoDadosAgentePMO
{
    public int IdRecuperacaodados { get; set; }

    public string AgeId { get; set; } = null!;

    public virtual RecuperacaoDado IdRecuperacaodadosNavigation { get; set; } = null!;
}
