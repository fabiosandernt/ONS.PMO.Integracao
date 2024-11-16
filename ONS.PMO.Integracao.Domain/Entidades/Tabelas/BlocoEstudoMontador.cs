using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class BlocoEstudoMontador
{
    public int IdBlocoestudomontador { get; set; }

    public int IdBloco { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadoblocoestudomontador { get; set; }

    public DateTime DinUltimaalteracao { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual Bloco IdBlocoNavigation { get; set; } = null!;

    public virtual EstadoBlocoEstudoMontador IdEstadoblocoestudomontadorNavigation { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;
}
