using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbEstadomanutencaopmoDto
{
    public int IdEstadomanutencaopmo { get; set; }

    public string DscEstado { get; set; } = null!;

    public virtual ICollection<TbManutencaopmoDto> TbManutencaopmos { get; set; } = new List<TbManutencaopmoDto>();
}
