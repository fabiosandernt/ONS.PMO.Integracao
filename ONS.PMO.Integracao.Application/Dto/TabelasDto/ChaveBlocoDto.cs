using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ChaveBlocoDto
{
    public int IdBloco { get; set; }

    public int IdCampochave { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public bool FlgDispmanutencao { get; set; }

    public bool FlgDispexportacao { get; set; }

    public bool FlgGeralinhacomentario { get; set; }

    public virtual BlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual CampoChaveDto IdCampochaveNavigation { get; set; } = null!;
}
