using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpdadograndezaDto
{
    public int IdTpdadograndeza { get; set; }

    public string DscTpdadograndeza { get; set; } = null!;

    public bool FlgMontador { get; set; }

    public bool FlgPmo { get; set; }

    public virtual ICollection<TbGrandezamontadorDto> TbGrandezamontadors { get; set; } = new List<TbGrandezamontadorDto>();

    public virtual ICollection<TbGrandezaDto> TbGrandezas { get; set; } = new List<TbGrandezaDto>();

    public virtual ICollection<TbMnemonicopmoDto> TbMnemonicopmos { get; set; } = new List<TbMnemonicopmoDto>();
}
