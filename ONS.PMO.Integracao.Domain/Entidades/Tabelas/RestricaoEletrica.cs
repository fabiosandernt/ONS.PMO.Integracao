using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class RestricaoEletrica
{
    public int IdRestricao { get; set; }

    public string? CodEstruturacaores { get; set; }

    public virtual Restricao IdRestricaoNavigation { get; set; } = null!;
}
