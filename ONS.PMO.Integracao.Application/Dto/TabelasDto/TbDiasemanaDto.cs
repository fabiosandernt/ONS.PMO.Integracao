using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDiasemanaDto
{
    public int IdDiasemana { get; set; }

    public DateOnly DatDiasemana { get; set; }

    public string FlgTpdiasemana { get; set; } = null!;

    public bool FlgFeriado { get; set; }

    public virtual ICollection<TbGeracaominimaperiododiumDto> TbGeracaominimaperiododia { get; set; } = new List<TbGeracaominimaperiododiumDto>();

    public virtual ICollection<TbLimiteperiododiumDto> TbLimiteperiododia { get; set; } = new List<TbLimiteperiododiumDto>();
}
