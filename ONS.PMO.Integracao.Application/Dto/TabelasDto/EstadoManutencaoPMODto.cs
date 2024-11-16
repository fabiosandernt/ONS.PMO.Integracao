using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class EstadoManutencaoPMODto
{
    public int IdEstadomanutencaopmo { get; set; }

    public string DscEstado { get; set; } = null!;

    public virtual ICollection<ManutencaoPmoDto> TbManutencaopmos { get; set; } = new List<ManutencaoPmoDto>();
}
