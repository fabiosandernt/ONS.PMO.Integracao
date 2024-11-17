using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbChaveblocoDto
{
    public int IdBloco { get; set; }

    public int IdCampochave { get; set; }

    public int? ValColinicial { get; set; }

    public int? ValColfinal { get; set; }

    public bool FlgDispmanutencao { get; set; }

    public bool FlgDispexportacao { get; set; }

    public bool FlgGeralinhacomentario { get; set; }

    public virtual TbBlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual TbCampochaveDto IdCampochaveNavigation { get; set; } = null!;
}
