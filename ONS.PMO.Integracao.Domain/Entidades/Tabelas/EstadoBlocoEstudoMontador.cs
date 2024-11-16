using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class EstadoBlocoEstudoMontador
{
    public int IdEstadoblocoestudomontador { get; set; }

    public string DscEstadoblocoestudomontador { get; set; } = null!;

    public bool FlgEscritarecuperacaodados { get; set; }

    public virtual ICollection<BlocoEstudoMontador> TbBlocoestudomontadors { get; set; } = new List<BlocoEstudoMontador>();
}
