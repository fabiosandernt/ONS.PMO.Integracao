using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Application.Dto.PMO;

namespace ONS.PMO.Integracao.Application.Dto.TabelasDto;

public  class TbEstudomontadorDto
{
    public int IdEstudomontador { get; set; }

    public int IdSemanaoperativa { get; set; }

    public virtual TbSemanaoperativaDto IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual ICollection<TbBlocoestudomontadorDto> TbBlocoestudomontadors { get; set; } = new List<TbBlocoestudomontadorDto>();

    public virtual ICollection<TbChaveblocoestudoDto> TbChaveblocoestudos { get; set; } = new List<TbChaveblocoestudoDto>();

    public virtual ICollection<TbChavemnemonicoestudoDto> TbChavemnemonicoestudos { get; set; } = new List<TbChavemnemonicoestudoDto>();

    public virtual ICollection<TbConjuntogeracaominimaDto> TbConjuntogeracaominimas { get; set; } = new List<TbConjuntogeracaominimaDto>();

    public virtual TbEstudomontadornaooficialDto? TbEstudomontadornaooficial { get; set; }

    public virtual ICollection<TbEstudoselecionadoDto> TbEstudoselecionados { get; set; } = new List<TbEstudoselecionadoDto>();

    public virtual ICollection<TbGrandezablocoestudoDto> TbGrandezablocoestudos { get; set; } = new List<TbGrandezablocoestudoDto>();

    public virtual ICollection<TbGrandezamnemonicoestudoDto> TbGrandezamnemonicoestudos { get; set; } = new List<TbGrandezamnemonicoestudoDto>();

    public virtual ICollection<TbLimitesintercambioDto> TbLimitesintercambios { get; set; } = new List<TbLimitesintercambioDto>();

    public virtual ICollection<TbManutencaoprogramadumDto> TbManutencaoprogramada { get; set; } = new List<TbManutencaoprogramadumDto>();

    public virtual TbManutencaoprogramadaestudoDto? TbManutencaoprogramadaestudo { get; set; }

    public virtual ICollection<TbMneespestudomontadorDto> TbMneespestudomontadors { get; set; } = new List<TbMneespestudomontadorDto>();

    public virtual ICollection<TbMnemonicoestudomontadorDto> TbMnemonicoestudomontadors { get; set; } = new List<TbMnemonicoestudomontadorDto>();

    public virtual ICollection<TbModifconfigblocoestudoDto> TbModifconfigblocoestudos { get; set; } = new List<TbModifconfigblocoestudoDto>();

    public virtual ICollection<TbRecuperacaodadoDto> TbRecuperacaodadoIdEstudomontadordestinoNavigations { get; set; } = new List<TbRecuperacaodadoDto>();

    public virtual ICollection<TbRecuperacaodadoDto> TbRecuperacaodadoIdEstudomontadorfonteNavigations { get; set; } = new List<TbRecuperacaodadoDto>();

    public virtual ICollection<TbRestricaoestudoDto> TbRestricaoestudos { get; set; } = new List<TbRestricaoestudoDto>();

    public virtual ICollection<TbEstudomontadorDto> IdEstudomontadorrefs { get; set; } = new List<TbEstudomontadorDto>();

    public virtual ICollection<TbEstudomontadorDto> IdEstudomontadors { get; set; } = new List<TbEstudomontadorDto>();
}
