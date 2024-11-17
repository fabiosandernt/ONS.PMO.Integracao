using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpimportacaopmoDto
{
    public int IdTpimportacaopmo { get; set; }

    public string DscTpimportacaopmo { get; set; } = null!;

    public virtual ICollection<TbImportacaopmoDto> TbImportacaopmos { get; set; } = new List<TbImportacaopmoDto>();
}
