using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class ManutencaoPmoDto
{
    public int IdManutencaopmo { get; set; }

    public int IdAgenteinstituicao { get; set; }

    public string IdOrigemcoletauge { get; set; } = null!;

    public int? IdConfiguracaogestaomanutencao { get; set; }

    public int? IdEstadomanutencaopmo { get; set; }

    public long? NumSgi { get; set; }

    public DateTime DinInicio { get; set; }

    public DateTime DinTermino { get; set; }

    public bool FlgCancelada { get; set; }

    public DateTime? DinInicioreprogramado { get; set; }

    public DateTime? DinTerminoreprogramado { get; set; }

    public bool FlgImportadosgi { get; set; }

    public bool FlgImportadowebpmo { get; set; }

    public string? DscJustificativa { get; set; }

    public virtual AgenteinstituicaoDto IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual ConfiguracaoGestaoManutencaoDto? IdConfiguracaogestaomanutencaoNavigation { get; set; }

    public virtual EstadoManutencaoPMODto? IdEstadomanutencaopmoNavigation { get; set; }

    public virtual AuxUnidadeGeradoraDto IdOrigemcoletaugeNavigation { get; set; } = null!;

    public virtual ICollection<ManutencaoPmoDto> IdManutencaopmocondicionada { get; set; } = new List<ManutencaoPmoDto>();

    public virtual ICollection<ManutencaoPmoDto> IdManutencaopmos { get; set; } = new List<ManutencaoPmoDto>();
}
