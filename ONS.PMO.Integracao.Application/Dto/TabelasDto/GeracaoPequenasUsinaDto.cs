using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GeracaoPequenasUsinaDto
{
    public int IdGeracaopequenasusinas { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public double? ValGeracaopequenasusinas { get; set; }

    public virtual ConfiguracaoGestaoManutencaoDto IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
