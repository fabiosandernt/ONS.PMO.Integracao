using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

public class AuxInterligacaoMontadorInterligacao
{
    public int IdInterligacao { get; set; }

    public int IdOrigemcoletainterligacao { get; set; }

    public bool FlgSoma { get; set; }

    public virtual AuxInterligacao IdInterligacaoNavigation { get; set; } = null!;

    public virtual OrigemColetaMontador IdOrigemcoletainterligacaoNavigation { get; set; } = null!;
}
