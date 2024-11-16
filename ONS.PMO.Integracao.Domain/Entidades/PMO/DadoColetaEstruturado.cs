using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class DadoColetaEstruturado
{
    public int IdDadocoleta { get; set; }

    public int? IdTplimite { get; set; }

    public int? IdTppatamar { get; set; }

    public string? ValDado { get; set; }

    public string? DscEstagio { get; set; }

    public bool FlgDestacamodificacao { get; set; }

    public virtual DadoColeta IdDadocoletaNavigation { get; set; } = null!;

    public virtual Limite? IdTplimiteNavigation { get; set; }

    public virtual Patamar? IdTppatamarNavigation { get; set; }
}
