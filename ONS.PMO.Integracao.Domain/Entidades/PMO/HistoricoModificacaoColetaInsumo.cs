using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class HistoricoModificacaoColetaInsumo
{
    public int IdHistmodifcoletainsumo { get; set; }

    public int? IdTpsituacaocoletainsumo { get; set; }

    public int? IdColetainsumo { get; set; }

    public DateTime DinHistmodifcoletainsumo { get; set; }

    public virtual ColetaInsumo? IdColetainsumoNavigation { get; set; }

    public virtual SituacaoColetaIsumo? IdTpsituacaocoletainsumoNavigation { get; set; }
}
