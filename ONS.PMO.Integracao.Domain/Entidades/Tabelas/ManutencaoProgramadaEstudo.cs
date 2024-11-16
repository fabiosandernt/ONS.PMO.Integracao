using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class ManutencaoProgramadaEstudo
{
    public int IdEstudomontador { get; set; }

    public string? LgnUsuariocheckout { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;
}
