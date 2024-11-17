using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbInsumonaoestruturadoDto
{
    public int IdInsumopmo { get; set; }

    public bool FlgUtilizadodecomp { get; set; }

    public bool FlgUtilizadoconvergencia { get; set; }

    public bool FlgUtilizadopublicacao { get; set; }

    public bool FlgUtilizadoprocessamento { get; set; }

    public virtual TbInsumopmoDto IdInsumopmoNavigation { get; set; } = null!;
}
