using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbParametropmoDto
{
    public int IdParametropmo { get; set; }

    public string NomParametropmo { get; set; } = null!;

    public string? ValParametropmo { get; set; }

    public string? DscParametropmo { get; set; }
}
