using System;
using System.Collections.Generic;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class EstudoMontadorDto
{
    public int IdEstudomontador { get; set; }

    public int IdSemanaoperativa { get; set; }

    public virtual SemanaOperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual ICollection<BlocoEstudoMontadorDto> TbBlocoestudomontadors { get; set; } = new List<BlocoEstudoMontadorDto>();

    public virtual ICollection<ChaveBlocoEstudoDto> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudoDto>();

    public virtual ICollection<ChaveMnemonicoEstudoDto> TbChavemnemonicoestudos { get; set; } = new List<ChaveMnemonicoEstudoDto>();

    public virtual ICollection<ConjuntoGeracaoMinimaDto> TbConjuntogeracaominimas { get; set; } = new List<ConjuntoGeracaoMinimaDto>();

    public virtual EstudoMontadorNaoOficialDto? TbEstudomontadornaooficial { get; set; }

    public virtual ICollection<EstudoSelecionadoDto> TbEstudoselecionados { get; set; } = new List<EstudoSelecionadoDto>();

    public virtual ICollection<GrandezaBlocoEstudoDto> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudoDto>();

    public virtual ICollection<GrandezaMnemonicoEstudoDto> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudoDto>();

    public virtual ICollection<LimitesIntercambioDto> TbLimitesintercambios { get; set; } = new List<LimitesIntercambioDto>();

    public virtual ICollection<ManutencaoProgramadaDto> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramadaDto>();

    public virtual ManutencaoProgramadaEstudoDto? TbManutencaoprogramadaestudo { get; set; }

    public virtual ICollection<MneespEstudoMontadorDto> TbMneespestudomontadors { get; set; } = new List<MneespEstudoMontadorDto>();

    public virtual ICollection<MnemonicoEstudoMontadorDto> TbMnemonicoestudomontadors { get; set; } = new List<MnemonicoEstudoMontadorDto>();

    public virtual ICollection<ModifConfigBlocoEstudoDto> TbModifconfigblocoestudos { get; set; } = new List<ModifConfigBlocoEstudoDto>();

    public virtual ICollection<RecuperacaoDadoDto> TbRecuperacaodadoIdEstudomontadordestinoNavigations { get; set; } = new List<RecuperacaoDadoDto>();

    public virtual ICollection<RecuperacaoDadoDto> TbRecuperacaodadoIdEstudomontadorfonteNavigations { get; set; } = new List<RecuperacaoDadoDto>();

    public virtual ICollection<RestricaoEstudoDto> TbRestricaoestudos { get; set; } = new List<RestricaoEstudoDto>();

    public virtual ICollection<EstudoMontadorDto> IdEstudomontadorrefs { get; set; } = new List<EstudoMontadorDto>();

    public virtual ICollection<EstudoMontadorDto> IdEstudomontadors { get; set; } = new List<EstudoMontadorDto>();
}
