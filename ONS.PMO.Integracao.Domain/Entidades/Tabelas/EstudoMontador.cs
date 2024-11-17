using System;
using System.Collections.Generic;
using ONS.PMO.Integracao.Domain.Entidades.PMO;

namespace ONS.PMO.Integracao.Domain.Entidades.Tabelas;

public  class EstudoMontador
{
    public int IdEstudomontador { get; set; }

    public int IdSemanaoperativa { get; set; }

    public virtual SemanaOperativa IdSemanaoperativaNavigation { get; set; } = null!;

    public virtual ICollection<BlocoEstudoMontador> TbBlocoestudomontadors { get; set; } = new List<BlocoEstudoMontador>();

    public virtual ICollection<ChaveBlocoEstudo> TbChaveblocoestudos { get; set; } = new List<ChaveBlocoEstudo>();

    public virtual ICollection<ChaveMnemonicoEstudo> TbChavemnemonicoestudos { get; set; } = new List<ChaveMnemonicoEstudo>();

    public virtual ICollection<ConjuntoGeracaoMinima> TbConjuntogeracaominimas { get; set; } = new List<ConjuntoGeracaoMinima>();

    public virtual EstudoMontadorNaoOficial? TbEstudomontadornaooficial { get; set; }

    public virtual ICollection<EstudoSelecionado> TbEstudoselecionados { get; set; } = new List<EstudoSelecionado>();

    public virtual ICollection<GrandezaBlocoEstudo> TbGrandezablocoestudos { get; set; } = new List<GrandezaBlocoEstudo>();

    public virtual ICollection<GrandezaMnemonicoEstudo> TbGrandezamnemonicoestudos { get; set; } = new List<GrandezaMnemonicoEstudo>();

    public virtual ICollection<LimitesIntercambio> TbLimitesintercambios { get; set; } = new List<LimitesIntercambio>();

    public virtual ICollection<ManutencaoProgramada> TbManutencaoprogramada { get; set; } = new List<ManutencaoProgramada>();

    public virtual ManutencaoProgramadaEstudo? TbManutencaoprogramadaestudo { get; set; }

    public virtual ICollection<MneespEstudoMontador> TbMneespestudomontadors { get; set; } = new List<MneespEstudoMontador>();

    public virtual ICollection<MnemonicoEstudoMontador> TbMnemonicoestudomontadors { get; set; } = new List<MnemonicoEstudoMontador>();

    public virtual ICollection<ModificacaoConfiguracaoBlocoEstudo> TbModifconfigblocoestudos { get; set; } = new List<ModificacaoConfiguracaoBlocoEstudo>();

    public virtual ICollection<RecuperacaoDado> TbRecuperacaodadoIdEstudomontadordestinoNavigations { get; set; } = new List<RecuperacaoDado>();

    public virtual ICollection<RecuperacaoDado> TbRecuperacaodadoIdEstudomontadorfonteNavigations { get; set; } = new List<RecuperacaoDado>();

    public virtual ICollection<RestricaoEstudo> TbRestricaoestudos { get; set; } = new List<RestricaoEstudo>();

    public virtual ICollection<EstudoMontador> IdEstudomontadorrefs { get; set; } = new List<EstudoMontador>();

    public virtual ICollection<EstudoMontador> IdEstudomontadors { get; set; } = new List<EstudoMontador>();
}
