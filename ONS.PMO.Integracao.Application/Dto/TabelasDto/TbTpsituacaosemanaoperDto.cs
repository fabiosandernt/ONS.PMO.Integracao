using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpsituacaosemanaoperDto
{
    public int IdTpsituacaosemanaoper { get; set; }

    public string DscSituacaosemanaoper { get; set; } = null!;

    public virtual ICollection<TbArquivosemanaoperativaDto> TbArquivosemanaoperativas { get; set; } = new List<TbArquivosemanaoperativaDto>();

    public virtual ICollection<TbHistmodifsemanaoperDto> TbHistmodifsemanaopers { get; set; } = new List<TbHistmodifsemanaoperDto>();

    public virtual ICollection<TbSemanaoperativaDto> TbSemanaoperativas { get; set; } = new List<TbSemanaoperativaDto>();
}
