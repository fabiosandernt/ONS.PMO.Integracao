using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class DemandaIntegralDto
{
    public int IdDemandaintegral { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public int NumEstagio { get; set; }

    public double? ValDemandaintegral { get; set; }

    public virtual ConfiguracaoGestaoManutencaoDto IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
