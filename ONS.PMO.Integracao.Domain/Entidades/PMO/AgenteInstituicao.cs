using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO
{
    public class AgenteInstituicao
    {
        public int IdAgenteInstituicao { get; set; }

        public string DscRazaosocial { get; set; } = null!;

        public string DscApelidorazaosocial { get; set; } = null!;

        public virtual ICollection<ColetaInsumo> TbColetainsumos { get; set; } = new List<ColetaInsumo>();

        public virtual ICollection<Gabarito> TbGabaritos { get; set; } = new List<Gabarito>();

        public virtual ICollection<LogNotificacao> TbLognotificacaos { get; set; } = new List<LogNotificacao>();

        public virtual ICollection<ManutencaoPmo> TbManutencaopmos { get; set; } = new List<ManutencaoPmo>();

        public virtual ICollection<ManutencaoProgramada> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramada>();

        public virtual ICollection<ConfiguracaoGestaoManutencao> IdConfiguracaogestaomanutencaos { get; set; } = new List<ConfiguracaoGestaoManutencao>();
    }

}

