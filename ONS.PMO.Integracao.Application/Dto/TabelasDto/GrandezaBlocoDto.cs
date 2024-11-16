using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GrandezaBlocoDto
{
    public int IdGrandezamontador { get; set; }

    public int IdBloco { get; set; }

    public int? IdGrandeza { get; set; }

    public int? IdGrandezamontadorref { get; set; }

    public bool FlgColetapormeses { get; set; }

    public bool FlgColetaporsemanas { get; set; }

    public bool FlgQuebraestagio { get; set; }

    public virtual BlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual GrandezaDto? IdGrandezaNavigation { get; set; }

    public virtual GrandezaMontadorDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual GrandezaBlocoDto? IdGrandezamontadorrefNavigation { get; set; }

    public virtual ICollection<GrandezaBlocoDto> InverseIdGrandezamontadorrefNavigation { get; set; } = new List<GrandezaBlocoDto>();

    public virtual ICollection<ColunaGrandezaDto> TbColunagrandezas { get; set; } = new List<ColunaGrandezaDto>();

    public virtual ICollection<OrdenacaoRegistroDto> TbOrdenacaoregistros { get; set; } = new List<OrdenacaoRegistroDto>();
}
