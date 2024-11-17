using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class GeracaoPequenasUsina
{
    public int IdGeracaopequenasusinas { get; set; }

    public int IdConfiguracaogestaomanutencao { get; set; }

    public string NomCurtosubsistema { get; set; } = null!;

    public double? ValGeracaopequenasusinas { get; set; }

    public virtual ConfiguracaoGestaoManutencao IdConfiguracaogestaomanutencaoNavigation { get; set; } = null!;
}
