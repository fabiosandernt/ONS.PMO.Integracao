using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class MneespEstudoMontador
{
    public int IdMneespestudomontador { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadomnemonicoestudomontador { get; set; }

    public DateTime? DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual EstadoMnemonicoEstudoMontador IdEstadomnemonicoestudomontadorNavigation { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;
}
