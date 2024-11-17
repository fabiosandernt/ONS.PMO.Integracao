using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbDadocoletaestruturadoDto
{
    public int IdDadocoleta { get; set; }

    public int? IdTplimite { get; set; }

    public int? IdTppatamar { get; set; }

    public string? ValDado { get; set; }

    public string? DscEstagio { get; set; }

    public bool FlgDestacamodificacao { get; set; }

    public virtual TbDadocoletumDto IdDadocoletaNavigation { get; set; } = null!;

    public virtual TbTplimiteDto? IdTplimiteNavigation { get; set; }

    public virtual TbTppatamarDto? IdTppatamarNavigation { get; set; }
}
