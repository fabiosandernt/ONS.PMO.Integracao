using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class GeracaoTermica
{
    public int IdGeracaotermicas { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string? NomCurtosubsistema { get; set; }

    public int NumEstagio { get; set; }

    public double? ValGeracaotermicas { get; set; }

    public string? NomCurtosubmercado { get; set; }

    public virtual ConfiguracaoGestaoManutencao IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
