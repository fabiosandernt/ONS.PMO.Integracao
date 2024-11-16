using ONS.PMO.Integracao.Domain.Entidades.BDT;
using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Domain.Entidades.PMO
{
    public class Agenteinstituicao
    {
        public int IdAgenteinstituicao { get; set; }

        public string DscRazaosocial { get; set; } = null!;

        public string DscApelidorazaosocial { get; set; } = null!;

        public virtual ICollection<ColetaInsumo> TbColetainsumos { get; set; } = new List<ColetaInsumo>();

        public virtual ICollection<Gabarito> TbGabaritos { get; set; } = new List<Gabarito>();

        public virtual ICollection<LogNotificacao> TbLognotificacaos { get; set; } = new List<LogNotificacao>();

        public virtual ICollection<ManutencaoPMO> TbManutencaopmos { get; set; } = new List<ManutencaoPMO>();

        public virtual ICollection<ManutencaoPrograma> TbManutencaoprogramada { get; set; } = new List<ManutencaoPrograma>();

        public virtual ICollection<ConfiguracaoGestaoManutencao> IdConfiguracaogestaomanutencaos { get; set; } = new List<ConfiguracaoGestaoManutencao>();
    }

}

