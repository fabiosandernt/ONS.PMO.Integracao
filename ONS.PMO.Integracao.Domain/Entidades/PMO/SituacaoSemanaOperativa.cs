using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

public class SituacaoSemanaOperativa
{
    public int IdTpsituacaosemanaoper { get; set; }

    public string DscSituacaosemanaoper { get; set; } = null!;

    public virtual ICollection<ArquivoSemanaOperativa> TbArquivosemanaoperativas { get; set; } = new List<ArquivoSemanaOperativa>();

    public virtual ICollection<HistoricoModificacaoSemanaOperativa> TbHistmodifsemanaopers { get; set; } = new List<HistoricoModificacaoSemanaOperativa>();

    public virtual ICollection<SemanaOperativa> TbSemanaoperativas { get; set; } = new List<SemanaOperativa>();
}
