using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.Auxiliar;

public class TbAuxInterligacaomontadorinterligacao
{
    public int IdInterligacao { get; set; }

    public int IdOrigemcoletainterligacao { get; set; }

    public bool FlgSoma { get; set; }

    public virtual TbAuxInterligacao IdInterligacaoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletainterligacaoNavigation { get; set; } = null!;
}
