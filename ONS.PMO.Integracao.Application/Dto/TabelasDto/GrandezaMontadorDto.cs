using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GrandezaMontadorDto
{
    public int IdGrandezamontador { get; set; }

    public int? IdTpdadograndeza { get; set; }

    public string NomGrandezamontador { get; set; } = null!;

    public string CodGrandezamontador { get; set; } = null!;

    public string? DscGrandezamontador { get; set; }

    public bool FlgAceitavalornegativo { get; set; }

    public bool FlgObrigatorio { get; set; }

    public bool FlgAtivo { get; set; }

    public bool FlgComentario { get; set; }

    public bool FlgDecimaisexatos { get; set; }

    public int? QtdDigitos { get; set; }

    public int? QtdDecimais { get; set; }

    public string? FlgRecuperaestudos { get; set; }

    public bool FlgMotivoalteracao { get; set; }

    public virtual DadoGrandezaDto? IdTpdadograndezaNavigation { get; set; }

    public virtual GrandezaBlocoDto? TbGrandezabloco { get; set; }

    public virtual GrandezaBlocoAcDto? TbGrandezablocoac { get; set; }

    public virtual ICollection<HisConfigGrandezaDto> TbHisconfiggrandezas { get; set; } = new List<HisConfigGrandezaDto>();
}
