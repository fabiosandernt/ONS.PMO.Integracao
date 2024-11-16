using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class DadosConvergenciumDto
{
    public int IdDadosconvergencia { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public string? LgnRepresentanteccee { get; set; }

    public string? ObsCcee { get; set; }

    public virtual SemanaOperativaDto? IdSemanaoperativaNavigation { get; set; }
}
