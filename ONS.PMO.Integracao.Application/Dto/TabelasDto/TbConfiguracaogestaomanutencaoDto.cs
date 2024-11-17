using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbConfiguracaogestaomanutencaoDto
{
    public int IdConfiguracaogestaomanutencao { get; set; }

    public int IdSemanaoperativa { get; set; }

    public TimeOnly HorPonta { get; set; }

    public int QtdPeriodoanalise { get; set; }

    public DateTime DinColeta { get; set; }

    public string LgnColeta { get; set; } = null!;

    public string? LgnUsuariocheckout { get; set; }

    public virtual TbSemanaoperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual ICollection<TbDemandaintegralDto> TbDemandaintegrals { get; set; } = new List<TbDemandaintegralDto>();

    public virtual ICollection<TbGeracaopequenasusinaDto> TbGeracaopequenasusinas { get; set; } = new List<TbGeracaopequenasusinaDto>();

    public virtual ICollection<TbGeracaotermicaDto> TbGeracaotermicas { get; set; } = new List<TbGeracaotermicaDto>();

    public virtual ICollection<TbManutencaopmoDto> TbManutencaopmos { get; set; } = new List<TbManutencaopmoDto>();

    public virtual ICollection<TbPerdapotenciumDto> TbPerdapotencia { get; set; } = new List<TbPerdapotenciumDto>();

    public virtual ICollection<TbAgenteinstituicaoDto> IdAgenteinstituicaos { get; set; } = new List<TbAgenteinstituicaoDto>();
}
