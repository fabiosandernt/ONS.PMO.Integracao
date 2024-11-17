using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbHistmodifsemanaoperDto
{
    public int IdHistmodifsemanaoper { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int? IdTpsituacaosemanaoper { get; set; }

    public DateTime DinHistmodifsemanaoper { get; set; }

    public virtual TbSemanaoperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual TbTpsituacaosemanaoperDto? IdTpsituacaosemanaoperNavigation { get; set; }
}
