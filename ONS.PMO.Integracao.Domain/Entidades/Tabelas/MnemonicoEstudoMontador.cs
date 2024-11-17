using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class MnemonicoEstudoMontador
{
    public int IdBlocoestudomontador { get; set; }

    public int IdMnemonicoblocoac { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadomnemonicoestudomontador { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual EstadoMnemonicoEstudoMontador IdEstadomnemonicoestudomontadorNavigation { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual MnemonicoBlocoAC IdMnemonicoblocoacNavigation { get; set; } = null!;
}
