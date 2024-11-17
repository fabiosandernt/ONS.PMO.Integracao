using ONS.PMO.Integracao.Domain.Entidades.Auxiliar;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO;

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

    public virtual AgenteInstituicao IdAgenteinstituicaoNavigation { get; set; } = null!;

    public virtual ConfiguracaoGestaoManutencao? IdConfiguracaogestaomanutencaoNavigation { get; set; }

    public virtual EstadoManutencaoPmo? IdEstadomanutencaopmoNavigation { get; set; }

    public virtual TbAuxUnidadegeradora IdOrigemcoletaugeNavigation { get; set; } = null!;

    public virtual ICollection<ManutencaoPMO> IdManutencaopmocondicionada { get; set; } = new List<ManutencaoPMO>();

    public virtual ICollection<ManutencaoPMO> IdManutencaopmos { get; set; } = new List<ManutencaoPMO>();
}
