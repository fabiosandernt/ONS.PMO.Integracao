using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class HistoricoConfiguracaoBloco
{
    public int IdModifconfigblocoestudo { get; set; }

    public bool FlgProximoestudo { get; set; }

    public string? DscCabecalho { get; set; }

    public virtual ModConfigBlocoEstudo IdModifconfigblocoestudoNavigation { get; set; } = null!;
}
