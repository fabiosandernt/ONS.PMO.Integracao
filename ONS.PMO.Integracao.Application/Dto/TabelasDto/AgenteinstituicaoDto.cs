namespace ONS.PMO.Integracao.Application.Dto.TabelasDto
{
    public  class AgenteinstituicaoDto
    {
        public int IdAgenteinstituicao { get; set; }

        public string DscRazaosocial { get; set; } = null!;

        public string DscApelidorazaosocial { get; set; } = null!;

        public virtual ICollection<ColetaInsumoDto> TbColetainsumos { get; set; } = new List<ColetaInsumoDto>();

        public virtual ICollection<GabaritoDto> TbGabaritos { get; set; } = new List<GabaritoDto>();

        public virtual ICollection<LogNotificacaoDto> TbLognotificacaos { get; set; } = new List<LogNotificacaoDto>();

        public virtual ICollection<ManutencaoPmoDto> TbManutencaopmos { get; set; } = new List<ManutencaoPmoDto>();

        public virtual ICollection<ManutencaoProgramadaDto> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramadaDto>();

        public virtual ICollection<ConfiguracaoGestaoManutencaoDto> IdConfiguracaogestaomanutencaos { get; set; } = new List<ConfiguracaoGestaoManutencaoDto>();
    }

}

