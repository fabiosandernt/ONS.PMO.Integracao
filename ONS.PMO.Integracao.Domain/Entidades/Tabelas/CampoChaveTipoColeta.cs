using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class CampoChaveTipoColeta
{
    public int IdCampochave { get; set; }

    public int IdTpcoleta { get; set; }

    public string? NomColorigemcoleta { get; set; }

    public bool FlgPrincipal { get; set; }

    public virtual CampoChave IdCampochaveNavigation { get; set; } = null!;

    public virtual Coleta IdTpcoletaNavigation { get; set; } = null!;
}
