using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDemandaintegralDto
{
    public int IdDemandaintegral { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public int NumEstagio { get; set; }

    public double? ValDemandaintegral { get; set; }

    public virtual TbConfiguracaogestaomanutencaoDto IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
