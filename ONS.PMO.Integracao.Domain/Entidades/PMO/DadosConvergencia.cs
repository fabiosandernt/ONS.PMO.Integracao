using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class DadosConvergencia
{
    public int IdDadosconvergencia { get; set; }

    public int? IdSemanaoperativa { get; set; }

    public string? LgnRepresentanteccee { get; set; }

    public string? ObsCcee { get; set; }

    public virtual SemanaOperativa? IdSemanaoperativaNavigation { get; set; }
}
