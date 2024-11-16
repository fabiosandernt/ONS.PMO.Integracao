using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class GrandezaDto
{
    public int IdGrandeza { get; set; }

    public int IdInsumopmo { get; set; }

    public string NomGrandeza { get; set; } = null!;

    public short NumOrdemexibicao { get; set; }

    public bool FlgColetaporpatamar { get; set; }

    public bool FlgColetaporlimite { get; set; }

    public bool FlgColetaporestagio { get; set; }

    public bool FlgAceitavalornegativo { get; set; }

    public bool FlgPoderecuperarvalor { get; set; }

    public bool FlgDestacadiferenca { get; set; }

    public bool FlgAtivo { get; set; }

    public int IdTpdadograndeza { get; set; }

    public int? QtdDigitos { get; set; }

    public int? QtdDecimais { get; set; }

    public bool? FlgParticipablocomontador { get; set; }

    public int? NumOrdemblocomontador { get; set; }

    public bool? FlgObrigatoriedade { get; set; }

    public bool FlgPreaprovadocomalteracao { get; set; }

    public virtual InsumoEstruturadoDto IdInsumopmoNavigation { get; set; } = null!;

    public virtual DadoGrandezaDto IdTpdadograndezaNavigation { get; set; } = null!;

    public virtual ICollection<DadoColetumDto> TbDadocoleta { get; set; } = new List<DadoColetumDto>();

    public virtual ICollection<GrandezaBlocoDto> TbGrandezablocos { get; set; } = new List<GrandezaBlocoDto>();
}
