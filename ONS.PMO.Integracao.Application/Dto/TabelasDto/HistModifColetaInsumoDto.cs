using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class HistmoDifColetaInsumoDto
{
    public int IdHistmodifcoletainsumo { get; set; }

    public int? IdTpsituacaocoletainsumo { get; set; }

    public int? IdColetainsumo { get; set; }

    public DateTime DinHistmodifcoletainsumo { get; set; }

    public virtual ColetaInsumoDto? IdColetainsumoNavigation { get; set; }

    public virtual SituacaoColetaInsumoDto? IdTpsituacaocoletainsumoNavigation { get; set; }
}
