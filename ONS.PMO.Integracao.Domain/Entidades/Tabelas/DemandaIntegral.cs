using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class DemandaIntegral
{
    public int IdDemandaintegral { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public int NumEstagio { get; set; }

    public double? ValDemandaintegral { get; set; }

    public virtual ConfiguracaoGestaoManutencao IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
