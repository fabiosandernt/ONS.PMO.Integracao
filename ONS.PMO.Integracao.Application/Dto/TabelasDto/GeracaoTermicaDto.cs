using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GeracaoTermicaDto
{
    public int IdGeracaotermicas { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string? NomCurtosubsistema { get; set; }

    public int NumEstagio { get; set; }

    public double? ValGeracaotermicas { get; set; }

    public string? NomCurtosubmercado { get; set; }

    public virtual ConfiguracaoGestaoManutencaoDto IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
