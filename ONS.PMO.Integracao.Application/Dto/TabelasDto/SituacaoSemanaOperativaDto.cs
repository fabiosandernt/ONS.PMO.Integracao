using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class SituacaoSemanaOperativaDto
{
    public int IdTpsituacaosemanaoper { get; set; }

    public string DscSituacaosemanaoper { get; set; } = null!;

    public virtual ICollection<ArquivoSemanaOperativaDto> TbArquivosemanaoperativas { get; set; } = new List<ArquivoSemanaOperativaDto>();

    public virtual ICollection<HistModifSemanaOperDto> TbHistmodifsemanaopers { get; set; } = new List<HistModifSemanaOperDto>();

    public virtual ICollection<SemanaOperativaDto> TbSemanaoperativas { get; set; } = new List<SemanaOperativaDto>();
}
