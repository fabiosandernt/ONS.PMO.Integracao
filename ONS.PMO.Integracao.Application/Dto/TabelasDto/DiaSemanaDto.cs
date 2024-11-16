using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class DiaSemanaDto
{
    public int IdDiasemana { get; set; }

    public DateOnly DatDiasemana { get; set; }

    public string FlgTpdiasemana { get; set; } = null!;

    public bool FlgFeriado { get; set; }

    public virtual ICollection<GeracaoMinimaPeriodoDto> TbGeracaominimaperiododia { get; set; } = new List<GeracaoMinimaPeriodoDto>();

    public virtual ICollection<LimitePeriodoDto> TbLimiteperiododia { get; set; } = new List<LimitePeriodoDto>();
}
