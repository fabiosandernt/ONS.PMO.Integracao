using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class ChaveMnemonicoEstudo
{
    public int IdChavemnemonicoestudo { get; set; }

    public int IdOrigemcoletamontador { get; set; }

    public int IdMnemonicoblocoac { get; set; }

    public int IdEstudomontador { get; set; }

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual MnemonicoBlocoAC IdMnemonicoblocoacNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;
}
