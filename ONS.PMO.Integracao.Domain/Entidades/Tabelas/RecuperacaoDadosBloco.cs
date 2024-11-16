using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class RecuperacaoDadosBloco
{
    public int IdRecuperacaodados { get; set; }

    public int IdBloco { get; set; }

    public virtual RecuperacaoDado IdRecuperacaodadosNavigation { get; set; } = null!;
}
