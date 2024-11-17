using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Application.Dto.PMO;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDadosconvergenciumDto
{
    public int IdDadosconvergencia { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public string? LgnRepresentanteccee { get; set; }

    public string? ObsCcee { get; set; }

    public virtual TbSemanaoperativaDto? IdSemanaoperativaNavigation { get; set; }
}
