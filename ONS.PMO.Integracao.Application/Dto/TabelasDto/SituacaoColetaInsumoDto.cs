using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class SituacaoColetaInsumoDto
{
    public int IdTpsituacaocoletainsumo { get; set; }

    public string DscTpsituacaocoletainsumo { get; set; } = null!;

    public virtual ICollection<ColetaInsumoDto> TbColetainsumos { get; set; } = new List<ColetaInsumoDto>();

    public virtual ICollection<HistmoDifColetaInsumoDto> TbHistmodifcoletainsumos { get; set; } = new List<HistmoDifColetaInsumoDto>();
}
