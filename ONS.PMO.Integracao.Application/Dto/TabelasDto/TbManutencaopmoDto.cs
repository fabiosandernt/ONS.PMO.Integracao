using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbManutencaopmoDto
{
    public int IdManutencaopmo { get; set; }

    public int IdAgenteInstituicao { get; set; }

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

    public virtual TbAgenteinstituicaoDto IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual TbConfiguracaogestaomanutencaoDto? IdConfiguracaogestaomanutencaoNavigation { get; set; }

    public virtual TbEstadomanutencaopmoDto? IdEstadomanutencaopmoNavigation { get; set; }

    public virtual TbAuxUnidadegeradoraDto IdOrigemcoletaugeNavigation { get; set; } = null!;

    public virtual ICollection<TbManutencaopmoDto> IdManutencaopmocondicionada { get; set; } = new List<TbManutencaopmoDto>();

    public virtual ICollection<TbManutencaopmoDto> IdManutencaopmos { get; set; } = new List<TbManutencaopmoDto>();
}
