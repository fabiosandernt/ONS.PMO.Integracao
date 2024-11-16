using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas.Auxiliares;

namespace ONS.PMO.Integracao.Domain.Entidades.BDT;

public class ManutencaoPMO
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

    public virtual Agenteinstituicao IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual ConfiguracaoGestaoManutencao? IdConfiguracaogestaomanutencaoNavigation { get; set; }

    public virtual EstadoManutencaoPMO? IdEstadomanutencaopmoNavigation { get; set; }

    public virtual AuxUnidadeGeradora IdOrigemcoletaugeNavigation { get; set; } = null!;

    public virtual ICollection<ManutencaoPMO> IdManutencaopmocondicionada { get; set; } = new List<ManutencaoPMO>();

    public virtual ICollection<ManutencaoPMO> IdManutencaopmos { get; set; } = new List<ManutencaoPMO>();
}
