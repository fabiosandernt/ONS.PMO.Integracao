using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ChaveBlocoEstudo
{
    public int IdChaveblocoestudo { get; set; }

    public int? IdOrigemcoletamontador { get; set; }

    public int IdBloco { get; set; }

    public int IdEstudomontador { get; set; }

    public int? IdRestricao { get; set; }

    public virtual Bloco IdBlocoNavigation { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador? IdOrigemcoletamontadorNavigation { get; set; }

    public virtual Restricao? IdRestricaoNavigation { get; set; }
}
