using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class CategoriaInsumoDto
{
    public int IdTpcategoriainsumo { get; set; }

    public string DscTpcategoriainsumo { get; set; } = null!;

    public bool FlgMontador { get; set; }

    public bool FlgPmo { get; set; }

    public virtual ICollection<InsumoEstruturadoDto> TbInsumoestruturados { get; set; } = new List<InsumoEstruturadoDto>();

    public virtual ICollection<BlocoDto> IdBlocos { get; set; } = new List<BlocoDto>();
}
