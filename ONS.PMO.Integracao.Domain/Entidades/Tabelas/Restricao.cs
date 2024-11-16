using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class Restricao
{
    public int IdRestricao { get; set; }

    public int IdEstudomontador { get; set; }

    public int IdTprestricao { get; set; }

    public int IdFonteorigem { get; set; }

    public int? NumRestricao { get; set; }

    public int? NumRestricaoestudoanterior { get; set; }

    public string CodIdentificador { get; set; } = null!;

    public string? DscComentario { get; set; }

    public string? LgnUltimaalteracao { get; set; }

    public DateTime? DinUltimaalteracao { get; set; }

    public bool FlgImportado { get; set; }

    public DateTime DinEstagioinicial { get; set; }

    public DateTime DinEstagiofinal { get; set; }

    public int? IdRestricaopai { get; set; }

    public virtual FonteOrigem IdFonteorigemNavigation { get; set; } = null!;

    public virtual Restricao? IdRestricaopaiNavigation { get; set; }

    public virtual ICollection<Restricao> InverseIdRestricaopaiNavigation { get; set; } = new List<Restricao>();

    public virtual ICollection<ChaveBlocoEstudo> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudo>();

    public virtual ICollection<GrandezaBlocoEstudo> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudo>();

    public virtual RestricaoEletrica? TbRestricaoeletrica { get; set; }

    public virtual RestricaoEstudo TbRestricaoestudo { get; set; } = null!;
}
