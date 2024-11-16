using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class RestricaoEstudo
{
    public int IdTprestricao { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdEstadorestricaoestudomontador { get; set; }

    public byte[] VerControleconcorrencia { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual EstadoRestricaoEstudoMontador IdEstadorestricaoestudomontadorNavigation { get; set; } = null!;

    public virtual EstudoMontador IdEstudomontadorNavigation { get; set; } = null!;

    public virtual Prestricao IdTprestricaoNavigation { get; set; } = null!;

    public virtual ICollection<Restricao> TbRestricaos { get; set; } = new List<Restricao>();
}
