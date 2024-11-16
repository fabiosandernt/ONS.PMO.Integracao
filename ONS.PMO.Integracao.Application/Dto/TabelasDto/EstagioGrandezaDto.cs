using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class EstagioGrandezaDto
{
    public int IdEstagiograndeza { get; set; }

    public int IdGrandezablocoestudo { get; set; }

    public DateOnly DatIniciosemana { get; set; }

    public DateOnly DatFimsemana { get; set; }

    public virtual GrandezaBlocoEstudoDto IdGrandezablocoestudoNavigation { get; set; } = null!;
}
