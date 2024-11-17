using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxInterligacaomontadorusina
{
    public int IdOrigemcoletainterligprinc { get; set; }

    public int IdOrigemcoletausina { get; set; }

    public bool FlgSoma { get; set; }

    public virtual OrigemColetaMontador IdOrigemcoletainterligprincNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletausinaNavigation { get; set; } = null!;
}
