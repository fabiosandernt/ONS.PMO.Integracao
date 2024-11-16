using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class HistoricoConfiguracaoGrandeza
{
    public int IdModifconfigblocoestudo { get; set; }

    public int IdGrandezamontador { get; set; }

    public bool? FlgProximoestudo { get; set; }

    public virtual GrandezaMontador IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual ModConfigBlocoEstudo IdModifconfigblocoestudoNavigation { get; set; } = null!;
}
