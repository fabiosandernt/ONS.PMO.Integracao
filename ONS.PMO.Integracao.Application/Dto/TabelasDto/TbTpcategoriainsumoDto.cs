using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpcategoriainsumoDto
{
    public int IdTpcategoriainsumo { get; set; }

    public string DscTpcategoriainsumo { get; set; } = null!;

    public bool FlgMontador { get; set; }

    public bool FlgPmo { get; set; }

    public virtual ICollection<TbInsumoestruturadoDto> TbInsumoestruturados { get; set; } = new List<TbInsumoestruturadoDto>();

    public virtual ICollection<TbBlocoDto> IdBlocos { get; set; } = new List<TbBlocoDto>();
}
