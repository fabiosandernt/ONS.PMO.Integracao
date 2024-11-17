using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbEstadoblocoestudomontadorDto
{
    public int IdEstadoblocoestudomontador { get; set; }

    public string DscEstadoblocoestudomontador { get; set; } = null!;

    public bool FlgEscritarecuperacaodados { get; set; }

    public virtual ICollection<TbBlocoestudomontadorDto> TbBlocoestudomontadors { get; set; } = new List<TbBlocoestudomontadorDto>();
}
