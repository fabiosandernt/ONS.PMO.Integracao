using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.BDT;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public class EstadoMnemonicoEstudoMontador
{
    public int IdEstadomnemonicoestudomontador { get; set; }

    public string DscEstadomnemonicoestudomontador { get; set; } = null!;

    public bool FlgEscritarecuperacaodados { get; set; }

    public virtual ICollection<MneespEstudoMontador> TbMneespestudomontadors { get; set; } = new List<MneespEstudoMontador>();

    public virtual ICollection<MnemonicoEstudoMontador> TbMnemonicoestudomontadors { get; set; } = new List<MnemonicoEstudoMontador>();
}
