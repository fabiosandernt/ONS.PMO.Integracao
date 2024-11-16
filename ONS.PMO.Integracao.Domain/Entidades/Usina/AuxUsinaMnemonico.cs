using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class AuxUsinaMnemonico
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdOrigemcoletamnemonico { get; set; }

    public int IdOrigemcoletausina { get; set; }

    public virtual AuxMnemonicoMontador IdOrigemcoletamnemonicoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual AuxUsinaMontador IdOrigemcoletausinaNavigation { get; set; } = null!;
}
