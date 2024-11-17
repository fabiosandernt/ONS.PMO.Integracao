using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbEstadomnemonicoestudomontadorDto
{
    public int IdEstadomnemonicoestudomontador { get; set; }

    public string DscEstadomnemonicoestudomontador { get; set; } = null!;

    public bool FlgEscritarecuperacaodados { get; set; }

    public virtual ICollection<TbMneespestudomontadorDto> TbMneespestudomontadors { get; set; } = new List<TbMneespestudomontadorDto>();

    public virtual ICollection<TbMnemonicoestudomontadorDto> TbMnemonicoestudomontadors { get; set; } = new List<TbMnemonicoestudomontadorDto>();
}
