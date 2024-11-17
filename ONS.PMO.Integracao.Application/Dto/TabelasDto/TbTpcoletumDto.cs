using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbTpcoletumDto
{
    public int IdTpcoleta { get; set; }

    public string DscTpcoleta { get; set; } = null!;

    public bool FlgBlocomontador { get; set; }

    public bool FlgPmo { get; set; }

    public bool FlgMnemonicomontador { get; set; }

    public virtual ICollection<TbBlocoDto> TbBlocos { get; set; } = new List<TbBlocoDto>();

    public virtual ICollection<TbCampochavetpcoletumDto> TbCampochavetpcoleta { get; set; } = new List<TbCampochavetpcoletumDto>();

    public virtual ICollection<TbInsumoestruturadoDto> TbInsumoestruturados { get; set; } = new List<TbInsumoestruturadoDto>();

    public virtual ICollection<TbMnemonicoblocoacDto> TbMnemonicoblocoacs { get; set; } = new List<TbMnemonicoblocoacDto>();

    public virtual ICollection<TbOrigemcoletamontadorDto> TbOrigemcoletamontadors { get; set; } = new List<TbOrigemcoletamontadorDto>();
}
