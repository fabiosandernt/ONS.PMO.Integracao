using ONS.PMO.Integracao.Domain.Entidades.Tabelas;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto
{
    public  class TbAgenteinstituicaoDto
    {
        public int IdAgenteInstituicao { get; set; }

        public string DscRazaosocial { get; set; } = null!;

        public string DscApelidorazaosocial { get; set; } = null!;

        public virtual ICollection<TbColetainsumoDto> TbColetainsumos { get; set; } = new List<TbColetainsumoDto>();

        public virtual ICollection<TbGabaritoDto> TbGabaritos { get; set; } = new List<TbGabaritoDto>();

        public virtual ICollection<TbLognotificacaoDto> TbLognotificacaos { get; set; } = new List<TbLognotificacaoDto>();

        public virtual ICollection<TbManutencaopmoDto> TbManutencaopmos { get; set; } = new List<TbManutencaopmoDto>();

        public virtual ICollection<TbManutencaoprogramadumDto> TbManutencaoprogramada { get; set; } = new List<TbManutencaoprogramadumDto>();

        public virtual ICollection<TbConfiguracaogestaomanutencaoDto> IdConfiguracaogestaomanutencaos { get; set; } = new List<TbConfiguracaogestaomanutencaoDto>();
    }

}

