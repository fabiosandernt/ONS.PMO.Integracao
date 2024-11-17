using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class SituacaoColetaIsumo
{
    public int IdTpsituacaocoletainsumo { get; set; }

    public string DscTpsituacaocoletainsumo { get; set; } = null!;

    public virtual ICollection<ColetaInsumo> TbColetainsumos { get; set; } = new List<ColetaInsumo>();

    public virtual ICollection<HistoricoModificacaoColetaInsumo> TbHistmodifcoletainsumos { get; set; } = new List<HistoricoModificacaoColetaInsumo>();
}
