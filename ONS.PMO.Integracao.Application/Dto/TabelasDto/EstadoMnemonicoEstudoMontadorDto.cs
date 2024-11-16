using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class EstadoMnemonicoEstudoMontadorDto
{
    public int IdEstadomnemonicoestudomontador { get; set; }

    public string DscEstadomnemonicoestudomontador { get; set; } = null!;

    public bool FlgEscritarecuperacaodados { get; set; }

    public virtual ICollection<MneespEstudoMontadorDto> TbMneespestudomontadors { get; set; } = new List<MneespEstudoMontadorDto>();

    public virtual ICollection<MnemonicoEstudoMontadorDto> TbMnemonicoestudomontadors { get; set; } = new List<MnemonicoEstudoMontadorDto>();
}
