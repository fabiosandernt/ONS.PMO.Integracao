﻿using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class PerdaPotenciumDto
{
    public int IdPerdapotencia { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public double? ValPerdapotencia { get; set; }

    public virtual ConfiguracaoGestaoManutencaoDto IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
