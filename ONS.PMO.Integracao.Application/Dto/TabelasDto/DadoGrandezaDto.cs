using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class DadoGrandezaDto
{
    public int IdTpdadograndeza { get; set; }

    public string DscTpdadograndeza { get; set; } = null!;

    public bool FlgMontador { get; set; }

    public bool FlgPmo { get; set; }

    public virtual ICollection<GrandezaMontadorDto> TbGrandezamontadors { get; set; } = new List<GrandezaMontadorDto>();

    public virtual ICollection<GrandezaDto> TbGrandezas { get; set; } = new List<GrandezaDto>();

    public virtual ICollection<MnemonicoPmoDto> TbMnemonicopmos { get; set; } = new List<MnemonicoPmoDto>();
}
