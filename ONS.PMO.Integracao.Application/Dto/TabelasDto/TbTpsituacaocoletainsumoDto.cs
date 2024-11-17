using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpsituacaocoletainsumoDto
{
    public int IdTpsituacaocoletainsumo { get; set; }

    public string DscTpsituacaocoletainsumo { get; set; } = null!;

    public virtual ICollection<TbColetainsumoDto> TbColetainsumos { get; set; } = new List<TbColetainsumoDto>();

    public virtual ICollection<TbHistmodifcoletainsumoDto> TbHistmodifcoletainsumos { get; set; } = new List<TbHistmodifcoletainsumoDto>();
}
