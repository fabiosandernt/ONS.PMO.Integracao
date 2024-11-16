using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ColetumDto
{
    public int IdTpcoleta { get; set; }

    public string DscTpcoleta { get; set; } = null!;

    public bool FlgBlocomontador { get; set; }

    public bool FlgPmo { get; set; }

    public bool FlgMnemonicomontador { get; set; }

    public virtual ICollection<BlocoDto> TbBlocos { get; set; } = new List<BlocoDto>();

    public virtual ICollection<CampoChaveColetumDto> TbCampochavetpcoleta { get; set; } = new List<CampoChaveColetumDto>();

    public virtual ICollection<InsumoEstruturadoDto> TbInsumoestruturados { get; set; } = new List<InsumoEstruturadoDto>();

    public virtual ICollection<MnemonicoBlocoAcDto> TbMnemonicoblocoacs { get; set; } = new List<MnemonicoBlocoAcDto>();

    public virtual ICollection<OrigemColetaMontadorDto> TbOrigemcoletamontadors { get; set; } = new List<OrigemColetaMontadorDto>();
}
