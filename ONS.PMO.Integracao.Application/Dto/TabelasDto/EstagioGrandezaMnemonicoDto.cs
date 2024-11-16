using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class EstagioGrandezaMnemonicoDto
{
    public int IdEstagiograndezamnemonico { get; set; }

    public int IdGrandezamnemonicoestudo { get; set; }

    public DateOnly DatIniciosemana { get; set; }

    public DateOnly DatFimsemana { get; set; }

    public int? NumIndice { get; set; }

    public virtual GrandezaMnemonicoEstudoDto IdGrandezamnemonicoestudoNavigation { get; set; } = null!;
}
