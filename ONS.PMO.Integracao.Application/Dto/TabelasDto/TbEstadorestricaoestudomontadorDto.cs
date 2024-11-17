using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbEstadorestricaoestudomontadorDto
{
    public int IdEstadorestricaoestudomontador { get; set; }

    public string DscEstadorestricaoestudomontador { get; set; } = null!;

    public bool FlgEscritarecuperacaodados { get; set; }

    public virtual ICollection<TbRestricaoestudoDto> TbRestricaoestudos { get; set; } = new List<TbRestricaoestudoDto>();
}
