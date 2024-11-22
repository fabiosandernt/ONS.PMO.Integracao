using ONS.PMO.Integracao.Domain.Entidades.Base;
using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class HistoricoModificacaoSemanaOperativa : Entity<int>
{
    public DateTime DataHoraAlteracao { get; set; }
    public virtual SemanaOperativa SemanaOperativa { get; set; }
    public virtual SituacaoSemanaOperativa Situacao { get; set; }
    public int SemanaOperativaId { get; set; }
    public int? SituacaoId { get; set; }
}
