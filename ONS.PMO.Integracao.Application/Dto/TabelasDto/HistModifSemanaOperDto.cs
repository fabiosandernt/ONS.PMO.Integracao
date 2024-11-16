using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class HistModifSemanaOperDto
{
    public int IdHistmodifsemanaoper { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int? IdTpsituacaosemanaoper { get; set; }

    public DateTime DinHistmodifsemanaoper { get; set; }

    public virtual SemanaOperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual SituacaoSemanaOperativaDto? IdTpsituacaosemanaoperNavigation { get; set; }
}
