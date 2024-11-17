using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbGrandezablocoDto
{
    public int IdGrandezamontador { get; set; }

    public int IdBloco { get; set; }

    public int? IdGrandeza { get; set; }

    public int? IdGrandezamontadorref { get; set; }

    public bool FlgColetapormeses { get; set; }

    public bool FlgColetaporsemanas { get; set; }

    public bool FlgQuebraestagio { get; set; }

    public virtual TbBlocoDto IdBlocoNavigation { get; set; } = null!;

    public virtual TbGrandezaDto? IdGrandezaNavigation { get; set; }

    public virtual TbGrandezamontadorDto IdGrandezamontadorNavigation { get; set; } = null!;

    public virtual TbGrandezablocoDto? IdGrandezamontadorrefNavigation { get; set; }

    public virtual ICollection<TbGrandezablocoDto> InverseIdGrandezamontadorrefNavigation { get; set; } = new List<TbGrandezablocoDto>();

    public virtual ICollection<TbColunagrandezaDto> TbColunagrandezas { get; set; } = new List<TbColunagrandezaDto>();

    public virtual ICollection<TbOrdenacaoregistroDto> TbOrdenacaoregistros { get; set; } = new List<TbOrdenacaoregistroDto>();
}
