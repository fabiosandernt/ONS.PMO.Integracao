using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ImportacaoDto
{
    public int IdTpimportacaopmo { get; set; }

    public string DscTpimportacaopmo { get; set; } = null!;

    public virtual ICollection<ImportacaoPmoDto> TbImportacaopmos { get; set; } = new List<ImportacaoPmoDto>();
}
