using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class SituacaoSemanaOperacao
{
    public int IdTpsituacaosemanaoper { get; set; }

    public string DscSituacaosemanaoper { get; set; } = null!;

    public virtual ICollection<ArquivoSemanaOperativa> TbArquivosemanaoperativas { get; set; } = new List<ArquivoSemanaOperativa>();

    public virtual ICollection<HistoricoSemanaOperativa> TbHistmodifsemanaopers { get; set; } = new List<HistoricoSemanaOperativa>();

    public virtual ICollection<SemanaOperativa> TbSemanaoperativas { get; set; } = new List<SemanaOperativa>();
}
