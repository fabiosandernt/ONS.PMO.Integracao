using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class RecuperacaoDadosAgentePmo
{
    public int IdRecuperacaodados { get; set; }

    public string AgeId { get; set; } = null!;

    public virtual RecuperacaoDado IdRecuperacaodadosNavigation { get; set; } = null!;
}
