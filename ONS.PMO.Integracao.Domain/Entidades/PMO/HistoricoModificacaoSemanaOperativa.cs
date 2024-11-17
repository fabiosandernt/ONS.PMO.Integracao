using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class HistoricoModificacaoSemanaOperativa
{
    public int IdHistmodifsemanaoper { get; set; }

    public int IdSemanaoperativa { get; set; }

    public int? IdTpsituacaosemanaoper { get; set; }

    public DateTime DinHistmodifsemanaoper { get; set; }

    public virtual SemanaOperativa IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual SituacaoSemanaOperativa? IdTpsituacaosemanaoperNavigation { get; set; }
}
