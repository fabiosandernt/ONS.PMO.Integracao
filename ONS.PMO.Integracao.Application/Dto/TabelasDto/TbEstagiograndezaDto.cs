using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbEstagiograndezaDto
{
    public int IdEstagiograndeza { get; set; }

    public int IdGrandezablocoestudo { get; set; }

    public DateOnly DatIniciosemana { get; set; }

    public DateOnly DatFimsemana { get; set; }

    public virtual TbGrandezablocoestudoDto IdGrandezablocoestudoNavigation { get; set; } = null!;
}
