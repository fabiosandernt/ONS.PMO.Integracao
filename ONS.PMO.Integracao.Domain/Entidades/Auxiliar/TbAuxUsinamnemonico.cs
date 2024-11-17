using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxUsinamnemonico
{
    public int IdOrigemcoletamontador { get; set; }

    public int IdOrigemcoletamnemonico { get; set; }

    public int IdOrigemcoletausina { get; set; }

    public virtual TbAuxMnemonicomontador IdOrigemcoletamnemonicoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletamontadorNavigation { get; set; } = null!;

    public virtual TbAuxUsinamontador IdOrigemcoletausinaNavigation { get; set; } = null!;
}
